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
                                    EnglishDescription = x.EnglishDescription,
                                    ArbitrationScaleId = NewArbitrationScaleEntity.Id
                                });

                        await _ArbitrationScalesCriterionRepository.AddRangeAsync(NewArbitrationScalesCriterionEntities);
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
