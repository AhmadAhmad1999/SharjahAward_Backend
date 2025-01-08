using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CircularModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
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
            IFileService _FileService,
            IUserRepository _UserRepository,
            IJwtProvider _JwtProvider,
            IMapper _Mapper)
        {
            this._CircularChairmanRepository = _CircularChairmanRepository;
            this._CircularRepository = _CircularRepository;
            this._CoordinatorRepository = _CoordinatorRepository;
            this._ArbitratorRepository = _ArbitratorRepository;
            this._CircularArbitratorRepository = _CircularArbitratorRepository;
            this._CircularCoordinatorRepository = _CircularCoordinatorRepository;
            this._FileService = _FileService;
            this._UserRepository = _UserRepository;
            this._JwtProvider = _JwtProvider;
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
                        : Request.CoordinatorId!;

                    if (CoordinatorsIds.Any())
                    {
                        IReadOnlyList<CircularCoordinator> CircularCoordinatorEntitiesToDelete = await _CircularCoordinatorRepository
                            .ListAllAsync();

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
                        : Request.ArbitratorId!;

                    if (ArbitratorsIds.Any())
                    {
                        IReadOnlyList<CircularArbitrator> CircularArbitratorEntitiesToDelete = await _CircularArbitratorRepository
                            .ListAllAsync();

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
                        : Request.ChairmanId!;

                    if (ChairmansIds.Any())
                    {
                        IReadOnlyList<CircularChairman> CircularChairmanEntitiesToDelete = await _CircularChairmanRepository
                            .ListAllAsync();

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

                    _Mapper.Map(Request, CircularEntity, typeof(UpdateCircularCommand), typeof(Circular));

                    await _CircularRepository.UpdateAsync(CircularEntity);

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
