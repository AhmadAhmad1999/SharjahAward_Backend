using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CircularModel;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Command.CreateCircular
{
    public class CreateCircularCommandHandler
        : IRequestHandler<CreateCircularCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<Arbitrator> _arbitratorRepository;
        private readonly IAsyncRepository<CircularAttachment> _circularAttachmentRepository;
        private readonly IAsyncRepository<CircularArbitrator> _circularArbitratorRepository;
        private readonly IAsyncRepository<CircularCoordinator> _circularCoordinatorRepository;
        private readonly IAsyncRepository<CircularChairman> _circularChairmanRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFileService _fileService;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public CreateCircularCommandHandler(IUserRepository userRepository, IJwtProvider jwtProvider, IAsyncRepository<CircularChairman> circularChairmanRepository, IAsyncRepository<Circular> circularRepository, IAsyncRepository<Coordinator> coordinatorRepository, IAsyncRepository<Arbitrator> arbitratorRepository, IAsyncRepository<CircularAttachment> circularAttachmentRepository, IAsyncRepository<CircularArbitrator> circularArbitratorRepository, IAsyncRepository<CircularCoordinator> circularCoordinatorRepository, IFileService fileService, IMapper mapper)
        {
            _circularRepository = circularRepository;
            _coordinatorRepository = coordinatorRepository;
            _arbitratorRepository = arbitratorRepository;
            _circularAttachmentRepository = circularAttachmentRepository;
            _circularArbitratorRepository = circularArbitratorRepository;
            _circularCoordinatorRepository = circularCoordinatorRepository;
            _circularChairmanRepository = circularChairmanRepository;
            _userRepository = userRepository;
            _fileService = fileService;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateCircularCommand request, CancellationToken cancellationToken)
        {
            var userId = _jwtProvider.GetUserIdFromToken(request.token!);

            var user = await _userRepository.GetByIdAsync(int.Parse(userId));
            
            if(user == null)
            {
                return new BaseResponse<int>("unAuth", false, 401);
            }
           
            var Circular = _mapper.Map<Circular>(request);

            Circular.IsRead = false;

            var data = await _circularRepository.AddAsync(Circular, user.ArabicName);

            var Coordinators = request.AllCoordinators == true
                ? await _coordinatorRepository.Select(c=>c.Id).ToListAsync()
                : request.CoordinatorId;
           
            if(Coordinators != null)
            {
                foreach (var coordinatorId in Coordinators!)
                {
                    CircularCoordinator circularCoordinator = new CircularCoordinator()
                    {
                        CoordinatorId = coordinatorId,
                        CircularId = data.Id
                    };

                    await _circularCoordinatorRepository.AddAsync(circularCoordinator, user.ArabicName);
                }
            }
         

            var Arbitrators = request.AllArbitrators == true
                ? await _arbitratorRepository.Select(c => c.Id).ToListAsync()
                : request.ArbitratorId;

            if(Arbitrators != null)
            {
                foreach (var arbitratorId in Arbitrators!)
                {
                    CircularArbitrator circularArbitrator = new CircularArbitrator()
                    {
                        ArbitratorId = arbitratorId,
                        CircularId = data.Id
                    };

                    await _circularArbitratorRepository.AddAsync(circularArbitrator, user.ArabicName);
                }
            }
            

            var Chairmans = request.AllChairmans == true
                ? await _arbitratorRepository.Where(a => a.isChairman).Select(a => a.Id).ToListAsync()
                : request.ChairmanId;

            if(Chairmans != null)
            {
                foreach (var chairmanId in Chairmans!)
                {
                    CircularChairman circularChairman = new CircularChairman()
                    {
                        ChairmanId = chairmanId,
                        CircularId = data.Id
                    };

                    await _circularChairmanRepository.AddAsync(circularChairman, user.ArabicName);
                }
            }    
           

            if (request.CircularFiles != null)
            {
                foreach (var attachment in request.CircularFiles!)
                {
                    CircularAttachment circularAttachment = new CircularAttachment()
                    {
                        AttachementPath = await _fileService.SaveFileAsync(attachment, SystemFileType.Circulars),
                        CircularId = data.Id
                    };

                    await _circularAttachmentRepository.AddAsync(circularAttachment, user.ArabicName);
                }
            }

            string msg = request.lang == "en"
                ? "Circular has benn Created"
                : "تم إضافة التعميم";

            return new BaseResponse<int>(msg, true, 200, data.Id);
        }
    }
}
