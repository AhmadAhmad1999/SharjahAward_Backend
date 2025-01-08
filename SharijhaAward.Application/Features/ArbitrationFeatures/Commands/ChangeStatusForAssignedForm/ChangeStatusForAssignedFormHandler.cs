using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.ChangeStatusForAssignedForm
{
    public class ChangeStatusForAssignedFormHandler : IRequestHandler<ChangeStatusForAssignedFormCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IJwtProvider _JWTProvider;

        public ChangeStatusForAssignedFormHandler(IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IJwtProvider JwtProvider)
        {
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _JWTProvider = JwtProvider;
        }


        public async Task<BaseResponse<object>> Handle(ChangeStatusForAssignedFormCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.token!));

            Arbitration? ArbitrationEntity = await _ArbitrationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ArbitrationEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration not found"
                    : "هذا التحكيم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            if (ArbitratorEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not found"
                    : "المحكم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }
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
                    if (Request.isAccepted == FormStatus.Rejected &&
                        ArbitratorEntity.isChairman &&
                        (Request.AsChairman != null ? Request.AsChairman.Value : false))
                    {
                        // ArbitrationEntity.Type = ArbitrationType.BeingReviewed;

                        ArbitrationEntity.isAcceptedFromChairman = Request.isAccepted;

                        ArbitrationEntity.ReasonForRejecting = Request.ReasonForRejecting;
                    }
                    else if (Request.isAccepted == FormStatus.Rejected &&
                        ArbitratorEntity.isChairman &&
                        (Request.AsChairman != null ? !Request.AsChairman.Value : false))
                    {
                        // ArbitrationEntity.Type = ArbitrationType.BeingReviewed;

                        ArbitrationEntity.isAccepted = Request.isAccepted;
                        ArbitrationEntity.SortedAt = DateTime.UtcNow;

                        ArbitrationEntity.ReasonForRejecting = Request.ReasonForRejecting;
                    }
                    else if (Request.isAccepted == FormStatus.Accepted &&
                        (ArbitratorEntity.isChairman &&
                        (Request.AsChairman != null ? Request.AsChairman.Value : false)))
                    {
                        // ArbitrationEntity.Type = ArbitrationType.DoneArbitratod;

                        ArbitrationEntity.isAcceptedFromChairman = Request.isAccepted;
                    }
                    else if (Request.isAccepted == FormStatus.Accepted &&
                        (ArbitratorEntity.isChairman &&
                        (Request.AsChairman != null ? !Request.AsChairman.Value : false)))
                    {
                        // ArbitrationEntity.Type = ArbitrationType.DoneArbitratod;
                        ArbitrationEntity.SortedAt = DateTime.UtcNow;

                        ArbitrationEntity.isAccepted = Request.isAccepted;
                    }
                    else if (Request.isAccepted == FormStatus.NotArbitratedYet)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "You can't change the acceptance status of an arbitration into Not Arbitrated Yet"
                            : "لا يمكنك تغيير حالة قبول التحكيم إلى \"لم يتم التحكيم بعد\"";

                        return new BaseResponse<object>(ResponseMessage, false, 400);
                    }
                    else 
                    {
                        ArbitrationEntity.SortedAt = DateTime.UtcNow;
                        ArbitrationEntity.isAccepted = Request.isAccepted;

                        if (Request.isAccepted == FormStatus.Rejected)
                        {
                            ArbitrationEntity.ReasonForRejecting = Request.ReasonForRejecting;
                        }
                    }

                    await _ArbitrationRepository.UpdateAsync(ArbitrationEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Form's status has been updated successfully"
                        : "تم تعديل حالة الاستمارة المسندة بنجاح";

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
