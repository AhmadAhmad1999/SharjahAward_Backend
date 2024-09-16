using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinator
{
    public class DeleteCoordinatorHandler : IRequestHandler<DeleteCoordinatorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
<<<<<<< HEAD
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;

        public DeleteCoordinatorHandler(IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IUserRepository UserRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _CoordinatorRepository = CoordinatorRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _UserRepository = UserRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
=======

        public DeleteCoordinatorHandler(IAsyncRepository<Coordinator> CoordinatorRepository)
        {
            _CoordinatorRepository = CoordinatorRepository;
>>>>>>> ArbitrationFeeback_1
        }

        public async Task<BaseResponse<object>> Handle(DeleteCoordinatorCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Coordinator? CoordinatorEntityToDelete = await _CoordinatorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CoordinatorEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Coordinator is not found"
                    : "المنسق غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _CoordinatorRepository.DeleteAsync(CoordinatorEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Coordinator has been deleted successfully"
                : "تم حذف المنسق بنجاح";

<<<<<<< HEAD
                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<DynamicAttributeValue> DynamicAttributeValues = await _DynamicAttributeValueRepository
                .Where(x => x.RecordIdAsGuid == Request.Id)
                .ToListAsync();

            var EduEntitiesCoordinatorRepository = await _EduEntitiesCoordinatorRepository
                .Where(x => x.CoordinatorId == Request.Id)
                .ToListAsync();

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
                    await _CoordinatorRepository.DeleteAsync(CoordinatorEntityToDelete);
                    await _UserRepository.DeleteAsync(UserEntityToDelete);

                    if (DynamicAttributeValues.Count() > 0)
                        await _DynamicAttributeValueRepository.DeleteListAsync(DynamicAttributeValues);

                    if (EduEntitiesCoordinatorRepository.Count() > 0)
                        await _EduEntitiesCoordinatorRepository.DeleteListAsync(EduEntitiesCoordinatorRepository);

                    ResponseMessage = Request.lang == "en"
                        ? "Coordinator has been deleted successfully"
                        : "تم حذف المنسق بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
=======
            return new BaseResponse<object>(ResponseMessage, true, 200);
>>>>>>> ArbitrationFeeback_1
        }
    }
}
