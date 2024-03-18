using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Application.Features.GeneralFAQs.Commands.UpdateGeneralFAQ
{
    public class UpdateGeneralFAQHandler : IRequestHandler<UpdateGeneralFAQCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<GeneralFrequentlyAskedQuestion> _GeneralFAQRepository;
        private readonly IMapper _Mapper;

        public UpdateGeneralFAQHandler(IMapper Mapper,
            IAsyncRepository<GeneralFrequentlyAskedQuestion> GeneralFAQRepository)
        {
            _GeneralFAQRepository = GeneralFAQRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateGeneralFAQCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GeneralFrequentlyAskedQuestion? GeneralFAQEntityToUpdate = await _GeneralFAQRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (GeneralFAQEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "General FAQ is not found"
                    : "السؤال الشائع العام غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, GeneralFAQEntityToUpdate, typeof(UpdateGeneralFAQCommand), typeof(GeneralFrequentlyAskedQuestion));

            await _GeneralFAQRepository.UpdateAsync(GeneralFAQEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "General FAQ has been updated successfully"
                : "تم تعديل السؤال الشائع العام بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
