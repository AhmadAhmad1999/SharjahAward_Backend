using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitrator
{
    public class CreateArbitratorHandler
         : IRequestHandler<CreateArbitratorCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IRoleRepository _RoleRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public CreateArbitratorHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
            IRoleRepository RoleRepository, 
            IUserRepository UserRepository, 
            IMapper Mapper, 
            IAsyncRepository<ArbitratorClass> ArbitratorClassRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
            _RoleRepository = RoleRepository;
            _UserRepository = UserRepository;
            _Mapper = Mapper;
            _ArbitratorClassRepository = ArbitratorClassRepository;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<int>> Handle(CreateArbitratorCommand Request, CancellationToken cancellationToken)
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

                    Domain.Entities.IdentityModels.User? CheckEmailIfAlreadyUsedInUser = await _UserRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower() && x.isValidAccount);

                    if (CheckEmailIfAlreadyUsedInUser is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Invalid email or password"
                            : "خطأ في البريد الإلكتروني او كلمة المرور";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    Arbitrator? CheckEmailIfAlreadyUsedInArbitrator = await _ArbitratorRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

                    if (CheckEmailIfAlreadyUsedInArbitrator is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Invalid email or password"
                            : "خطأ في البريد الإلكتروني او كلمة المرور";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    Role? Role = await _RoleRepository.GetByName("Arbitrator");

                    if (Role is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Arbitrator role is not found"
                            : "دور المحكم غير موجود";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    Domain.Entities.IdentityModels.User NewUserEntity = new Domain.Entities.IdentityModels.User()
                    {
                        isDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        ArabicName = Request.ArabicName,
                        EnglishName = Request.EnglishName,
                        ConfirmationCodeForResetPassword = null,
                        ConfirmationCodeForSignUp = null,
                        Email = Request.Email,
                        Gender = 0,
                        ImageURL = null,
                        isValidAccount = true,
                        Password = "123456",
                        lang = null,
                        PhoneNumber = Request.PhoneNumber
                    };

                    await _UserRepository.AddAsync(NewUserEntity);

                    UserRole NewUserRoleEntity = new UserRole()
                    {
                        UserId = NewUserEntity.Id,
                        RoleId = Role.Id
                    };

                    await _UserRoleRepository.AddAsync(NewUserRoleEntity);

                    Arbitrator NewArbitratorEntity = _Mapper.Map<Arbitrator>(Request);
                    NewArbitratorEntity.Id = NewUserEntity.Id;

                    await _ArbitratorRepository.AddAsync(NewArbitratorEntity);

                    List<CategoryArbitrator> ListOfCategoriesArbitrators = Request.Categories
                        .Select(x => new CategoryArbitrator()
                        {
                            CategoryId = x,
                            ArbitratorId = NewUserEntity.Id,
                            isDeleted = false,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        }).ToList();

                    await _CategoryArbitratorRepository.AddRangeAsync(ListOfCategoriesArbitrators);

                    IEnumerable<ArbitratorClass> ArbitratorClassesEntities = Request.ArbitratorClasses
                        .Select(x => new ArbitratorClass()
                        {
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            EducationalClassId = x,
                            ArbitratorId = NewArbitratorEntity.Id
                        });

                    await _ArbitratorClassRepository.AddRangeAsync(ArbitratorClassesEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المحكم بنجاح";

                    return new BaseResponse<int>(ResponseMessage, true, 200, NewUserEntity.Id);
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
