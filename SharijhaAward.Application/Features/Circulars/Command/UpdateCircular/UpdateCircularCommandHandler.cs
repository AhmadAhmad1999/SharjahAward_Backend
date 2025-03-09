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

namespace SharijhaAward.Application.Features.Circulars.Command.UpdateCircular
{
    public class UpdateCircularCommandHandler
        : IRequestHandler<UpdateCircularCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CircularChairman> _CircularChairmanRepository;
        private readonly IAsyncRepository<Circular> _CircularRepository;
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CircularArbitrator> _CircularArbitratorRepository;
        private readonly IAsyncRepository<CircularCoordinator> _CircularCoordinatorRepository;
        private readonly IAsyncRepository<CircularAttachment> _CircularAttachmentRepository;
        private readonly IAsyncRepository<CircularUser> _CircularUserRepository;
        private readonly IAsyncRepository<CiruclarSubcommitteeOfficer> _CiruclarSubcommitteeOfficerRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IFileService _FileService;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;

        public UpdateCircularCommandHandler(IAsyncRepository<CircularChairman> _CircularChairmanRepository,
            IAsyncRepository<Circular> _CircularRepository,
            IAsyncRepository<Coordinator> _CoordinatorRepository, 
            IAsyncRepository<Arbitrator> _ArbitratorRepository, 
            IAsyncRepository<CircularArbitrator> _CircularArbitratorRepository,
            IAsyncRepository<CircularCoordinator> _CircularCoordinatorRepository,
            IAsyncRepository<CircularAttachment> _CircularAttachmentRepository,
            IAsyncRepository<CircularUser> _CircularUserRepository,
            IAsyncRepository<CiruclarSubcommitteeOfficer> _CiruclarSubcommitteeOfficerRepository,
            IAsyncRepository<UserRole> _UserRoleRepository,
            IFileService _FileService,
            IUserRepository _UserRepository,
            IJwtProvider _JwtProvider,
            IMapper _Mapper)
        {
            this._CircularChairmanRepository = _CircularChairmanRepository;
            this._CircularRepository = _CircularRepository;
            this._CoordinatorRepository = _CoordinatorRepository;
            this._ArbitratorRepository = _ArbitratorRepository;
            this._CircularAttachmentRepository = _CircularAttachmentRepository;
            this._CircularArbitratorRepository = _CircularArbitratorRepository;
            this._CircularCoordinatorRepository = _CircularCoordinatorRepository;
            this._FileService = _FileService;
            this._UserRepository = _UserRepository;
            this._JwtProvider = _JwtProvider;
            this._CircularUserRepository = _CircularUserRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._CiruclarSubcommitteeOfficerRepository = _CiruclarSubcommitteeOfficerRepository;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCircularCommand Request, CancellationToken cancellationToken)
        {
            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token!));

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            string ResponseMessage = string.Empty;

            Circular? CircularEntity = await _CircularRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);
            
            if(CircularEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Circular is not found"
                    : "التعميم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

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
                    List<int> CoordinatorsIds = (Request.AllCoordinators && (Request.CoordinatorId is not null ? Request.CoordinatorId.Any() : false))
                        ? await _CoordinatorRepository
                            .Select(x => x.Id)
                            .ToListAsync()
                        : (Request.CoordinatorId != null
                            ? Request.CoordinatorId
                            : new List<int>());

                    if (CoordinatorsIds.Any())
                    {
                        IReadOnlyList<CircularCoordinator> CircularCoordinatorEntitiesToDelete = await _CircularCoordinatorRepository
                            .Where(x => x.CircularId == Request.Id)
                            .ToListAsync();

                        if (CircularCoordinatorEntitiesToDelete.Any())
                            await _CircularCoordinatorRepository.DeleteListAsync(CircularCoordinatorEntitiesToDelete);

                        IEnumerable<CircularCoordinator> NewCircularCoordinatorEntities = CoordinatorsIds
                            .Select(CoordinatorId => new CircularCoordinator()
                            {
                                CoordinatorId = CoordinatorId,
                                CircularId = Request.Id
                            });

                        await _CircularCoordinatorRepository.AddRangeAsync(NewCircularCoordinatorEntities);
                    }

                    List<int> ArbitratorsIds = (Request.AllArbitrators && (Request.ArbitratorId is not null ? Request.ArbitratorId.Any() : false))
                        ? await _ArbitratorRepository
                            .Where(x => !x.isChairman)
                            .Select(x => x.Id)
                            .ToListAsync()
                        : (Request.ArbitratorId != null
                            ? Request.ArbitratorId
                            : new List<int>());

                    if (ArbitratorsIds.Any())
                    {
                        IReadOnlyList<CircularArbitrator> CircularArbitratorEntitiesToDelete = await _CircularArbitratorRepository
                            .Where(x => x.CircularId == Request.Id)
                            .ToListAsync();

                        if (CircularArbitratorEntitiesToDelete.Any())
                            await _CircularArbitratorRepository.DeleteListAsync(CircularArbitratorEntitiesToDelete);

                        IEnumerable<CircularArbitrator> NewCircularArbitratorEntities = ArbitratorsIds
                            .Select(ArbitratorId => new CircularArbitrator()
                            {
                                ArbitratorId = ArbitratorId,
                                CircularId = Request.Id
                            });

                        await _CircularArbitratorRepository.AddRangeAsync(NewCircularArbitratorEntities);
                    }

                    List<int> ChairmansIds = (Request.AllChairmans && (Request.ChairmanId is not null ? Request.ChairmanId.Any() : false))
                        ? await _ArbitratorRepository
                            .Where(x => x.isChairman)
                            .Select(x => x.Id)
                            .ToListAsync()
                        : (Request.ChairmanId != null
                            ? Request.ChairmanId
                            : new List<int>());

                    if (ChairmansIds.Any())
                    {
                        IReadOnlyList<CircularChairman> CircularChairmanEntitiesToDelete = await _CircularChairmanRepository
                            .Where(x => x.CircularId == Request.Id)
                            .ToListAsync();

                        if (CircularChairmanEntitiesToDelete.Any())
                            await _CircularChairmanRepository.DeleteListAsync(CircularChairmanEntitiesToDelete);

                        IEnumerable<CircularChairman> NewCircularChairmanEntities = ChairmansIds
                            .Select(ChairmanId => new CircularChairman()
                            {
                                ChairmanId = ChairmanId,
                                CircularId = Request.Id
                            });

                        await _CircularChairmanRepository.AddRangeAsync(NewCircularChairmanEntities);
                    }

                    List<int> SubcommitteeOfficerIds = 
                        (Request.AllSubcommitteeOfficers && 
                            (Request.SubcommitteeOfficerId is not null 
                                ? Request.SubcommitteeOfficerId.Any() : false))
                        ? await _ArbitratorRepository
                            .Where(x => x.isSubcommitteeOfficer)
                            .Select(x => x.Id)
                            .ToListAsync()
                        : (Request.SubcommitteeOfficerId != null
                            ? Request.SubcommitteeOfficerId
                            : new List<int>());

                    if (SubcommitteeOfficerIds.Any())
                    {
                        IReadOnlyList<CiruclarSubcommitteeOfficer> CiruclarSubcommitteeOfficerEntitiesToDelete = await _CiruclarSubcommitteeOfficerRepository
                            .Where(x => x.CircularId == Request.Id)
                            .ToListAsync();

                        if (CiruclarSubcommitteeOfficerEntitiesToDelete.Any())
                            await _CiruclarSubcommitteeOfficerRepository.DeleteListAsync(CiruclarSubcommitteeOfficerEntitiesToDelete);

                        IEnumerable<CiruclarSubcommitteeOfficer> NewCircularChairmanEntities = SubcommitteeOfficerIds
                            .Select(SubcommitteeOfficerId => new CiruclarSubcommitteeOfficer()
                            {
                                SubcommitteeOfficerId = SubcommitteeOfficerId,
                                CircularId = Request.Id
                            });

                        await _CiruclarSubcommitteeOfficerRepository.AddRangeAsync(NewCircularChairmanEntities);
                    }

                    if (Request.ChairmanOfCommitteesId != null
                        ? (Request.ChairmanOfCommitteesId.Any() ||
                            Request.AllChairmanOfCommittees)
                        : false)
                    {
                        List<CircularUser> ChairmanOfCommitteesIds = await _CircularUserRepository
                            .Where(x => x.UserRole!.Role!.EnglishName.ToLower() == "Chairman of Committees".ToLower() &&
                                x.UserRole!.Role!.ArabicName == "رئيس اللجان" &&
                                (Request.AllChairmanOfCommittees
                                    ? true
                                    : Request.ChairmanOfCommitteesId.Contains(x.UserRole!.UserId)) &&
                                x.CircularId == Request.Id)
                            .ToListAsync();

                        if (ChairmanOfCommitteesIds.Any())
                            await _CircularUserRepository.DeleteListAsync(ChairmanOfCommitteesIds);

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
                                CircularId = Request.Id,
                                UserRoleId = x,
                                IsRead = false
                            });

                        await _CircularUserRepository.AddRangeAsync(NewCircularUserEntities);
                    }

                    if (Request.ExpertId != null
                        ? (Request.ExpertId.Any() ||
                            Request.AllExperts)
                        : false)
                    {
                        List<CircularUser> ChairmanOfCommitteesIds = await _CircularUserRepository
                            .Where(x => x.UserRole!.Role!.EnglishName.ToLower() == "Expert".ToLower() &&
                                x.UserRole!.Role!.ArabicName == "خبير" &&
                                (Request.AllExperts
                                    ? true
                                    : Request.ExpertId.Contains(x.UserRole!.UserId)) &&
                                x.CircularId == Request.Id)
                            .ToListAsync();

                        if (ChairmanOfCommitteesIds.Any())
                            await _CircularUserRepository.DeleteListAsync(ChairmanOfCommitteesIds);

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
                                CircularId = Request.Id,
                                UserRoleId = x,
                                IsRead = false
                            });

                        await _CircularUserRepository.AddRangeAsync(NewCircularUserEntities);
                    }

                    if (Request.QualityId != null
                        ? (Request.QualityId.Any() ||
                            Request.AllQualities)
                        : false)
                    {
                        List<CircularUser> ChairmanOfCommitteesIds = await _CircularUserRepository
                            .Where(x => x.UserRole!.Role!.EnglishName.ToLower() == "Quality".ToLower() &&
                                x.UserRole!.Role!.ArabicName == "الجودة" &&
                                (Request.AllQualities
                                    ? true
                                    : Request.QualityId.Contains(x.UserRole!.UserId)) &&
                                x.CircularId == Request.Id)
                            .ToListAsync();

                        if (ChairmanOfCommitteesIds.Any())
                            await _CircularUserRepository.DeleteListAsync(ChairmanOfCommitteesIds);

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
                                CircularId = Request.Id,
                                UserRoleId = x,
                                IsRead = false
                            });

                        await _CircularUserRepository.AddRangeAsync(NewCircularUserEntities);
                    }

                    if (SubcommitteeOfficerIds.Any())
                    {
                        IReadOnlyList<CiruclarSubcommitteeOfficer> CiruclarSubcommitteeOfficerEntitiesToDelete = await _CiruclarSubcommitteeOfficerRepository
                            .Where(x => x.CircularId == Request.Id)
                            .ToListAsync();

                        if (CiruclarSubcommitteeOfficerEntitiesToDelete.Any())
                            await _CiruclarSubcommitteeOfficerRepository.DeleteListAsync(CiruclarSubcommitteeOfficerEntitiesToDelete);

                        IEnumerable<CiruclarSubcommitteeOfficer> NewCircularChairmanEntities = SubcommitteeOfficerIds
                            .Select(SubcommitteeOfficerId => new CiruclarSubcommitteeOfficer()
                            {
                                SubcommitteeOfficerId = SubcommitteeOfficerId,
                                CircularId = Request.Id
                            });

                        await _CiruclarSubcommitteeOfficerRepository.AddRangeAsync(NewCircularChairmanEntities);
                    }

                    _Mapper.Map(Request, CircularEntity, typeof(UpdateCircularCommand), typeof(Circular));

                    await _CircularRepository.UpdateAsync(CircularEntity);

                    List<CircularAttachment> CircularAttachmentEntities = await _CircularAttachmentRepository
                        .Where(x => Request.CircularAttachmentsToDelete.Contains(x.Id) ||
                            Request.CircularAttachmentsToUpdate.Select(y => y.Id).Contains(x.Id))
                        .ToListAsync();

                    if (CircularAttachmentEntities.Any())
                    {
                        if (Request.CircularAttachmentsToDelete.Any())
                        {
                            List<CircularAttachment> CircularAttachmentEntitiesToDelete = CircularAttachmentEntities
                                .Where(x => Request.CircularAttachmentsToDelete.Contains(x.Id))
                                .ToList();

                            if (CircularAttachmentEntitiesToDelete.Any())
                                await _CircularAttachmentRepository.DeleteListAsync(CircularAttachmentEntitiesToDelete);
                        }

                        if (Request.CircularAttachmentsToUpdate.Any())
                        {
                            List<CircularAttachment> CircularAttachmentEntitiesToUpdate = CircularAttachmentEntities
                                .Where(x => Request.CircularAttachmentsToUpdate.Select(y => y.Id).Contains(x.Id))
                                .ToList();

                            if (CircularAttachmentEntitiesToUpdate.Any())
                            {
                                foreach (CircularAttachment CircularAttachmentEntityToUpdate in CircularAttachmentEntitiesToUpdate)
                                {
                                    UpdateCircularFilesDto? NewCircularAttachmentEntity = Request.CircularAttachmentsToUpdate
                                        .FirstOrDefault(x => x.Id ==  CircularAttachmentEntityToUpdate.Id);

                                    if (NewCircularAttachmentEntity is not null)
                                    {
                                        _Mapper.Map(NewCircularAttachmentEntity, CircularAttachmentEntityToUpdate, typeof(UpdateCircularFilesDto), typeof(CircularAttachment));

                                        if (NewCircularAttachmentEntity.UpdateOnFile &&
                                            NewCircularAttachmentEntity.CircularFile != null)
                                        {
                                            Task<string> AttachementPath = _FileService.SaveFileAsync(NewCircularAttachmentEntity!.CircularFile!, SystemFileType.Circulars);

                                            CircularAttachmentEntityToUpdate.AttachementPath = AttachementPath.Result;
                                        }
                                    }
                                }

                                await _CircularAttachmentRepository.UpdateListAsync(CircularAttachmentEntitiesToUpdate);
                            }
                        }
                    }
                    
                    if (Request.CircularAttachmentsToAdd.Any())
                    {
                        List<CircularAttachment> NewCircularAttachmentEntities = Request.CircularAttachmentsToAdd!
                            .Select(x =>
                            {
                                Task<string> AttachementPath = _FileService.SaveFileAsync(x.CircularFile, SystemFileType.Circulars);

                                return new CircularAttachment()
                                {
                                    AttachementPath = AttachementPath.Result,
                                    CircularId = Request.Id,
                                    FileName = x.FileName
                                };
                            }).ToList();

                        await _CircularAttachmentRepository.AddRangeAsync(NewCircularAttachmentEntities);
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "Circular has been Updated"
                        : "تم تعديل التعميم بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200);
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
