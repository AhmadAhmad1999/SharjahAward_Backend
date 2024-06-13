﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using System.Transactions;

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
            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _ArbitrationResultRepository
                        .Include(x => x.ProvidedForm!)
                        .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                            x.ProvidedForm!.categoryId == Request.CategoryId)
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.Winner, true));

                    await _ArbitrationResultRepository
                        .Include(x => x.ProvidedForm!)
                        .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                            x.ProvidedForm!.categoryId == Request.CategoryId)
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.WinningDate, DateTime.UtcNow));

                    List<IGrouping<float, ArbitrationResult>> ArbitrationResultEntities = await _ArbitrationResultRepository
                        .Include(x => x.ProvidedForm!)
                        .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                            x.ProvidedForm!.categoryId == Request.CategoryId)
                        .GroupBy(x => x.FinalArbitration!.FinalScore)
                        .OrderByDescending(x => x.Key)
                        .ToListAsync();

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
    }
}
