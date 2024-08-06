using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CircularModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Command.UpdateCircular
{
    public class UpdateCircularCommandHandler
        : IRequestHandler<UpdateCircularCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<Arbitrator> _arbitratorRepository;
        private readonly IAsyncRepository<CircularArbitrator> _circularArbitratorRepository;
        private readonly IAsyncRepository<CircularCoordinator> _circularCoordinatorRepository;
        private readonly IAsyncRepository<CircularChairman> _circularChairmanRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
        private readonly IJwtProvider _jwtProvider;
        private readonly IUserRepository _userRepository;

        public UpdateCircularCommandHandler(
            IAsyncRepository<CircularChairman> circularChairmanRepository,
            IAsyncRepository<Circular> circularRepository,
            IAsyncRepository<Coordinator> coordinatorRepository, 
            IAsyncRepository<Arbitrator> arbitratorRepository, 
            IAsyncRepository<CircularAttachment> circularAttachmentRepository,
            IAsyncRepository<CircularArbitrator> circularArbitratorRepository,
            IAsyncRepository<CircularCoordinator> circularCoordinatorRepository,
            IFileService fileService,
            IUserRepository userRepository,
            IJwtProvider jwtProvider,
            IMapper mapper)
        {
            _circularRepository = circularRepository;
            _coordinatorRepository = coordinatorRepository;
            _arbitratorRepository = arbitratorRepository;
            _circularArbitratorRepository = circularArbitratorRepository;
            _circularCoordinatorRepository = circularCoordinatorRepository;
            _circularChairmanRepository = circularChairmanRepository;
            _fileService = fileService;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCircularCommand request, CancellationToken cancellationToken)
        {
            var userId = _jwtProvider.GetUserIdFromToken(request.token!);

            var user = await _userRepository.GetByIdAsync(int.Parse(userId));
            if (user == null)
            {
                return new BaseResponse<object>("unAuth", false, 401);
            }

            string msg = request.lang == "en"
                ? "Circular has been Updated"
                : "تم تعديل التعميم";

            var CircularToUpdate = await _circularRepository.GetByIdAsync(request.Id);
            
            if(CircularToUpdate == null)
            {
                msg = request.lang == "en"
                ? "Circular Not found"
                : "التعيم غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            var Coordinators = request.AllCoordinators == true
                ? await _coordinatorRepository.Select(c => c.Id).ToListAsync()
                : request.CoordinatorId;

            if (Coordinators != null)
            {
                var all = await _circularCoordinatorRepository.ListAllAsync();
                await _circularCoordinatorRepository.DeleteListAsync(all);

                foreach (var coordinatorId in Coordinators!)
                {
                    CircularCoordinator circularCoordinator = new CircularCoordinator()
                    {
                        CoordinatorId = coordinatorId,
                        CircularId = request.Id
                    };

                    await _circularCoordinatorRepository.AddAsync(circularCoordinator, user.ArabicName);
                }
            }


            var Arbitrators = request.AllArbitrators == true
                ? await _arbitratorRepository.Select(c => c.Id).ToListAsync()
                : request.ArbitratorId;

            if (Arbitrators != null)
            {
                var all = await _circularArbitratorRepository.ListAllAsync();
                await _circularArbitratorRepository.DeleteListAsync(all);

                foreach (var arbitratorId in Arbitrators!)
                {
                    CircularArbitrator circularArbitrator = new CircularArbitrator()
                    {
                        ArbitratorId = arbitratorId,
                        CircularId = request.Id
                    };

                    await _circularArbitratorRepository.AddAsync(circularArbitrator, user.ArabicName);
                }
            }


            var Chairmans = request.AllChairmans == true
                ? await _arbitratorRepository.Where(a => a.isChairman).Select(a => a.Id).ToListAsync()
                : request.ChairmanId;

            if (Chairmans != null)
            {
                var all = await _circularChairmanRepository.ListAllAsync();
                await _circularChairmanRepository.DeleteListAsync(all);
                
                foreach (var chairmanId in Chairmans!)
                {
                    CircularChairman circularChairman = new CircularChairman()
                    {
                        ChairmanId = chairmanId,
                        CircularId = request.Id
                    };

                    await _circularChairmanRepository.AddAsync(circularChairman, user.ArabicName);
                }
            }
            _mapper.Map(request, CircularToUpdate, typeof(UpdateCircularCommand), typeof(Circular));

            await _circularRepository.UpdateAsync(CircularToUpdate);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
