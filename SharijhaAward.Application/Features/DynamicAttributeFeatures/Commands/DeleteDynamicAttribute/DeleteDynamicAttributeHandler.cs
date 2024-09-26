using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.DeleteDynamicAttribute
{
    public class DeleteDynamicAttributeHandler : IRequestHandler<DeleteDynamicAttributeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        public DeleteDynamicAttributeHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<Dependency> DependencyRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DependencyRepository = DependencyRepository;
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

            await _DynamicAttributeRepository.DeleteAsync(DynamicAttributeToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Field has been deleted successfully"
                : "تم حذف الحقل بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
