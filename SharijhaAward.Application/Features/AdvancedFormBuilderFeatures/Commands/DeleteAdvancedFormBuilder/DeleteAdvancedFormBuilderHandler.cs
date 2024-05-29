using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.DeleteAdvancedFormBuilder
{
    public class DeleteAdvancedFormBuilderHandler : IRequestHandler<DeleteAdvancedFormBuilderCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependency> _AdvancedFormBuilderDependencyRepository;
        public DeleteAdvancedFormBuilderHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderDependency> AdvancedFormBuilderDependencyRepository)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderDependencyRepository = AdvancedFormBuilderDependencyRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteAdvancedFormBuilderCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            IQueryable<AdvancedFormBuilderDependency> Dependencies = _AdvancedFormBuilderDependencyRepository
                .WhereThenInclude(x => x.AdvancedFormBuilderId == Request.Id, x => x.MainAdvancedFormBuilder!);

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
                            ? x.MainAdvancedFormBuilder!.EnglishLabel
                            : x.MainAdvancedFormBuilder!.ArabicLabel
                    }),
                    message = ResponseMessage,
                    pagination = null,
                    statusCode = 400,
                    success = false
                };
            }

            AdvancedFormBuilder? AdvancedFormBuilderToDelete = await _AdvancedFormBuilderRepository.GetByIdAsync(Request.Id);

            if (AdvancedFormBuilderToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _AdvancedFormBuilderRepository.DeleteAsync(AdvancedFormBuilderToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Field has been deleted successfully"
                : "تم حذف الحقل بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
