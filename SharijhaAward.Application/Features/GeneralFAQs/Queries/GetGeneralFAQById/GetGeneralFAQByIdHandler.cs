using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetGeneralFAQById
{
    public class GetGeneralFAQByIdHandler : IRequestHandler<GetGeneralFAQByIdQuery, BaseResponse<GeneralFAQDto>>
    {
        private readonly IAsyncRepository<GeneralFAQ> _GeneralFAQRepository;
        private readonly IMapper _Mapper;

        public GetGeneralFAQByIdHandler(IMapper Mapper,
            IAsyncRepository<GeneralFAQ> GeneralFAQRepository)
        {
            _GeneralFAQRepository = GeneralFAQRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GeneralFAQDto>> Handle(GetGeneralFAQByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GeneralFAQ? GeneralFAQEntity = await _GeneralFAQRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (GeneralFAQEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "General FAQ is not found"
                    : "السؤال الشائع العام غير موجود";

                return new BaseResponse<GeneralFAQDto>(ResponseMessage, false, 404);
            }

            GeneralFAQDto GeneralFAQDto = _Mapper.Map<GeneralFAQDto>(GeneralFAQEntity);

            return new BaseResponse<GeneralFAQDto>(ResponseMessage, true, 200, GeneralFAQDto);
        }
    }
}
