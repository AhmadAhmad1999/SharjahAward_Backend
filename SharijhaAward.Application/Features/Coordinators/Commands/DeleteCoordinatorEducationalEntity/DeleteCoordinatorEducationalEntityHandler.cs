using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinatorEducationalEntity
{
    public class DeleteCoordinatorEducationalEntityHandler : IRequestHandler<DeleteCoordinatorEducationalEntityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        public DeleteCoordinatorEducationalEntityHandler(IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository)
        {
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCoordinatorEducationalEntityCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EduEntitiesCoordinator? EduEntitiesCoordinatorToDelete = await _EduEntitiesCoordinatorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EduEntitiesCoordinatorToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Coordinator educational entity is not found"
                    : "الجهة التعليمية التي يتبع لها المنسق غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _EduEntitiesCoordinatorRepository.DeleteAsync(EduEntitiesCoordinatorToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Coordinator educational entity has been deleted successfully"
                : "تم حذف العلاقة بين المنسق والجهة التعليمية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
