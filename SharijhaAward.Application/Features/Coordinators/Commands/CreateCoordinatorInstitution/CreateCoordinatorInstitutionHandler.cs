using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorInstitution
{
    public class CreateCoordinatorInstitutionHandler
        : IRequestHandler<CreateCoordinatorInstitutionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository;

        public CreateCoordinatorInstitutionHandler(IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository,
            IAsyncRepository<EduInstitutionCoordinator> EduInstitutionCoordinatorRepository)
        {
            _CoordinatorRepository = CoordinatorRepository;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateCoordinatorInstitutionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Coordinator? CheckIfCoordinatorIdIsExist = await _CoordinatorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CoordinatorId);

            if (CheckIfCoordinatorIdIsExist is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Coordinator is not found"
                    : "المنسق غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 204);
            }

            EducationalInstitution? CheckIfEducationalInstitutionIdIsExist = await _EducationalInstitutionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.EducationalInstitutionId);

            if (CheckIfEducationalInstitutionIdIsExist is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational institution is not found"
                    : "المؤسسة التعليمية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 204);
            }

            EduInstitutionCoordinator? CheckIfCoordinatorDoesConnectToEducationalInstution = await _EduInstitutionCoordinatorRepository
                .FirstOrDefaultAsync(x => x.CoordinatorId == Request.CoordinatorId &&
                    x.EducationalInstitutionId == Request.EducationalInstitutionId);

            if (CheckIfCoordinatorDoesConnectToEducationalInstution is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This coordinator is already connected to this educational institution"
                    : "هذا المنسق مرتبط مسبقاً بهذه المؤسسة التعليمية";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            EduInstitutionCoordinator NewEduInstitutionCoordinatorEntity = new EduInstitutionCoordinator()
            {
                isDeleted = false,
                DeletedAt = null,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                CoordinatorId = Request.CoordinatorId,
                EducationalInstitutionId = Request.EducationalInstitutionId
            };

            await _EduInstitutionCoordinatorRepository.AddAsync(NewEduInstitutionCoordinatorEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم ربط المنسق بمؤسسة تعليمية جديدة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
