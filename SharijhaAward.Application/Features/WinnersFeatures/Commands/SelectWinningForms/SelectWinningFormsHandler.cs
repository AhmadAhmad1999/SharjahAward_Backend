using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;

namespace SharijhaAward.Application.Features.WinnersFeatures.Commands.SelectWinningForms
{
    public class SelectWinningFormsHandler : IRequestHandler<SelectWinningFormsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;

        public SelectWinningFormsHandler(IAsyncRepository<ArbitrationResult> ArbitrationResultRepository)
        {
            _ArbitrationResultRepository = ArbitrationResultRepository;
        }

        public async Task<BaseResponse<object>> Handle(SelectWinningFormsCommand Request, CancellationToken cancellationToken)
        {
            if (Request.NewFormId is not null)
            {
                await _ArbitrationResultRepository
                    .Include(x => x.ProvidedForm!)
                    .Where(x => Request.NewFormId == x.ProvidedFormId &&
                        x.ProvidedForm!.categoryId == Request.CategoryId)
                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.SelectedToWin, true));

                string ResponseMessage = Request.lang == "en"
                    ? "Winner in this category were selected successfully"
                    : "تم اختيار الفائز في هذه الفئة بنجاح";

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }
            else
            {
                await _ArbitrationResultRepository
                    .Include(x => x.ProvidedForm!)
                    .Where(x => Request.DeleteFormId == x.ProvidedFormId &&
                        x.ProvidedForm!.categoryId == Request.CategoryId)
                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.SelectedToWin, false));

                string ResponseMessage = Request.lang == "en"
                    ? "Winner in this category were unselected successfully"
                    : "تم إزالة الفائز في هذه الفئة بنجاح";

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }
        }
    }
}
