﻿using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Application.Features.GeneralFAQs.Commands.DeleteGeneralFAQ
{
    public class DeleteGeneralFAQHandler : IRequestHandler<DeleteGeneralFAQCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<GeneralFrequentlyAskedQuestion> _GeneralFAQRepository;
        public DeleteGeneralFAQHandler(IAsyncRepository<GeneralFrequentlyAskedQuestion> GeneralFAQRepository)
        {
            _GeneralFAQRepository = GeneralFAQRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteGeneralFAQCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GeneralFrequentlyAskedQuestion? GeneralFAQEntityToDelete = await _GeneralFAQRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (GeneralFAQEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "General FAQ is Not Found"
                    : "السؤال الشائع العام غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _GeneralFAQRepository.DeleteAsync(GeneralFAQEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "General FAQ has been Deleted successfully"
                : "تم حذف السؤال الشائع العام بنجاح";

            return new BaseResponse<object>(ResponseMessage, false, 404);
        }
    }
}
