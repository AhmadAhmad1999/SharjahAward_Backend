using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Application.Features.Classes.Queries.GetClassById
{
    public class GetClassByIdHandler : IRequestHandler<GetClassByIdQuery, BaseResponse<GetClassByIdDto>>
    {
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IMapper _Mapper;
        public GetClassByIdHandler(IAsyncRepository<EducationalClass> EducationalClassRepository,
            IMapper Mapper)
        {
            _EducationalClassRepository = EducationalClassRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetClassByIdDto>> Handle(GetClassByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalClass? EducationalClassEntity = await _EducationalClassRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalClassEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Class is not Found"
                    : "الصف غير موجود";

                return new BaseResponse<GetClassByIdDto>(ResponseMessage, false, 404);
            }

            GetClassByIdDto GetClassByIdDto = _Mapper.Map<GetClassByIdDto>(EducationalClassEntity);

            return new BaseResponse<GetClassByIdDto>(ResponseMessage, true, 200, GetClassByIdDto);
        }
    }
}
