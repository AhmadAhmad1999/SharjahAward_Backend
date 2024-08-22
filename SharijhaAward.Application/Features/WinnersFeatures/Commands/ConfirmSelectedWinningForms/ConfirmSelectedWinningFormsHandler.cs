using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.WinnersFeatures.Commands.ConfirmSelectedWinningForms
{
    public class ConfirmSelectedWinningFormsHandler : IRequestHandler<ConfirmSelectedWinningFormsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;

        public ConfirmSelectedWinningFormsHandler(IAsyncRepository<ArbitrationResult> ArbitrationResultRepository)
        {
            _ArbitrationResultRepository = ArbitrationResultRepository;
        }

        public async Task<BaseResponse<object>> Handle(ConfirmSelectedWinningFormsCommand Request, CancellationToken cancellationToken)
        {
            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            if (Request.EducationalClassId is null)
            {
                using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                    TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId && x.SelectedToWin)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.SelectedToWin, true));

                        await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId && x.SelectedToWin)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.NotifiedAsWinner, true));

                        await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Where(x => x.SelectedToWin &&
                                x.ProvidedForm!.categoryId == Request.CategoryId)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.WinningDate, DateTime.UtcNow));

                        await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Where(x => x.SelectedToWin &&
                                x.ProvidedForm!.categoryId == Request.CategoryId)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.Winner, true));

                        List<IGrouping<float, ArbitrationResult>> ArbitrationResultEntities = _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Where(x => x.SelectedToWin &&
                                x.ProvidedForm!.categoryId == Request.CategoryId)
                            .GroupBy(x => x.FinalArbitration!.FinalScore)
                            .AsEnumerable()
                            .OrderByDescending(x => x.Key)
                            .ToList();

                        int FirstWinningLevel = 1;

                        foreach (IGrouping<float, ArbitrationResult> ArbitrationResultEntity in ArbitrationResultEntities)
                        {
                            await _ArbitrationResultRepository
                                .Include(x => x.ProvidedForm!)
                                .Where(x => ArbitrationResultEntity.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                                .ExecuteUpdateAsync(x => x.SetProperty(y => y.WinningLevel, FirstWinningLevel));

                            FirstWinningLevel++;
                        }

                        Transaction.Complete();

                        string ResponseMessage = Request.lang == "en"
                            ? "Winners in this category were successfully selected"
                            : "تم اختيار الفائزين في هذه الفئة بنجاح";

                        return new BaseResponse<object>(ResponseMessage, true, 200);
                    }
                    catch (Exception)
                    {
                        Transaction.Dispose();
                        throw;
                    }
                }
            }
            else
            {
                using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                    TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.CategoryEducationalClass!)
                            .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId && x.SelectedToWin &&
                                x.ProvidedForm!.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.SelectedToWin, true));

                        await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.CategoryEducationalClass!)
                            .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId && x.SelectedToWin &&
                                x.ProvidedForm!.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.NotifiedAsWinner, true));

                        await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.CategoryEducationalClass!)
                            .Where(x => x.SelectedToWin &&
                                x.ProvidedForm!.categoryId == Request.CategoryId &&
                                x.ProvidedForm!.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.WinningDate, DateTime.UtcNow));

                        await _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Where(x => x.SelectedToWin &&
                                x.ProvidedForm!.categoryId == Request.CategoryId)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.Winner, true));

                        List<IGrouping<float, ArbitrationResult>> ArbitrationResultEntities = _ArbitrationResultRepository
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.CategoryEducationalClass!)
                            .Where(x => x.SelectedToWin &&
                                x.ProvidedForm!.categoryId == Request.CategoryId &&
                                x.ProvidedForm!.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId)
                            .GroupBy(x => x.FinalArbitration!.FinalScore)
                            .AsEnumerable()
                            .OrderByDescending(x => x.Key)
                            .ToList();

                        int FirstWinningLevel = 1;

                        foreach (IGrouping<float, ArbitrationResult> ArbitrationResultEntity in ArbitrationResultEntities)
                        {
                            await _ArbitrationResultRepository
                                .Include(x => x.ProvidedForm!)
                                .Where(x => ArbitrationResultEntity.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                                .ExecuteUpdateAsync(x => x.SetProperty(y => y.WinningLevel, FirstWinningLevel));

                            FirstWinningLevel++;
                        }

                        Transaction.Complete();

                        string ResponseMessage = Request.lang == "en"
                            ? "Winners in this category's class were successfully selected"
                            : "تم اختيار الفائزين في صف هذه الفئة بنجاح";

                        return new BaseResponse<object>(ResponseMessage, true, 200);
                    }
                    catch (Exception)
                    {
                        Transaction.Dispose();
                        throw;
                    }
                }
            }
        }
    }
}
