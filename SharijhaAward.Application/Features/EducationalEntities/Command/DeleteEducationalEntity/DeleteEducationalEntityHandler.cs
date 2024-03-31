using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.DeleteEducationalEntity
{
    public class DeleteEducationalEntityHandler : IRequestHandler<DeleteEducationalEntityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        public DeleteEducationalEntityHandler(IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteEducationalEntityCommand Request, CancellationToken cancellationToken)
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
                    EducationalEntity? EducationalEntityToDelete = await _EducationalEntityRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (EducationalEntityToDelete == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Educational entity is not found"
                            : "الجهة التعليمية غير موجودة";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    List<EducationalInstitution> EducationalInstitutionEntitiesToDelete = await _EducationalInstitutionRepository
                        .Where(x => x.EducationalEntityId == EducationalEntityToDelete.Id)
                        .ToListAsync();

                    await _EducationalEntityRepository.DeleteAsync(EducationalEntityToDelete);

                    if (EducationalInstitutionEntitiesToDelete.Count() > 0)
                        await _EducationalInstitutionRepository.DeleteListAsync(EducationalInstitutionEntitiesToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "Educational entity has been deleted successfully"
                        : "تم حذف الجهة التعليمية بنجاح";

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
