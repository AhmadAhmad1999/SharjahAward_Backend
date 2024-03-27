using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitrator
{
    public class DeleteArbitratorHandler : IRequestHandler<DeleteArbitratorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;

        public DeleteArbitratorHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IUserRepository UserRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _UserRepository = UserRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteArbitratorCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitrator? ArbitratorEntityToDelete = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ArbitratorEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not found"
                    : "المحكم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Domain.Entities.IdentityModels.User? UserEntityToDelete = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<DynamicAttributeValue> DynamicAttributeValues = await _DynamicAttributeValueRepository
                .Where(x => x.RecordIdAsGuid == Request.Id)
                .ToListAsync();

            using (TransactionScope Transaction = new TransactionScope())
            {
                try
                {
                    await _ArbitratorRepository.DeleteAsync(ArbitratorEntityToDelete);
                    await _UserRepository.DeleteAsync(UserEntityToDelete);

                    if (DynamicAttributeValues.Count() > 0)
                        await _DynamicAttributeValueRepository.DeleteListAsync(DynamicAttributeValues);

                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator has been deleted successfully"
                        : "تم حذف المحكم بنجاح";

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
