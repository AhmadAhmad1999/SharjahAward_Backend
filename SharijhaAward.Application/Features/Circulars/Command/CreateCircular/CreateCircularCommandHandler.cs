using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CircularModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.Circulars.Command.CreateCircular
{
    public class CreateCircularCommandHandler
        : IRequestHandler<CreateCircularCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Circular> _CircularRepository;
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CircularAttachment> _CircularAttachmentRepository;
        private readonly IAsyncRepository<CircularArbitrator> _CircularArbitratorRepository;
        private readonly IAsyncRepository<CircularCoordinator> _CircularCoordinatorRepository;
        private readonly IAsyncRepository<CircularChairman> _CircularChairmanRepository;
        private readonly IAsyncRepository<CircularUser> _CircularUserRepository;
        private readonly IAsyncRepository<CiruclarSubcommitteeOfficer> _CiruclarSubcommitteeOfficerRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IFileService _FileService;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;

        public CreateCircularCommandHandler(IUserRepository _UserRepository,
            IJwtProvider _JwtProvider, 
            IAsyncRepository<CircularChairman> _CircularChairmanRepository, 
            IAsyncRepository<Circular> _CircularRepository, 
            IAsyncRepository<Coordinator> _CoordinatorRepository, 
            IAsyncRepository<Arbitrator> _ArbitratorRepository, 
            IAsyncRepository<CircularAttachment> _CircularAttachmentRepository, 
            IAsyncRepository<CircularArbitrator> _CircularArbitratorRepository, 
            IAsyncRepository<CircularCoordinator> _CircularCoordinatorRepository,
            IAsyncRepository<CircularUser> _CircularUserRepository,
            IAsyncRepository<CiruclarSubcommitteeOfficer> _CiruclarSubcommitteeOfficerRepository,
            IAsyncRepository<UserRole> _UserRoleRepository,
            IFileService _FileService, 
            IMapper _Mapper)
        {
            this._CircularRepository = _CircularRepository;
            this._CoordinatorRepository = _CoordinatorRepository;
            this._ArbitratorRepository = _ArbitratorRepository;
            this._CircularAttachmentRepository = _CircularAttachmentRepository;
            this._CircularArbitratorRepository = _CircularArbitratorRepository;
            this._CircularCoordinatorRepository = _CircularCoordinatorRepository;
            this._CircularChairmanRepository = _CircularChairmanRepository;
            this._CircularUserRepository = _CircularUserRepository;
            this._UserRepository = _UserRepository;
            this._FileService = _FileService;
            this._CiruclarSubcommitteeOfficerRepository = _CiruclarSubcommitteeOfficerRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._JwtProvider = _JwtProvider;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateCircularCommand Request, CancellationToken cancellationToken)
        {
            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token!));

                    Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                        .FirstOrDefaultAsync(x => x.Id == UserId);

                    var Circular = _Mapper.Map<Circular>(Request);

                    Circular? Response = await _CircularRepository.AddAsync(Circular, UserEntity!.ArabicName);

                    List<int>? CoordinatorEntitiesIds = Request.AllCoordinators
                        ? await _CoordinatorRepository.Select(x => x.Id).ToListAsync()
                        : Request.CoordinatorId;

                    if (CoordinatorEntitiesIds != null 
                        ? CoordinatorEntitiesIds.Any()
                        : false)
                    {
                        List<CircularCoordinator> NewCircularCoordinatorEntities = CoordinatorEntitiesIds
                            .Select(x => new CircularCoordinator()
                            {
                                CoordinatorId = x,
                                CircularId = Response.Id,
                                IsRead = false
                            }).ToList();

                        await _CircularCoordinatorRepository.AddRangeAsync(NewCircularCoordinatorEntities);
                    }

                    List<int>? ArbitratorEntitiesIds = Request.AllArbitrators
                        ? await _ArbitratorRepository.Select(x => x.Id).ToListAsync()
                        : Request.ArbitratorId;

                    if (ArbitratorEntitiesIds != null
                        ? ArbitratorEntitiesIds.Any()
                        : false)
                    {
                        List<CircularArbitrator> NewCircularArbitratorEntities = ArbitratorEntitiesIds
                            .Select(x => new CircularArbitrator()
                            {
                                ArbitratorId = x,
                                CircularId = Response.Id,
                                IsRead = false
                            }).ToList();

                        await _CircularArbitratorRepository.AddRangeAsync(NewCircularArbitratorEntities);
                    }

                    List<int>? ChairmanEntitiesIds = Request.AllChairmans
                        ? await _ArbitratorRepository
                            .Where(x => x.isChairman)
                            .Select(x => x.Id)
                            .ToListAsync()
                        : Request.ChairmanId;

                    if (ChairmanEntitiesIds != null
                        ? ChairmanEntitiesIds.Any()
                        : false)
                    {
                        List<CircularChairman> NewCircularChairmanEntities = ChairmanEntitiesIds
                            .Select(x => new CircularChairman()
                            {
                                ChairmanId = x,
                                CircularId = Response.Id,
                                IsRead = false
                            }).ToList();

                        await _CircularChairmanRepository.AddRangeAsync(NewCircularChairmanEntities);
                    }

                    if (Request.CircularFiles != null
                        ? Request.CircularFiles.Any()
                        : false)
                    {
                        List<CircularAttachment> NewCircularAttachmentEntities = Request.CircularFiles!
                            .Select(x =>
                            {
                                Task<string> AttachementPath = _FileService.SaveFileAsync(x.CircularFile, SystemFileType.Circulars);

                                return new CircularAttachment()
                                {
                                    AttachementPath = AttachementPath.Result,
                                    CircularId = Response.Id,
                                    FileName = x.FileName
                                };
                            }).ToList();

                        await _CircularAttachmentRepository.AddRangeAsync(NewCircularAttachmentEntities);
                    }

                    if ((Request.SubcommitteeOfficerId != null
                        ? Request.SubcommitteeOfficerId.Any()
                        : false) || Request.AllSubcommitteeOfficers)
                    {
                        List<int>? SubcommitteeOfficerEntitiesIds = Request.AllChairmans
                            ? await _ArbitratorRepository
                                .Where(x => x.isSubcommitteeOfficer)
                                .Select(x => x.Id)
                                .ToListAsync()
                            : Request.SubcommitteeOfficerId;

                        List<CiruclarSubcommitteeOfficer> NewCCiruclarSubcommitteeOfficerEntities = SubcommitteeOfficerEntitiesIds
                            .Select(x => new CiruclarSubcommitteeOfficer()
                            {
                                SubcommitteeOfficerId = x,
                                CircularId = Response.Id,
                                IsRead = false
                            }).ToList();

                        await _CiruclarSubcommitteeOfficerRepository.AddRangeAsync(NewCCiruclarSubcommitteeOfficerEntities);
                    }
                    if ((Request.ChairmanOfCommitteesId != null
                        ? Request.ChairmanOfCommitteesId.Any()
                        : false) || Request.AllChairmanOfCommittees)
                    {
                        List<int> UserRoleIds = await _UserRoleRepository
                            .Where(x => x.Role!.EnglishName.ToLower() == "Chairman of Committees".ToLower() &&
                                x.Role!.ArabicName == "رئيس اللجان" &&
                                (Request.AllChairmanOfCommittees 
                                    ? true
                                    : Request.ChairmanOfCommitteesId.Contains(x.Id)))
                            .Select(x => x.Id)
                            .ToListAsync();

                        IEnumerable<CircularUser> NewCircularUserEntities = UserRoleIds
                            .Select(x => new CircularUser()
                            {
                                CircularId = Response.Id,
                                UserRoleId = x,
                                IsRead = false
                            });

                        await _CircularUserRepository.AddRangeAsync(NewCircularUserEntities);
                    }
                    if ((Request.ExpertId != null
                        ? Request.ExpertId.Any()
                        : false) || Request.AllExperts)
                    {
                        List<int> UserRoleIds = await _UserRoleRepository
                            .Where(x => x.Role!.EnglishName.ToLower() == "Expert".ToLower() &&
                                x.Role!.ArabicName == "خبير" &&
                                (Request.AllExperts
                                    ? true
                                    : Request.ExpertId.Contains(x.Id)))
                            .Select(x => x.Id)
                            .ToListAsync();

                        IEnumerable<CircularUser> NewCircularUserEntities = UserRoleIds
                            .Select(x => new CircularUser()
                            {
                                CircularId = Response.Id,
                                UserRoleId = x,
                                IsRead = false
                            });

                        await _CircularUserRepository.AddRangeAsync(NewCircularUserEntities);
                    }
                    if ((Request.QualityId != null
                        ? Request.QualityId.Any()
                        : false) || Request.AllQualities)
                    {
                        List<int> UserRoleIds = await _UserRoleRepository
                            .Where(x => x.Role!.EnglishName.ToLower() == "Quality".ToLower() &&
                                x.Role!.ArabicName == "الجودة" &&
                                (Request.AllQualities
                                    ? true
                                    : Request.QualityId.Contains(x.Id)))
                            .Select(x => x.Id)
                            .ToListAsync();

                        IEnumerable<CircularUser> NewCircularUserEntities = UserRoleIds
                            .Select(x => new CircularUser()
                            {
                                CircularId = Response.Id,
                                UserRoleId = x,
                                IsRead = false
                            });

                        await _CircularUserRepository.AddRangeAsync(NewCircularUserEntities);
                    }

                    string ResponseMessage = Request.lang == "en"
                        ? "Circular has benn created"
                        : "تم إضافة التعميم";

                    Transaction.Complete();

                    return new BaseResponse<int>(ResponseMessage, true, 200, Response.Id);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
