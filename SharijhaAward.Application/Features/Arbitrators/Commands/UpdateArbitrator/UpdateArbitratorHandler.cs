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
        private readonly IAsyncRepository<SubcommitteeCategory> _SubcommitteeCategoryRepository;

        public UpdateArbitratorCommandHandler(IAsyncRepository<Arbitrator> _ArbitratorRepository,
            IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository,
            IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository,
            IAsyncRepository<UserToken> _UserTokenRepository,
            IUserRepository _UserRepository,
            IMapper _Mapper,
            IAsyncRepository<SubcommitteeCategory> _SubcommitteeCategoryRepository)
        {
            this._ArbitratorRepository = _ArbitratorRepository;
            this._CategoryArbitratorRepository = _CategoryArbitratorRepository;
            this._ArbitratorClassRepository = _ArbitratorClassRepository;
            this._UserTokenRepository = _UserTokenRepository;
            this._UserRepository = _UserRepository;
            this._Mapper = _Mapper;
            this._SubcommitteeCategoryRepository = _SubcommitteeCategoryRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateArbitratorCommand Request, CancellationToken cancellationToken)
        {
            Arbitrator? ArbitratorEntityToUpdate = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            string ResponseMessage = Request.lang == "en"
                ? "Arbitrator has been Updated"
                : "تم تعديل المحكم";

            if (ArbitratorEntityToUpdate is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator not found"
                    : "المنسق غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, ArbitratorEntityToUpdate, typeof(UpdateArbitratorCommand), typeof(Arbitrator));

            UserEntity.Email = Request.Email;
            UserEntity.ArabicName = Request.ArabicName;
            UserEntity.EnglishName = Request.EnglishName;
            UserEntity.PhoneNumber = Request.PhoneNumber;

            List<int> AlreadyExistCategoriesIds = await _CategoryArbitratorRepository
                .Where(x => x.ArbitratorId == Request.Id)
                .Select(x => x.CategoryId)
                .ToListAsync();

            List<int> IntersectCategoriesIds = AlreadyExistCategoriesIds
                .Intersect(Request.ArbitratorCateogryClasses.Select(x => x.Id)).ToList();

            List<int> NewCategoriesIds = Request.ArbitratorCateogryClasses.Select(x => x.Id)
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
                .Intersect(Request.ArbitratorCateogryClasses.SelectMany(x => x.Classes)).ToList();

            List<int> NewArbitratorClassIds = Request.ArbitratorCateogryClasses
                .SelectMany(x => x.Classes)
                .Where(x => !IntersectArbitratorClassIds.Contains(x))
                .ToList();

            List<int> DeleteArbitratorClassIds = AlreadyExistArbitratorClassIds
                .Where(x => !IntersectArbitratorClassIds.Contains(x))
                .ToList();

            List<SubcommitteeCategory> SubcommitteeCategoryEntities = await _SubcommitteeCategoryRepository
                .Where(x => x.ArbitratorId == Request.Id)
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
                    if (Request.isChairman != ArbitratorEntityToUpdate.isChairman)
                        _UserTokenRepository
                            .Where(x => x.UserId == Request.Id)
                            .ExecuteUpdate(x => x.SetProperty(y => y.isDeleted, true));

                    await _ArbitratorRepository.UpdateAsync(ArbitratorEntityToUpdate);
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

                    if (SubcommitteeCategoryEntities.Any())
                        await _SubcommitteeCategoryRepository.DeleteListAsync(SubcommitteeCategoryEntities);

                    if (Request.SubcommitteeOfficerCategories.Any() &&
                        Request.isSubcommitteeOfficer)
                    {
                        List<SubcommitteeCategory> NewSubcommitteeCategoryEntitiesAsOfficer = Request.SubcommitteeOfficerCategories
                            .Select(x => new SubcommitteeCategory()
                            {
                                ArbitratorId = ArbitratorEntityToUpdate.Id,
                                CategoryId = x
                            }).ToList();

                        await _SubcommitteeCategoryRepository.AddRangeAsync(NewSubcommitteeCategoryEntitiesAsOfficer);
                    }

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
