using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Commands.UpdateCoordinator
{
    public class UpdateCoordinatorCommandHandler
        : IRequestHandler<UpdateCoordinatorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateCoordinatorCommandHandler(IUserRepository userRepository, IAsyncRepository<Coordinator> coordinatorRepository, IFileService fileService, IMapper mapper)
        {
            _coordinatorRepository = coordinatorRepository;
            _userRepository = userRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCoordinatorCommand request, CancellationToken cancellationToken)
        {
            var CoordinatorToUpdate = await _coordinatorRepository.GetByIdAsync(request.Id);
            
            string msg = request.lang == "en"
                ? "Coordinator has been Updated"
                : "تم تعديل المنسق";

            if(CoordinatorToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "Coordinator not found"
                    : "المنسق غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            _mapper.Map(request, CoordinatorToUpdate, typeof(UpdateCoordinatorCommand), typeof(Coordinator));

            if (request.UpdateOnPersonalPhoto)
                CoordinatorToUpdate.PersonalPhoto = await _fileService.SaveFileAsync(request.PersonalPhoto);
           
            await _coordinatorRepository.UpdateAsync(CoordinatorToUpdate);
            
            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
