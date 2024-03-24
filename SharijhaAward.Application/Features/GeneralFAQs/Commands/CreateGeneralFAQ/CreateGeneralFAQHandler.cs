using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Application.Features.GeneralFAQs.Commands.CreateGeneralFAQ
{
    public class CreateGeneralFAQHandler : IRequestHandler<CreateGeneralFAQCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<GeneralFAQ> _GeneralFAQRepository;
        private readonly IMapper _Mapper;

        public CreateGeneralFAQHandler(IMapper Mapper,
            IAsyncRepository<GeneralFAQ> GeneralFrequentlyAskedQuestionRepository)
        {
            _Mapper = Mapper;
            _GeneralFAQRepository = GeneralFrequentlyAskedQuestionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateGeneralFAQCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GeneralFAQ GeneralFAQEntity = _Mapper.Map<GeneralFAQ>(Request);

            await _GeneralFAQRepository.AddAsync(GeneralFAQEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء السؤال الشائع العام بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
