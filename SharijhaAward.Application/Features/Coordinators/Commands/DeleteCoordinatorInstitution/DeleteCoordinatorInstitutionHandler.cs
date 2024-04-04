using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinatorInstitution
{
    public class DeleteCoordinatorInstitutionHandler : IRequestHandler<DeleteCoordinatorInstitutionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository;
        public DeleteCoordinatorInstitutionHandler(IAsyncRepository<EduInstitutionCoordinator> EduInstitutionCoordinatorRepository)
        {
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteCoordinatorInstitutionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EduInstitutionCoordinator? EduInstitutionCoordinatorEntityToDelete = await _EduInstitutionCoordinatorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EduInstitutionCoordinatorEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Coordinator educational institution is not found"
                    : "المؤسسة التعليمية التي يتبع لها المنسق غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _EduInstitutionCoordinatorRepository.DeleteAsync(EduInstitutionCoordinatorEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Coordinator educational institution has been deleted successfully"
                : "تم حذف العلاقة بين المنسق والمؤسسة التعليمية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
