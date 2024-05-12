using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationScaleModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.UpdateArbitrationScale
{
    public class UpdateArbitrationScaleHandler : IRequestHandler<UpdateArbitrationScaleCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<ArbitrationScale> _ArbitrationScaleRepository;
        private readonly IAsyncRepository<ArbitrationScalesCriterion> _ArbitrationScalesCriterionRepository;

        public UpdateArbitrationScaleHandler(IMapper Mapper,
            IAsyncRepository<ArbitrationScale> ArbitrationScaleRepository,
            IAsyncRepository<ArbitrationScalesCriterion> ArbitrationScalesCriterionRepository)
        {
            _Mapper = Mapper;
            _ArbitrationScaleRepository = ArbitrationScaleRepository;
            _ArbitrationScalesCriterionRepository = ArbitrationScalesCriterionRepository;
        }
        public async Task<BaseResponse<object>> Handle(UpdateArbitrationScaleCommand Request, CancellationToken cancellationToken)
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
                    foreach (UpdateArbitrationScaleDto ArbitrationScaleDto in Request.ArbitrationScaleDtos)
                    {
                        if (ArbitrationScaleDto.Id != 0)
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

                            _Mapper.Map(ArbitrationScaleDto, ArbitrationScaleEntityToUpdate, typeof(UpdateArbitrationScaleDto), typeof(ArbitrationScale));

                            await _ArbitrationScaleRepository.UpdateAsync(ArbitrationScaleEntityToUpdate);

                            foreach (UpdateArbitrationScaleCriterionDto ArbitrationScaleCriterion in ArbitrationScaleDto.ArbitrationScaleCriterionDto)
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

                                _Mapper.Map(ArbitrationScaleCriterion, ArbitrationScalesCriterionEntityToUpdate, typeof(UpdateArbitrationScaleCriterionDto), typeof(ArbitrationScalesCriterion));

                                await _ArbitrationScalesCriterionRepository.UpdateAsync(ArbitrationScalesCriterionEntityToUpdate!);
                            }
                        }
                        else
                        {
                            ArbitrationScale NewArbitrationScaleEntity = _Mapper.Map<ArbitrationScale>(ArbitrationScaleDto);

                            await _ArbitrationScaleRepository.AddAsync(NewArbitrationScaleEntity);

                            foreach (UpdateArbitrationScaleCriterionDto ArbitrationScaleCriterion in ArbitrationScaleDto.ArbitrationScaleCriterionDto)
                            {
                                ArbitrationScalesCriterion NewArbitrationScalesCriterionEntity = _Mapper.Map<ArbitrationScalesCriterion>(ArbitrationScaleCriterion);

                                await _ArbitrationScalesCriterionRepository.AddAsync(NewArbitrationScalesCriterionEntity);
                            }
                        }
                    }
                    
                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Scales has been updated successfully"
                        : "تم تعديل المقاييس بنجاح";

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
