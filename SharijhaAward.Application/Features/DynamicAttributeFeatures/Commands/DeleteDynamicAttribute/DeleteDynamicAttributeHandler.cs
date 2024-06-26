using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.DeleteDynamicAttribute
{
    public class DeleteDynamicAttributeHandler : IRequestHandler<DeleteDynamicAttributeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<ViewWhenRelation> _ViewWhenRelationRepository;
        public DeleteDynamicAttributeHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<Dependency> DependencyRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<ViewWhenRelation> ViewWhenRelationRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DependencyRepository = DependencyRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _ViewWhenRelationRepository = ViewWhenRelationRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            IQueryable<Dependency> Dependencies = _DependencyRepository
                .WhereThenInclude(x => x.DynamicAttributeId == Request.Id, x => x.MainDynamicAttribute!);
            
            if (Dependencies.Count() > 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This field can't be deleted because it's related as dependency with another field"
                    : "لا يمكن حذف هذا الحقل لانه مرتبط بحقل اخر";
                
                return new BaseResponse<object>()
                {
                    data = Dependencies.Select(x => new
                    {
                        Name = Request.lang == "en"
                            ? x.MainDynamicAttribute!.EnglishLabel
                            : x.MainDynamicAttribute!.ArabicLabel
                    }),
                    message = ResponseMessage,
                    pagination = null,
                    statusCode = 400,
                    success = false
                };
            }

            DynamicAttribute? DynamicAttributeToDelete = await _DynamicAttributeRepository.GetByIdAsync(Request.Id);

            if (DynamicAttributeToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<DynamicAttributeValue> DynamicAttributeValueToDelete = await _DynamicAttributeValueRepository
                .Where(x => x.DynamicAttributeId == Request.Id)
                .ToListAsync();

            List<ViewWhenRelation> ViewWhenRelationToDelete = await _ViewWhenRelationRepository
                .Where(x => x.DynamicAttributeId == Request.Id ||
                    x.DynamicAttributeListValue!.DynamicAttributeId == Request.Id)
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
                    await _DynamicAttributeRepository.DeleteAsync(DynamicAttributeToDelete);

                    if (DynamicAttributeValueToDelete.Any())
                        await _DynamicAttributeValueRepository.DeleteListAsync(DynamicAttributeValueToDelete);

                    if (ViewWhenRelationToDelete.Any())
                        await _ViewWhenRelationRepository.DeleteListAsync(ViewWhenRelationToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "Field has been deleted successfully"
                        : "تم حذف الحقل بنجاح";

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
