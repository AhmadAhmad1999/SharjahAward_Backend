using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinatorEntity
{
    public class DeleteCoordinatorEntityHandler : IRequestHandler<DeleteCoordinatorEntityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntityCoordinatorRepository;
        public DeleteCoordinatorEntityHandler(IAsyncRepository<EduEntitiesCoordinator> EduEntityCoordinatorRepository)
        {
            _EduEntityCoordinatorRepository = EduEntityCoordinatorRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteCoordinatorEntityCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EduEntitiesCoordinator? EduEntityCoordinatorEntityToDelete = await _EduEntityCoordinatorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EduEntityCoordinatorEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Coordinator educational Entity is not found"
                    : "الجهة التعليمية التي يتبع لها المنسق غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _EduEntityCoordinatorRepository.DeleteAsync(EduEntityCoordinatorEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Coordinator Entity institution has been deleted successfully"
                : "تم حذف العلاقة بين المنسق الجهة التعليمية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
