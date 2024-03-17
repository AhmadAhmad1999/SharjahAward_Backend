using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.GeneralFAQs.Commands.DeleteGeneralFAQ;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Commands.DeleteGeneralFAQCategory
{
    public class DeleteGeneralFAQCategoryHandler : IRequestHandler<DeleteGeneralFAQCategoryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<GeneralFrequentlyAskedQuestionCategory> _GeneralFAQCategoryRepository;
        public DeleteGeneralFAQCategoryHandler(IAsyncRepository<GeneralFrequentlyAskedQuestionCategory> GeneralFAQCategoryRepository)
        {
            _GeneralFAQCategoryRepository = GeneralFAQCategoryRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteGeneralFAQCategoryCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GeneralFrequentlyAskedQuestionCategory? GeneralFAQCategoryEntityToDelete = await _GeneralFAQCategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (GeneralFAQCategoryEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "General FAQ category is not found"
                    : "فئة السؤال الشائع العام غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _GeneralFAQCategoryRepository.DeleteAsync(GeneralFAQCategoryEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "General FAQ category has been Deleted successfully"
                : "تم حذف فئة السؤال الشائع العام بنجاح";

            return new BaseResponse<object>(ResponseMessage, false, 404);
        }
    }
}
