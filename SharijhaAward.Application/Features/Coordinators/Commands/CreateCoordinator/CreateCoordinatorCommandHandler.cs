using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinator
{
    public class CreateCoordinatorCommandHandler
         : IRequestHandler<CreateCoordinatorCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public CreateCoordinatorCommandHandler(IRoleRepository roleRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IAsyncRepository<Coordinator> coordinatorRepository, 
            IFileService fileService, 
            IUserRepository userRepository, 
            IMapper Mapper,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _roleRepository = roleRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _coordinatorRepository = coordinatorRepository;
            _userRepository = userRepository;
            _fileService = fileService;
            _mapper = Mapper;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<int>> Handle(CreateCoordinatorCommand Request, CancellationToken cancellationToken)
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
                    string ResponseMessage = string.Empty;

                    Domain.Entities.IdentityModels.User? CheckEmailIfAlreadyUsedInUser = await _userRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower() && x.isValidAccount);

                    if (CheckEmailIfAlreadyUsedInUser is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "This email is already used"
                            : "البريد الإلكتروني مستخدم بالفعل";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    Coordinator? CheckEmailIfAlreadyUsedInCoordinator = await _coordinatorRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

                    if (CheckEmailIfAlreadyUsedInCoordinator is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "This email is already used"
                            : "البريد الإلكتروني مستخدم بالفعل";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    var User = new Domain.Entities.IdentityModels.User()
                    {
                        ArabicName = Request.ArabicName,
                        EnglishName = Request.EnglishName,
                        Email = Request.Email,
                        PhoneNumber = Request.PhoneNumber,
                        // ConfirmationCode = 0000,
                        // Password = "123456",
                        Gender = 0,
                        isValidAccount = true
                    };

                    byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

                    User.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: Request.Password,
                        salt: salt,
                        prf: KeyDerivationPrf.HMACSHA256,
                        iterationCount: 100000,
                        numBytesRequested: 256 / 8));

                    await _userRepository.AddAsync(User);

                    int UserId = User.Id;

                    var Coordinator = _mapper.Map<Coordinator>(Request);
                    Coordinator.Id = UserId;
                    

                    var data =  await _coordinatorRepository.AddAsync(Coordinator);

                    var role = await _roleRepository.GetByName("Coordinator");
                    if (role != null)
                    {
                        UserRole NewUserRoleEntity = new UserRole()
                        {
                            UserId = User.Id,
                            RoleId = role.Id
                        };

                        await _UserRoleRepository.AddAsync(NewUserRoleEntity);
                    }

                    if (Request.EducationalEntitiesIds != null)
                    {
                        foreach (var EntityId in Request.EducationalEntitiesIds)
                        {
                            var EduEntitiesCoordinator = new EduEntitiesCoordinator()
                            {
                                EducationalEntityId = EntityId,
                                CoordinatorId = data.Id
                            };

                            await _EduEntitiesCoordinatorRepository.AddAsync(EduEntitiesCoordinator);
                        }
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المنسق بنجاح";

                    return new BaseResponse<int>(ResponseMessage, true, 200, UserId);
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
