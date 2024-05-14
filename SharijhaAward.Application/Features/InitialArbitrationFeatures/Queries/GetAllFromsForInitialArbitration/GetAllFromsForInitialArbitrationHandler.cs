using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Features.Classes.Queries.GetClassById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.CommitteeModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetAllFromsForInitialArbitration
{
    public class GetAllFromsForInitialArbitrationHandler
        : IRequestHandler<GetAllFromsForInitialArbitrationQuery, BaseResponse<List<GetAllFromsForInitialArbitrationListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetAllFromsForInitialArbitrationHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<ComitteeArbitrator> ComitteeArbitratorRepository,
            IJwtProvider JWTProvider)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _UserRoleRepository = UserRoleRepository;
            _ComitteeArbitratorRepository = ComitteeArbitratorRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<List<GetAllFromsForInitialArbitrationListVM>>> Handle(GetAllFromsForInitialArbitrationQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            UserRole? CheckIfThisUserHasFullAccessOrArbitratorRole = await _UserRoleRepository
                .Include(x => x.Role!)
                .FirstOrDefaultAsync(x => x.UserId == UserId && 
                    (x.Role!.EnglishName.ToLower() == "arbitrator" || x.Role!.HaveFullAccess));

            if (CheckIfThisUserHasFullAccessOrArbitratorRole is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "You don't have access to this page"
                    : "ليس لديك صلاحية للولوج إلى هذه الصفحة";

                return new BaseResponse<List<GetAllFromsForInitialArbitrationListVM>>(ResponseMessage, false, 404);
            }

            if (CheckIfThisUserHasFullAccessOrArbitratorRole.Role!.HaveFullAccess)
            {

            }
            else
            {
                Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (ArbitratorEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator is not Found"
                        : "المحكم غير موجود";

                    return new BaseResponse<List<GetAllFromsForInitialArbitrationListVM>>(ResponseMessage, false, 404);
                }

                if (ArbitratorEntity.isChairman)
                {
                    List<int> ArbitratorsIdsInCommittee = await _ComitteeArbitratorRepository
                        .Include(x => x.Committee!)
                        .Where(x => x.Committee!.ChairmanId == ArbitratorEntity.Id)
                        .Select(x => x.ArbitratorId)
                        .Distinct()
                        .ToListAsync();

                    var xx = await _ArbitrationRepository
                        .Where(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId))
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .Select(x => new GetAllFromsForInitialArbitrationListVM()
                        {
                            Id = x.Id,
                            ArbitrationType = x.Type,
                            CategoryId = x.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName
                                : x.ProvidedForm!.Category!.ArabicName
                            //DateOfArbitration = x.dateof
                        }).ToListAsync();
                }
                else
                {

                }

            }

            throw new NotImplementedException();
        }
    }
}
