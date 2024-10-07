using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.HomePageFeatures.Queries.GetAllHomePageData
{
    public class GetAllHomePageDataHandler : IRequestHandler<GetAllHomePageDataQuery, BaseResponse<GetAllHomePageDataDto>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;
        private readonly IAsyncRepository<CoordinatorForm> _CoordinatorFormRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IMapper _Mapper;
        private readonly IJwtProvider _JwtProvider;
        public GetAllHomePageDataHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<Domain.Entities.IdentityModels.User> UserRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<EmailMessage> EmailMessageRepository,
            IAsyncRepository<CoordinatorForm> CoordinatorFormRepository,
            IAsyncRepository<Cycle> CycleRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IMapper Mapper,
            IJwtProvider JwtProvider)
        {
            _ProvidedFormRepository = ProvidedFormRepository;
            _UserRepository = UserRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _CoordinatorRepository = CoordinatorRepository;
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _EmailMessageRepository = EmailMessageRepository;
            _CoordinatorFormRepository = CoordinatorFormRepository;
            _CycleRepository = CycleRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _Mapper = Mapper;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<GetAllHomePageDataDto>> Handle(GetAllHomePageDataQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            Domain.Entities.IdentityModels.User? CheckUserIdIfExist = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            if (CheckUserIdIfExist is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not authorized"
                    : "المستخدم غير موجود";

                return new BaseResponse<GetAllHomePageDataDto>(ResponseMessage, false, 401);
            }

            List<Domain.Entities.ProvidedFormModel.ProvidedForm> AllProvidedFormsEntities = new List<Domain.Entities.ProvidedFormModel.ProvidedForm>();

            if (Request.CycleId is not null)
            {
                AllProvidedFormsEntities = await _ProvidedFormRepository
                    .Where(x => x.User.isValidAccount &&
                        x.Category.CycleId == Request.CycleId.Value)
                    .ToListAsync();
            }
            else
            {
                int ActiveCycleId = 0;

                Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                    .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                if (CheckIfThereIsActiveCycle is null)
                {
                    Cycle? LastActiveCycleEntity = await _CycleRepository
                        .OrderByDescending(x => x.CycleNumber, 0, -1)
                        .FirstOrDefaultAsync();

                    if (LastActiveCycleEntity is not null)
                    {
                        ActiveCycleId = LastActiveCycleEntity.Id;
                    }
                }
                else
                    ActiveCycleId = CheckIfThereIsActiveCycle.Id;

                AllProvidedFormsEntities = await _ProvidedFormRepository
                    .Where(x => x.User.isValidAccount &&
                        x.Category!.CycleId == ActiveCycleId)
                    .ToListAsync();
            }

            int SubscribersNumber = await _UserRepository
                .Where(x => x.SubscriberId != null && x.isValidAccount)
                .CountAsync();

            int FormsNumber = AllProvidedFormsEntities
                .Count();

            RoleType RoleType = RoleType.Arbitrator;

            if (FormsNumber > 0)
            {
                int ContactUsNumber = await _EmailMessageRepository
                    .Where(x => AllProvidedFormsEntities.Select(y => y.userId).Any(y => y == x.UserId) &&
                        x.Id == x.MessageId)
                    .CountAsync();

                int AllCompletedFormsAsNumber = AllProvidedFormsEntities
                    .Where(x => x.PercentCompletion == 100)
                    .Count();

                float AllCompletedFormsAsPercentage = (100 * AllCompletedFormsAsNumber) / FormsNumber;

                int AllUnCompletedFormsAsNumber = AllProvidedFormsEntities
                    .Where(x => x.PercentCompletion != 100)
                    .Count();

                float AllUnCompletedFormsAsPercentage = (100 * AllUnCompletedFormsAsNumber) / FormsNumber; ;

                int AllAcceptedFormsAsNumber = AllProvidedFormsEntities
                    .Where(x => x.IsAccepted != null ? x.IsAccepted.Value : false)
                    .Count();

                float AllAcceptedFormsAsPercentage = (100 * AllAcceptedFormsAsNumber) / FormsNumber;

                int AllUnAcceptedFormsAsNumber = AllProvidedFormsEntities
                    .Where(x => x.IsAccepted != null ? !x.IsAccepted.Value : false)
                    .Count();

                float AllUnAcceptedFormsAsPercentage = (100 * AllUnAcceptedFormsAsNumber) / FormsNumber; ;

                Arbitrator? CheckArbitratorEntity = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (CheckArbitratorEntity is not null)
                {
                    RoleType = RoleType.Arbitrator;

                    List<Arbitration> ArbitrationEntities = _ArbitrationRepository
                        .Where(x => x.ArbitratorId == UserId &&
                            AllProvidedFormsEntities.AsEnumerable()
                                .Select(y => y.userId).Contains(x.ProvidedForm!.userId))
                        .AsEnumerable()
                        .DistinctBy(x => x.ProvidedFormId)
                        .ToList();

                    int AssigedFormsNumber = ArbitrationEntities.Count();

                    int FormsInInitialArbitrationAsNumber = ArbitrationEntities
                        .Where(x => x.isAccepted == FormStatus.Accepted)
                        .Count();

                    if (AssigedFormsNumber > 0)
                    {
                        float FormsInInitialArbitrationAsPercentage = (100 * FormsInInitialArbitrationAsNumber) / AssigedFormsNumber;

                        int FormsInArbitrationAuditAsNumber = ArbitrationEntities
                            .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                                x.isAccepted == FormStatus.Accepted)
                            .Count();

                        float FormsInArbitrationAuditAsPercentage = (100 * FormsInArbitrationAuditAsNumber) / AssigedFormsNumber;

                        int FormsInFinalArbitrationAsNumber = await _FinalArbitrationRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                            .CountAsync();

                        float FormsInFinalArbitrationAsPercentage = (100 * FormsInFinalArbitrationAsNumber) / AssigedFormsNumber;

                        List<IGrouping<Category, Domain.Entities.ProvidedFormModel.ProvidedForm>> AllProvidedFormsEntitiesGroupedByCategoryId =
                            AllProvidedFormsEntities
                                .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Contains(x.Id))
                                .GroupBy(x => x.Category!)
                                .ToList();

                        List<FormsInCategories> FormsInCategories = AllProvidedFormsEntitiesGroupedByCategoryId
                            .Select(FormsInCategory => new FormsInCategories()
                            {
                                CategoryId = FormsInCategory.Key.Id,
                                CategoryName = Request.lang == "en"
                                    ? FormsInCategory.Key.EnglishName
                                    : FormsInCategory.Key.ArabicName,
                                FormsNumberInCategory = FormsInCategory.Count(),
                                FormsNumberInCategoryAsPercentage = (100 * FormsInCategory.Count()) / AssigedFormsNumber
                            }).ToList();

                        GetAllHomePageDataDto Response = new GetAllHomePageDataDto()
                        {
                            Role = RoleType,
                            SubscribersNumber = SubscribersNumber,
                            FormsNumber = FormsNumber,
                            ContactUsNumber = ContactUsNumber,
                            AllCompletedFormsAsNumber = AllCompletedFormsAsNumber,
                            AllCompletedFormsAsPercentage = AllCompletedFormsAsPercentage,
                            AllUnCompletedFormsAsNumber = AllUnCompletedFormsAsNumber,
                            AllUnCompletedFormsAsPercentage = AllUnCompletedFormsAsPercentage,
                            AllAcceptedFormsAsNumber = AllAcceptedFormsAsNumber,
                            AllAcceptedFormsAsPercentage = AllAcceptedFormsAsPercentage,
                            AllUnAcceptedFormsAsNumber = AllUnAcceptedFormsAsNumber,
                            AllUnAcceptedFormsAsPercentage = AllUnAcceptedFormsAsPercentage,
                            AssigedFormsNumber = AssigedFormsNumber,
                            FormsInInitialArbitrationAsNumber = FormsInInitialArbitrationAsNumber,
                            FormsInInitialArbitrationAsPercentage = FormsInInitialArbitrationAsPercentage,
                            FormsInArbitrationAuditAsNumber = FormsInArbitrationAuditAsNumber,
                            FormsInArbitrationAuditAsPercentage = FormsInArbitrationAuditAsPercentage,
                            FormsInFinalArbitrationAsNumber = FormsInFinalArbitrationAsNumber,
                            FormsInFinalArbitrationAsPercentage = FormsInFinalArbitrationAsPercentage,
                            FormsInCategories = FormsInCategories
                        };

                        return new BaseResponse<GetAllHomePageDataDto>(ResponseMessage, true, 200, Response);
                    }
                    else
                    {
                        GetAllHomePageDataDto Response = new GetAllHomePageDataDto()
                        {
                            Role = RoleType,
                            SubscribersNumber = SubscribersNumber,
                            FormsNumber = FormsNumber,
                            ContactUsNumber = ContactUsNumber,
                            AllCompletedFormsAsNumber = AllCompletedFormsAsNumber,
                            AllCompletedFormsAsPercentage = AllCompletedFormsAsPercentage,
                            AllUnCompletedFormsAsNumber = AllUnCompletedFormsAsNumber,
                            AllUnCompletedFormsAsPercentage = AllUnCompletedFormsAsPercentage,
                            AllAcceptedFormsAsNumber = AllAcceptedFormsAsNumber,
                            AllAcceptedFormsAsPercentage = AllAcceptedFormsAsPercentage,
                            AllUnAcceptedFormsAsNumber = AllUnAcceptedFormsAsNumber,
                            AllUnAcceptedFormsAsPercentage = AllUnAcceptedFormsAsPercentage,
                            AssigedFormsNumber = AssigedFormsNumber,
                            FormsInInitialArbitrationAsNumber = FormsInInitialArbitrationAsNumber,
                            FormsInInitialArbitrationAsPercentage = 0,
                            FormsInArbitrationAuditAsNumber = 0,
                            FormsInArbitrationAuditAsPercentage = 0,
                            FormsInFinalArbitrationAsNumber = 0,
                            FormsInFinalArbitrationAsPercentage = 0,
                            FormsInCategories = null
                        };

                        return new BaseResponse<GetAllHomePageDataDto>(ResponseMessage, true, 200, Response);
                    }
                }
                else
                {
                    Coordinator? CheckCoordinator = await _CoordinatorRepository
                        .FirstOrDefaultAsync(x => x.Id == UserId);

                    if (CheckCoordinator is not null)
                    {
                        RoleType = RoleType.Coordinator;

                        List<int> EduEntitiesIds = await _EduEntitiesCoordinatorRepository
                            .Where(x => x.CoordinatorId == UserId)
                            .Select(x => x.EducationalEntityId)
                            .ToListAsync();

                        List<DynamicAttributeValue> DynamicAttributeValueEtities = await _DynamicAttributeValueRepository
                            .Where(x => AllProvidedFormsEntities.Select(y => y.Id).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Educational Entity".ToLower())
                            .ToListAsync();

                        List<DynamicAttributeListValue> DynamicAttributeListValueEntities = await _DynamicAttributeListValueRepository
                            .Where(x => DynamicAttributeValueEtities.Select(y => int.Parse(y.Value))
                                .Contains(x.Id))
                            .ToListAsync();

                        var EducationalEntities = _EducationalEntityRepository
                            .AsEnumerable() // Switch to client-side evaluation
                            .Where(x => DynamicAttributeListValueEntities
                                .Any(y => y.EnglishValue.ToLower() == x.EnglishName.ToLower() &&
                                          y.ArabicValue.ToLower() == x.ArabicName.ToLower()))
                            .Select(x => new
                            {
                                DynamicAttributeListValueEntities
                                    .FirstOrDefault(y => y.EnglishValue.ToLower() == x.EnglishName.ToLower() &&
                                        y.ArabicValue.ToLower() == x.ArabicName.ToLower())!.Id,
                                EducationalEntityObject = x
                            }).ToList();

                        AllProvidedFormsEntities = AllProvidedFormsEntities
                            .Where(x => DynamicAttributeValueEtities.Select(y => y.RecordId).Contains(x.Id))
                            .ToList();
                        
                        var AllProvidedFormsEntitiesGrouped2 = (from DynamicAttributeValueEtity in DynamicAttributeValueEtities
                            join ProvidedFormsEntity in AllProvidedFormsEntities
                            on DynamicAttributeValueEtity.RecordId equals ProvidedFormsEntity.Id
                            join EducationalEntity in EducationalEntities
                            on int.Parse(DynamicAttributeValueEtity.Value) equals EducationalEntity.Id
                            select new
                            {
                                EducationalEntity,
                                ProvidedFormId = ProvidedFormsEntity.Id,
                                ProvidedFormsEntity.IsAccepted
                            }).ToList();

                        int AssigedFormsNumber = AllProvidedFormsEntitiesGrouped2
                            .Count(x => EduEntitiesIds.Contains(x.EducationalEntity!.EducationalEntityObject!.Id));

                        if (AssigedFormsNumber > 0)
                        {
                            var AllProvidedFormsEntitiesGrouped = AllProvidedFormsEntitiesGrouped2
                                .GroupBy(x => x.EducationalEntity!);

                            List<FormsInEducationalEntities> FormsInEducationalEntities = new List<FormsInEducationalEntities>();

                            foreach (var AllProvidedFormsEntityGrouped in AllProvidedFormsEntitiesGrouped)
                            {
                                int EducationalEntityId = AllProvidedFormsEntityGrouped.Key!.Id;

                                string EducationalEntityName = Request.lang == "en"
                                    ? AllProvidedFormsEntityGrouped.Key!.EducationalEntityObject!.EnglishName
                                    : AllProvidedFormsEntityGrouped.Key!.EducationalEntityObject!.ArabicName;

                                int FormsNumberInEducationalEntity = AllProvidedFormsEntityGrouped.Count();

                                if (FormsNumberInEducationalEntity > 0)
                                {
                                    float FormsNumberInEducationalEntityAsPercentage = (100 * FormsNumberInEducationalEntity) / AssigedFormsNumber;

                                    int AcceptedFormsNumberInEducationalEntityAsNumber = AllProvidedFormsEntityGrouped
                                        .Count(x => x.IsAccepted != null ? x.IsAccepted.Value : false);

                                    float AcceptedFormsNumberInEducationalEntityAsPercentage = (100 * AcceptedFormsNumberInEducationalEntityAsNumber) / FormsNumberInEducationalEntity;

                                    int RejectedFormsNumberInEducationalEntityAsNumber = AllProvidedFormsEntityGrouped
                                        .Count(x => x.IsAccepted != null ? !x.IsAccepted.Value : false);

                                    float RejectedFormsNumberInEducationalEntityAsPercentage = (100 * RejectedFormsNumberInEducationalEntityAsNumber) / FormsNumberInEducationalEntity;

                                    int NotAcceptedNorRejectedFormsNumberInEducationalEntityAsNumber = AllProvidedFormsEntityGrouped
                                        .Count(x => x.IsAccepted == null);

                                    float NotAcceptedNorRejectedFormsNumberInEducationalEntityAsPercentage = (100 * NotAcceptedNorRejectedFormsNumberInEducationalEntityAsNumber) / FormsNumberInEducationalEntity;

                                    FormsInEducationalEntities.Add(new FormsInEducationalEntities()
                                    {
                                        EducationalEntityId = EducationalEntityId,
                                        EducationalEntityName = EducationalEntityName,
                                        FormsNumberInEducationalEntity = FormsNumberInEducationalEntity,
                                        FormsNumberInEducationalEntityAsPercentage = FormsNumberInEducationalEntityAsPercentage,
                                        AcceptedFormsNumberInEducationalEntityAsNumber = AcceptedFormsNumberInEducationalEntityAsNumber,
                                        AcceptedFormsNumberInEducationalEntityAsPercentage = AcceptedFormsNumberInEducationalEntityAsPercentage,
                                        RejectedFormsNumberInEducationalEntityAsNumber = RejectedFormsNumberInEducationalEntityAsNumber,
                                        RejectedFormsNumberInEducationalEntityAsPercentage = RejectedFormsNumberInEducationalEntityAsPercentage,
                                        NotAcceptedNorRejectedFormsNumberInEducationalEntityAsNumber = NotAcceptedNorRejectedFormsNumberInEducationalEntityAsNumber,
                                        NotAcceptedNorRejectedFormsNumberInEducationalEntityAsPercentage = NotAcceptedNorRejectedFormsNumberInEducationalEntityAsPercentage
                                    });
                                }
                                else
                                {
                                    FormsInEducationalEntities.Add(new FormsInEducationalEntities()
                                    {
                                        EducationalEntityId = EducationalEntityId,
                                        EducationalEntityName = EducationalEntityName,
                                        FormsNumberInEducationalEntity = FormsNumberInEducationalEntity,
                                        FormsNumberInEducationalEntityAsPercentage = 0,
                                        AcceptedFormsNumberInEducationalEntityAsNumber = 0,
                                        AcceptedFormsNumberInEducationalEntityAsPercentage = 0,
                                        RejectedFormsNumberInEducationalEntityAsNumber = 0,
                                        RejectedFormsNumberInEducationalEntityAsPercentage = 0,
                                        NotAcceptedNorRejectedFormsNumberInEducationalEntityAsNumber = 0,
                                        NotAcceptedNorRejectedFormsNumberInEducationalEntityAsPercentage = 0
                                    });
                                }
                            }

                            GetAllHomePageDataDto Response = new GetAllHomePageDataDto()
                            {
                                Role = RoleType,
                                SubscribersNumber = SubscribersNumber,
                                FormsNumber = FormsNumber,
                                ContactUsNumber = ContactUsNumber,
                                AllCompletedFormsAsNumber = AllCompletedFormsAsNumber,
                                AllCompletedFormsAsPercentage = AllCompletedFormsAsPercentage,
                                AllUnCompletedFormsAsNumber = AllUnCompletedFormsAsNumber,
                                AllUnCompletedFormsAsPercentage = AllUnCompletedFormsAsPercentage,
                                AllAcceptedFormsAsNumber = AllAcceptedFormsAsNumber,
                                AllAcceptedFormsAsPercentage = AllAcceptedFormsAsPercentage,
                                AllUnAcceptedFormsAsNumber = AllUnAcceptedFormsAsNumber,
                                AllUnAcceptedFormsAsPercentage = AllUnAcceptedFormsAsPercentage,
                                AssigedFormsNumber = AssigedFormsNumber,
                                FormsInInitialArbitrationAsNumber = 0,
                                FormsInInitialArbitrationAsPercentage = 0,
                                FormsInArbitrationAuditAsNumber = 0,
                                FormsInArbitrationAuditAsPercentage = 0,
                                FormsInFinalArbitrationAsNumber = 0,
                                FormsInFinalArbitrationAsPercentage = 0,
                                FormsInCategories = null,
                                FormsInEducationalEntities = FormsInEducationalEntities
                            };

                            return new BaseResponse<GetAllHomePageDataDto>(ResponseMessage, true, 200, Response);
                        }
                        else
                        {
                            GetAllHomePageDataDto Response = new GetAllHomePageDataDto()
                            {
                                Role = RoleType,
                                SubscribersNumber = SubscribersNumber,
                                FormsNumber = FormsNumber,
                                ContactUsNumber = ContactUsNumber,
                                AllCompletedFormsAsNumber = AllCompletedFormsAsNumber,
                                AllCompletedFormsAsPercentage = AllCompletedFormsAsPercentage,
                                AllUnCompletedFormsAsNumber = AllUnCompletedFormsAsNumber,
                                AllUnCompletedFormsAsPercentage = AllUnCompletedFormsAsPercentage,
                                AllAcceptedFormsAsNumber = AllAcceptedFormsAsNumber,
                                AllAcceptedFormsAsPercentage = AllAcceptedFormsAsPercentage,
                                AllUnAcceptedFormsAsNumber = AllUnAcceptedFormsAsNumber,
                                AllUnAcceptedFormsAsPercentage = AllUnAcceptedFormsAsPercentage,
                                AssigedFormsNumber = AssigedFormsNumber,
                                FormsInInitialArbitrationAsNumber = 0,
                                FormsInInitialArbitrationAsPercentage = 0,
                                FormsInArbitrationAuditAsNumber = 0,
                                FormsInArbitrationAuditAsPercentage = 0,
                                FormsInFinalArbitrationAsNumber = 0,
                                FormsInFinalArbitrationAsPercentage = 0,
                                FormsInCategories = null,
                                FormsInEducationalEntities = null
                            };

                            return new BaseResponse<GetAllHomePageDataDto>(ResponseMessage, true, 200, Response);
                        }
                    }
                    else
                    {
                        RoleType = RoleType.Other;

                        GetAllHomePageDataDto Response = new GetAllHomePageDataDto()
                        {
                            Role = RoleType,
                            SubscribersNumber = SubscribersNumber,
                            FormsNumber = FormsNumber,
                            ContactUsNumber = ContactUsNumber,
                            AllCompletedFormsAsNumber = AllCompletedFormsAsNumber,
                            AllCompletedFormsAsPercentage = AllCompletedFormsAsPercentage,
                            AllUnCompletedFormsAsNumber = AllUnCompletedFormsAsNumber,
                            AllUnCompletedFormsAsPercentage = AllUnCompletedFormsAsPercentage,
                            AllAcceptedFormsAsNumber = AllAcceptedFormsAsNumber,
                            AllAcceptedFormsAsPercentage = AllAcceptedFormsAsPercentage,
                            AllUnAcceptedFormsAsNumber = AllUnAcceptedFormsAsNumber,
                            AllUnAcceptedFormsAsPercentage = AllUnAcceptedFormsAsPercentage,
                            AssigedFormsNumber = 0,
                            FormsInInitialArbitrationAsNumber = 0,
                            FormsInInitialArbitrationAsPercentage = 0,
                            FormsInArbitrationAuditAsNumber = 0,
                            FormsInArbitrationAuditAsPercentage = 0,
                            FormsInFinalArbitrationAsNumber = 0,
                            FormsInFinalArbitrationAsPercentage = 0,
                            FormsInCategories = null,
                            FormsInEducationalEntities = null
                        };

                        return new BaseResponse<GetAllHomePageDataDto>(ResponseMessage, true, 200, Response);
                    }
                }
            }
            else
            {
                Arbitrator? CheckArbitratorEntity = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (CheckArbitratorEntity is not null)
                    RoleType = RoleType.Arbitrator;

                else
                {
                    Coordinator? CheckCoordinator = await _CoordinatorRepository
                        .FirstOrDefaultAsync(x => x.Id == UserId);

                    if (CheckCoordinator is not null)
                        RoleType = RoleType.Coordinator;

                    else
                        RoleType = RoleType.Other;
                }

                GetAllHomePageDataDto Response = new GetAllHomePageDataDto()
                {
                    Role = RoleType,
                    SubscribersNumber = SubscribersNumber,
                    FormsNumber = FormsNumber,
                    ContactUsNumber = 0,
                    AllCompletedFormsAsNumber = 0,
                    AllCompletedFormsAsPercentage = 0,
                    AllUnCompletedFormsAsNumber = 0,
                    AllUnCompletedFormsAsPercentage = 0,
                    AllAcceptedFormsAsNumber = 0,
                    AllAcceptedFormsAsPercentage = 0,
                    AllUnAcceptedFormsAsNumber = 0,
                    AllUnAcceptedFormsAsPercentage = 0,
                    AssigedFormsNumber = 0,
                    FormsInInitialArbitrationAsNumber = 0,
                    FormsInInitialArbitrationAsPercentage = 0,
                    FormsInArbitrationAuditAsNumber = 0,
                    FormsInArbitrationAuditAsPercentage = 0,
                    FormsInFinalArbitrationAsNumber = 0,
                    FormsInFinalArbitrationAsPercentage = 0,
                    FormsInCategories = null
                };

                return new BaseResponse<GetAllHomePageDataDto>(ResponseMessage, true, 200, Response);
            }
        }
    }
}
