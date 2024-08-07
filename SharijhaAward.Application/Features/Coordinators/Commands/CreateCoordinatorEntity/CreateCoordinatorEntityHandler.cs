using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorEntity
{
    public class CreateCoordinatorEntityHandler
        : IRequestHandler<CreateCoordinatorEntityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;

        public CreateCoordinatorEntityHandler(IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository)
        {
            _CoordinatorRepository = CoordinatorRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateCoordinatorEntityCommand Request, CancellationToken cancellationToken)
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

            EducationalEntity? CheckIfEducationalEntityIdIsExist = await _EducationalEntityRepository
                .FirstOrDefaultAsync(x => x.Id == Request.EducationalEntityId);

            if (CheckIfEducationalEntityIdIsExist is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational Entity is not found"
                    : "الجهة التعليمية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 204);
            }

            EduEntitiesCoordinator? CheckIfCoordinatorDoesConnectToEducationalEntity = await _EduEntitiesCoordinatorRepository
                .FirstOrDefaultAsync(x => x.CoordinatorId == Request.CoordinatorId &&
                    x.EducationalEntityId == Request.EducationalEntityId);

            if (CheckIfCoordinatorDoesConnectToEducationalEntity is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This coordinator is already connected to this educational Entity"
                    : "هذا المنسق مرتبط مسبقاً بهذه الجهة التعليمية";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            EduEntitiesCoordinator NewEduEntityCoordinatorEntity = new EduEntitiesCoordinator()
            {
                isDeleted = false,
                DeletedAt = null,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                CoordinatorId = Request.CoordinatorId,
                EducationalEntityId = Request.EducationalEntityId
            };

            await _EduEntitiesCoordinatorRepository.AddAsync(NewEduEntityCoordinatorEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم ربط المنسق بجهة تعليمية جديدة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
