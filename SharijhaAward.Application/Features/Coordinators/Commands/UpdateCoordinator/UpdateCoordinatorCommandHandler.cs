using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Coordinators.Commands.UpdateCoordinator
{
    public class UpdateCoordinatorCommandHandler
        : IRequestHandler<UpdateCoordinatorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository;

        public UpdateCoordinatorCommandHandler(IUserRepository userRepository,
            IAsyncRepository<Coordinator> coordinatorRepository, 
            IFileService fileService, 
            IMapper mapper,
            IAsyncRepository<EduInstitutionCoordinator> EduInstitutionCoordinatorRepository)
        {
            _coordinatorRepository = coordinatorRepository;
            _userRepository = userRepository;
            _fileService = fileService;
            _mapper = mapper;
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCoordinatorCommand Request, CancellationToken cancellationToken)
        {
            var CoordinatorToUpdate = await _coordinatorRepository.GetByIdAsync(Request.Id);
            
            string ResponseMessage = Request.lang == "en"
                ? "Coordinator has been Updated"
                : "تم تعديل المنسق";

            if(CoordinatorToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Coordinator not found"
                    : "المنسق غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }
            
            _mapper.Map(Request, CoordinatorToUpdate, typeof(UpdateCoordinatorCommand), typeof(Coordinator));

            Domain.Entities.IdentityModels.User? UserEntity = await _userRepository.FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            UserEntity.Email = Request.email;
            UserEntity.ArabicName = Request.arabicName;
            UserEntity.EnglishName = Request.englishName;
            UserEntity.PhoneNumber = Request.phoneNumber;

            List<int> AlreadyExistEduInstitutionIds = await _EduInstitutionCoordinatorRepository
                .Where(x => x.CoordinatorId == Request.Id)
                .Select(x => x.EducationalInstitutionId)
                .ToListAsync();


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
                    await _coordinatorRepository.UpdateAsync(CoordinatorToUpdate);
                    await _userRepository.UpdateAsync(UserEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Coordinator has been updated successfully"
                        : "تم تعديل المنسق بنجاح";
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
