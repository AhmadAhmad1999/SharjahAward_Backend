using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationScaleModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.CreateArbitrationScale
{
    public class CreateArbitrationScaleHandler : IRequestHandler<CreateArbitrationScaleCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<ArbitrationScale> _ArbitrationScaleRepository;
        private readonly IAsyncRepository<ArbitrationScalesCriterion> _ArbitrationScalesCriterionRepository;

        public CreateArbitrationScaleHandler(IMapper Mapper,
            IAsyncRepository<ArbitrationScale> ArbitrationScaleRepository,
            IAsyncRepository<ArbitrationScalesCriterion> ArbitrationScalesCriterionRepository)
        {
            _Mapper = Mapper;
            _ArbitrationScaleRepository = ArbitrationScaleRepository;
            _ArbitrationScalesCriterionRepository = ArbitrationScalesCriterionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateArbitrationScaleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

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
                    foreach (ArbitrationScaleDto ArbitrationScaleDto in Request.ArbitrationScaleDtos)
                    {
                        if (ArbitrationScaleDto.Id == 0)
                        {
                            ArbitrationScale NewArbitrationScaleEntity = _Mapper.Map<ArbitrationScale>(ArbitrationScaleDto);

                            NewArbitrationScaleEntity.CategoryId = Request.CategoryId;

                            await _ArbitrationScaleRepository.AddAsync(NewArbitrationScaleEntity);

                            IEnumerable<ArbitrationScalesCriterion> NewArbitrationScalesCriterionEntities =
                                ArbitrationScaleDto.ArbitrationScaleCriterionDto
                                    .Select(x => new ArbitrationScalesCriterion()
                                    {
                                        ArabicDescription = x.ArabicDescription,
                                        CriterionItemId = x.CriterionItemId,
                                        CriterionId = x.CriterionId,
                                        EnglishDescription = "No Value",
                                        ArbitrationScaleId = NewArbitrationScaleEntity.Id
                                    });

                            await _ArbitrationScalesCriterionRepository.AddRangeAsync(NewArbitrationScalesCriterionEntities);
                        }
                        else
                        {
                            ArbitrationScale? ArbitrationScaleEntityToUpdate = await _ArbitrationScaleRepository
                                .FirstOrDefaultAsync(x => x.Id == ArbitrationScaleDto.Id);

                            if (ArbitrationScaleEntityToUpdate == null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Arbitration scale is not found"
                                    : "مقياس التحكيم غير موجود";

                                return new BaseResponse<object>(ResponseMessage, false, 404);
                            }

                            _Mapper.Map(ArbitrationScaleDto, ArbitrationScaleEntityToUpdate, typeof(ArbitrationScaleDto), typeof(ArbitrationScale));

                            await _ArbitrationScaleRepository.UpdateAsync(ArbitrationScaleEntityToUpdate);

                            foreach (ArbitrationScaleCriterionDto ArbitrationScaleCriterion in ArbitrationScaleDto.ArbitrationScaleCriterionDto)
                            {
                                ArbitrationScalesCriterion? ArbitrationScalesCriterionEntityToUpdate = await _ArbitrationScalesCriterionRepository
                                    .FirstOrDefaultAsync(x => x.Id == ArbitrationScaleCriterion.Id);

                                if (ArbitrationScaleEntityToUpdate is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? "Arbitration scale criterion is not found"
                                        : "مقياس التحكيم غير موجود";

                                    return new BaseResponse<object>(ResponseMessage, false, 404);
                                }

                                _Mapper.Map(ArbitrationScaleCriterion, ArbitrationScalesCriterionEntityToUpdate, typeof(ArbitrationScaleCriterionDto), typeof(ArbitrationScalesCriterion));

                                ArbitrationScalesCriterionEntityToUpdate!.EnglishDescription = "No Value";

                                await _ArbitrationScalesCriterionRepository.UpdateAsync(ArbitrationScalesCriterionEntityToUpdate!);
                            }
                        }
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المقياس بنجاح";

                    Transaction.Complete();

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
