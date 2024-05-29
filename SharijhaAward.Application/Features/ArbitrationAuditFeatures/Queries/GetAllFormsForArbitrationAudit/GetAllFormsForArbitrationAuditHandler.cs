using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit
{
    public class GetAllFormsForArbitrationAuditHandler
        : IRequestHandler<GetAllFormsForArbitrationAuditQuery, BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetAllFormsForArbitrationAuditHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IJwtProvider JWTProvider)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>> Handle(GetAllFormsForArbitrationAuditQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            Arbitrator? CheckIfUserIsNormalArbitrator = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            List<IGrouping<int, Arbitration>> GroupOfArbitrationEntities = new List<IGrouping<int, Arbitration>>();
            if (CheckIfUserIsNormalArbitrator is not null
                ? !CheckIfUserIsNormalArbitrator.isChairman
                : false)
            {
                GroupOfArbitrationEntities = await _ArbitrationRepository
                    .Where(x => x.ArbitratorId == UserId)
                    .Include(x => x.ProvidedForm!)
                    .Include(x => x.ProvidedForm!.Category!)
                    .GroupBy(x => x.ProvidedFormId)
                    .ToListAsync();
            }
            else
            {
                GroupOfArbitrationEntities = await _ArbitrationRepository
                    .Include(x => x.ProvidedForm!)
                    .Include(x => x.ProvidedForm!.Category!)
                    .GroupBy(x => x.ProvidedFormId)
                    .ToListAsync();
            }

            List<int> ArbitrationIds = GroupOfArbitrationEntities
                .SelectMany(group => group.Select(arbitration => arbitration.Id))
                .ToList();

            List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                .Where(x => ArbitrationIds.Contains(x.ArbitrationId))
                .ToListAsync();
            
            int MarginOfDifferenceBetweenArbitrators = await _ArbitrationRepository
                .Include(x => x.ProvidedForm!)
                .Include(x => x.ProvidedForm!.Category!.Cycle!)
                .Select(x => x.ProvidedForm!.Category!.Cycle!.MarginOfDifferenceBetweenArbitrators)
                .FirstOrDefaultAsync();

            var Names = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Where(x => GroupOfArbitrationEntities.Select(y => y.Key).Any(y => y == x.RecordId) &&
                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                .Select(x => new
                {
                    x.RecordId,
                    x.Value
                }).ToListAsync();

            List<GetAllFormsForArbitrationAuditListVM> Response = new List<GetAllFormsForArbitrationAuditListVM>();

            foreach (IGrouping<int, Arbitration> GroupOfArbitrationEntity in GroupOfArbitrationEntities)
            {
                if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores != null)
                {
                    if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores.Value)
                    {
                        foreach (Arbitration ArbitrationEntity in GroupOfArbitrationEntity)
                        {
                            bool BreakOuterLoop = false;

                            foreach (Arbitration ArbitrationEntity2 in GroupOfArbitrationEntity)
                            {
                                if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                {
                                    GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                                    {
                                        FormId = ArbitrationEntity.ProvidedFormId,
                                        Name = Names.FirstOrDefault(x => x.RecordId == ArbitrationEntity.ProvidedFormId)!.Value,
                                        CategoryId = ArbitrationEntity.ProvidedForm!.categoryId,
                                        CategoryName = Request.lang == "en"
                                            ? ArbitrationEntity.ProvidedForm!.Category.EnglishName
                                            : ArbitrationEntity.ProvidedForm!.Category.ArabicName,
                                        ItExceededTheMarginOfDifferenceInArbitrationScores = true,
                                        FullScore = 0
                                    };

                                    Response.Add(GetAllFormsForArbitrationAuditListVM);

                                    BreakOuterLoop = true;
                                    break;
                                }
                            }

                            if (BreakOuterLoop)
                                break;
                        }
                    }
                    else
                    {
                        bool BreakOuterLoop = false;

                        GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                        {
                            FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                            Name = Names.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)!.Value,
                            CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                                : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName,
                            ItExceededTheMarginOfDifferenceInArbitrationScores = false
                        };

                        foreach (Arbitration ArbitrationEntity in GroupOfArbitrationEntity)
                        {
                            foreach (Arbitration ArbitrationEntity2 in GroupOfArbitrationEntity)
                            {
                                if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                {
                                    BreakOuterLoop = true;
                                    break;
                                }
                            }
                        }

                        if (!BreakOuterLoop)
                        {
                            List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntities
                                .Where(x => ArbitrationIds.Contains(x.ArbitrationId))
                                .ToList();

                            GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                .Sum(x => x.ArbitrationScore) / ArbitrationIds.Count();

                            GetAllFormsForArbitrationAuditListVM.FullScore = GetAllFormsForArbitrationAuditListVM.Average;

                            foreach (Arbitration ArbitrationEntity in GroupOfArbitrationEntity)
                            {
                                ArbitrationEntity.FullScore = GetAllFormsForArbitrationAuditListVM.Average;
                            }

                            await _ArbitrationRepository.UpdateListAsync(GroupOfArbitrationEntity.ToList());

                            Response.Add(GetAllFormsForArbitrationAuditListVM);
                        }
                    }
                }
                else
                {
                    bool BreakOuterLoop = false;

                    GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                    {
                        FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                        Name = Names.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)!.Value,
                        CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                            : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName
                    };

                    foreach (Arbitration ArbitrationEntity in GroupOfArbitrationEntity)
                    {
                        foreach (Arbitration ArbitrationEntity2 in GroupOfArbitrationEntity)
                        {
                            if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                            {
                                GetAllFormsForArbitrationAuditListVM.ItExceededTheMarginOfDifferenceInArbitrationScores = true;

                                Response.Add(GetAllFormsForArbitrationAuditListVM);

                                BreakOuterLoop = true;
                                break;
                            }
                        }

                        if (BreakOuterLoop)
                            break;
                    }

                    if (!BreakOuterLoop)
                    {
                        List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntities
                            .Where(x => ArbitrationIds.Contains(x.ArbitrationId))
                            .ToList();

                        GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                            .Sum(x => x.ArbitrationScore) / ArbitrationIds.Count();

                        GetAllFormsForArbitrationAuditListVM.FullScore = GetAllFormsForArbitrationAuditListVM.Average;

                        foreach (Arbitration ArbitrationEntity in GroupOfArbitrationEntity)
                        {
                            ArbitrationEntity.FullScore = GetAllFormsForArbitrationAuditListVM.Average;
                        }

                        await _ArbitrationRepository.UpdateListAsync(GroupOfArbitrationEntity.ToList());

                        GetAllFormsForArbitrationAuditListVM.ItExceededTheMarginOfDifferenceInArbitrationScores = false;

                        Response.Add(GetAllFormsForArbitrationAuditListVM);
                    }
                }
            }

            int TotalCount = Response.Count();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            if (Request.page != 0 && Request.pageSize != -1)
            {
                Response = Response.Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .ToList();
            }

            return new BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
        }
    }
}
