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

            List<Domain.Entities.ProvidedFormModel.ProvidedForm> AllProvidedFormsEntities = await _ProvidedFormRepository
                .Include(x => x.User!)
                .Include(x => x.Category!)
                .Include(x => x.Category!.Cycle)
                .Where(x => x.User.isValidAccount &&
                    x.Category.Cycle.Status == Domain.Constants.Common.Status.Active)
                .ToListAsync();

            int SubscribersNumber = AllProvidedFormsEntities
                .DistinctBy(x => x.userId)
                .Count();

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

                float AllUnCompletedFormsAsPercentage = 100 - AllCompletedFormsAsPercentage;

                int AllAcceptedFormsAsNumber = AllProvidedFormsEntities
                    .Where(x => x.IsAccepted != null ? x.IsAccepted.Value : false)
                    .Count();

                float AllAcceptedFormsAsPercentage = (100 * AllAcceptedFormsAsNumber) / FormsNumber;

                int AllUnAcceptedFormsAsNumber = AllProvidedFormsEntities
                    .Where(x => x.IsAccepted != null ? !x.IsAccepted.Value : false)
                    .Count();

                float AllUnAcceptedFormsAsPercentage = 100 - AllAcceptedFormsAsPercentage;

                Arbitrator? CheckArbitratorEntity = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (CheckArbitratorEntity is not null)
                {
                    RoleType = RoleType.Arbitrator;

                    List<Arbitration> ArbitratorEntities = await _ArbitrationRepository
                        .Include(x => x.ProvidedForm!)
                        .Where(x => x.ArbitratorId == UserId &&
                            AllProvidedFormsEntities.Select(y => y.userId).Contains(x.ProvidedForm!.userId))
                        .DistinctBy(x => x.ProvidedFormId)
                        .ToListAsync();

                    int AssigedFormsNumber = ArbitratorEntities.Count();

                    int FormsInInitialArbitrationAsNumber = ArbitratorEntities
                        .Where(x => x.isAccepted == FormStatus.Accepted &&
                            x.isAcceptedFromChairman != FormStatus.Accepted)
                        .Count();

                    if (AssigedFormsNumber > 0)
                    {
                        float FormsInInitialArbitrationAsPercentage = (100 * FormsInInitialArbitrationAsNumber) / AssigedFormsNumber;

                        int FormsInArbitrationAuditAsNumber = ArbitratorEntities
                            .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                                x.isAccepted == FormStatus.Accepted)
                            .Count();

                        float FormsInArbitrationAuditAsPercentage = (100 * FormsInArbitrationAuditAsNumber) / AssigedFormsNumber;

                        int FormsInFinalArbitrationAsNumber = await _FinalArbitrationRepository
                            .Where(x => ArbitratorEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                            .CountAsync();

                        float FormsInFinalArbitrationAsPercentage = (100 * FormsInFinalArbitrationAsNumber) / AssigedFormsNumber;

                        List<IGrouping<Category, Domain.Entities.ProvidedFormModel.ProvidedForm>> AllProvidedFormsEntitiesGroupedByCategoryId =
                            AllProvidedFormsEntities.GroupBy(x => x.Category!).ToList();

                        List<FormsInCategories> FormsInCategories = AllProvidedFormsEntitiesGroupedByCategoryId
                            .Select(FormsInCategory => new FormsInCategories()
                            {
                                CategoryId = FormsInCategory.Key.Id,
                                CategoryName = Request.lang == "em"
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

                        int AssigedFormsNumber = await _CoordinatorFormRepository
                            .Where(x => x.CoordinatorId == UserId)
                            .CountAsync();

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
                            FormsInCategories = null
                        };

                        return new BaseResponse<GetAllHomePageDataDto>(ResponseMessage, true, 200, Response);
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
                            FormsInCategories = null
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
