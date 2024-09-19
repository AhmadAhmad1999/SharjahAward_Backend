using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.UpdateArbitrator
{
    public class UpdateArbitratorCommandHandler
        : IRequestHandler<UpdateArbitratorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _Mapper;

        public UpdateArbitratorCommandHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
            IAsyncRepository<ArbitratorClass> ArbitratorClassRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IUserRepository UserRepository,
            IMapper Mapper)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
            _ArbitratorClassRepository = ArbitratorClassRepository;
            _UserTokenRepository = UserTokenRepository;
            _UserRepository = UserRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateArbitratorCommand Request, CancellationToken cancellationToken)
        {
            var ArbitratorToUpdate = await _ArbitratorRepository.GetByIdAsync(Request.Id);

            string ResponseMessage = Request.lang == "en"
                ? "Arbitrator has been Updated"
                : "تم تعديل المنسق";

            if (ArbitratorToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator not found"
                    : "المنسق غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, ArbitratorToUpdate, typeof(UpdateArbitratorCommand), typeof(Arbitrator));

            UserEntity.Email = Request.Email;
            UserEntity.ArabicName = Request.ArabicName;
            UserEntity.EnglishName = Request.EnglishName;
            UserEntity.PhoneNumber = Request.PhoneNumber;

            List<int> AlreadyExistCategoriesIds = await _CategoryArbitratorRepository
                .Where(x => x.ArbitratorId == Request.Id)
                .Select(x => x.CategoryId)
                .ToListAsync();

            List<int> IntersectCategoriesIds = AlreadyExistCategoriesIds
                .Intersect(Request.Categories).ToList();

            List<int> NewCategoriesIds = Request.Categories
                .Where(x => !IntersectCategoriesIds.Contains(x))
                .ToList();

            List<int> DeleteCategoriesIds = AlreadyExistCategoriesIds
                .Where(x => !IntersectCategoriesIds.Contains(x))
                .ToList();

            List<int> AlreadyExistArbitratorClassIds = await _ArbitratorClassRepository
                .Where(x => x.ArbitratorId == Request.Id)
                .Select(x => x.CategoryEducationalClassId)
                .ToListAsync();

            List<int> IntersectArbitratorClassIds = AlreadyExistArbitratorClassIds
                .Intersect(Request.ArbitratorCategoryClasses).ToList();

            List<int> NewArbitratorClassIds = Request.ArbitratorCategoryClasses
                .Where(x => !IntersectArbitratorClassIds.Contains(x))
                .ToList();

            List<int> DeleteArbitratorClassIds = AlreadyExistArbitratorClassIds
                .Where(x => !IntersectArbitratorClassIds.Contains(x))
                .ToList();

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
                    if (Request.isChairman != ArbitratorToUpdate.isChairman)
                        _UserTokenRepository
                            .Where(x => x.UserId == Request.Id)
                            .ExecuteUpdate(x => x.SetProperty(y => y.isDeleted, true));

                    await _ArbitratorRepository.UpdateAsync(ArbitratorToUpdate);
                    await _UserRepository.UpdateAsync(UserEntity);

                    IQueryable<CategoryArbitrator> DeleteCategoryArbitratorEntites = _CategoryArbitratorRepository
                        .Where(x => x.ArbitratorId == Request.Id &&
                            DeleteCategoriesIds.Contains(x.CategoryId));

                    if (DeleteCategoryArbitratorEntites.Count() > 0)
                        await _CategoryArbitratorRepository.DeleteListAsync(DeleteCategoryArbitratorEntites);

                    IEnumerable<CategoryArbitrator> NewCategoryArbitratorEntites = NewCategoriesIds.
                        Select(x => new CategoryArbitrator()
                        {
                            ArbitratorId = Request.Id,
                            CategoryId = x,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        });

                    if (NewCategoryArbitratorEntites.Count() > 0)
                        await _CategoryArbitratorRepository.AddRangeAsync(NewCategoryArbitratorEntites);

                    IQueryable<ArbitratorClass> DeleteArbitratorClassEntites = _ArbitratorClassRepository
                        .Where(x => x.ArbitratorId == Request.Id &&
                            DeleteArbitratorClassIds.Contains(x.CategoryEducationalClassId));

                    if (DeleteArbitratorClassEntites.Count() > 0)
                        await _ArbitratorClassRepository.DeleteListAsync(DeleteArbitratorClassEntites);

                    IEnumerable<ArbitratorClass> NewArbitratorClassEntites = NewArbitratorClassIds.
                        Select(x => new ArbitratorClass()
                        {
                            ArbitratorId = Request.Id,
                            CategoryEducationalClassId = x,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        });

                    if (NewArbitratorClassEntites.Count() > 0)
                        await _ArbitratorClassRepository.AddRangeAsync(NewArbitratorClassEntites);

                    Transaction.Complete();
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
