using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InstructionModel;

namespace SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetInstructionBySlugId
{
    public class GetInstructionBySlugIdHandler : IRequestHandler<GetInstructionBySlugIdQuery, BaseResponse<GetInstructionBySlugIdDto>>
    {
        private readonly IAsyncRepository<Instruction> _InstructionRepository;
        private readonly IMapper _Mapper;
        public GetInstructionBySlugIdHandler(IAsyncRepository<Instruction> InstructionRepository,
            IMapper Mapper)
        {
            _InstructionRepository = InstructionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GetInstructionBySlugIdDto>> Handle(GetInstructionBySlugIdQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.Id is null && string.IsNullOrEmpty(Request.Slug))
            {
                ResponseMessage = Request.lang == "en"
                    ? "You must send either id or slug in request"
                    : "يجب عليك إرسال إحدى فلتري البحث عن إرشاد";

                return new BaseResponse<GetInstructionBySlugIdDto>(ResponseMessage, false, 404);
            }

            Instruction? InstructionEntity = await _InstructionRepository
                .FirstOrDefaultAsync(x => Request.Id != null 
                    ? x.Id == Request.Id        
                    : x.Slug.ToLower() == Request.Slug!.ToLower());

            if (InstructionEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Instruction is not Found"
                    : "الإرشاد غير موجود";

                return new BaseResponse<GetInstructionBySlugIdDto>(ResponseMessage, false, 404);
            }

            GetInstructionBySlugIdDto GetInstructionBySlugIdDto = _Mapper.Map<GetInstructionBySlugIdDto>(InstructionEntity);

            return new BaseResponse<GetInstructionBySlugIdDto>(ResponseMessage, true, 200, GetInstructionBySlugIdDto);
        }
    }
}
