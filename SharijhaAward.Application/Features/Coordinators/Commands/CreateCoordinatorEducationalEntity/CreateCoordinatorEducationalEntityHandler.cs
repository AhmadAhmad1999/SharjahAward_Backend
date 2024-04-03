using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorEducationalEntity
{
    public class CreateCoordinatorEducationalEntityHandler
        : IRequestHandler<CreateCoordinatorEducationalEntityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;

        public CreateCoordinatorEducationalEntityHandler(IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository)
        {
            _CoordinatorRepository = CoordinatorRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateCoordinatorEducationalEntityCommand Request, CancellationToken cancellationToken)
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
                    ? "Educational entity is not found"
                    : "الجهة التعليمية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 204);
            }

            EduEntitiesCoordinator? CheckIfCoordinatorDoesConnectToEducationalEntity = await _EduEntitiesCoordinatorRepository
                .FirstOrDefaultAsync(x => x.CoordinatorId == Request.CoordinatorId &&
                    x.EducationalEntityId == Request.EducationalEntityId);

            if (CheckIfCoordinatorDoesConnectToEducationalEntity is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This coordinator is already connected to this educational entity"
                    : "هذا المنسق مرتبط مسبقاً بهذه الجهة التعليمية";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            EduEntitiesCoordinator NewEduEntitiesCoordinatorEntity = new EduEntitiesCoordinator()
            {
                isDeleted = false,
                DeletedAt = null,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                CoordinatorId = Request.CoordinatorId,
                EducationalEntityId = Request.EducationalEntityId,
                RelatedDate = Request.RelatedDate
            };

            await _EduEntitiesCoordinatorRepository.AddAsync(NewEduEntitiesCoordinatorEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم ربط المنسق بجهة تعليمية جديدة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
