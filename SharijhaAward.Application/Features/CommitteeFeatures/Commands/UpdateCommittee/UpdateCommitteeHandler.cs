using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.CommitteeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Commands.UpdateCommittee
{
    public class UpdateCommitteeHandler : IRequestHandler<UpdateCommitteeCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Committee> _CommitteeRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<CategoryCommittee> _CategoryCommitteeRepository;
        private readonly IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository;
        public UpdateCommitteeHandler(IMapper _Mapper,
            IAsyncRepository<Committee> _CommitteeRepository,
            IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository,
            IAsyncRepository<CategoryCommittee> _CategoryCommitteeRepository,
            IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository)
        {
            this._Mapper = _Mapper;
            this._CommitteeRepository = _CommitteeRepository;
            this._ComitteeArbitratorRepository = _ComitteeArbitratorRepository;
            this._CategoryCommitteeRepository = _CategoryCommitteeRepository;
            this._ComitteeOfficerRepository = _ComitteeOfficerRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCommitteeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Committee? CommitteeEntityToUpdate = await _CommitteeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CommitteeEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Committee is not found"
                    : "اللجنة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<int> AlreadyExistComitteeArbitratorIds = await _ComitteeArbitratorRepository
                .Where(x => x.CommitteeId == Request.Id)
                .Select(x => x.ArbitratorId)
                .ToListAsync();

            List<int> IntersectComitteeArbitratorIds = AlreadyExistComitteeArbitratorIds
                .Intersect(Request.ArbitratorsIds).ToList();

            List<int> NewComitteeArbitratorIds = Request.ArbitratorsIds
                .Where(x => !IntersectComitteeArbitratorIds.Contains(x))
                .ToList();

            List<int> DeleteComitteeArbitratorIds = AlreadyExistComitteeArbitratorIds
                .Where(x => !IntersectComitteeArbitratorIds.Contains(x))
                .ToList();

            List<int> AlreadyExistCategoryCommitteeIds = await _CategoryCommitteeRepository
                .Where(x => x.CommitteeId == Request.Id)
                .Select(x => x.CategoryId)
                .ToListAsync();

            List<int> IntersectCategoryCommitteeIds = AlreadyExistCategoryCommitteeIds
                .Intersect(Request.CategoriesIds).ToList();

            List<int> NewCategoryCommitteeIds = Request.CategoriesIds
                .Where(x => !IntersectCategoryCommitteeIds.Contains(x))
                .ToList();

            List<int> DeleteCategoryCommitteeIds = AlreadyExistCategoryCommitteeIds
                .Where(x => !IntersectCategoryCommitteeIds.Contains(x))
                .ToList();

            List<ComitteeOfficer> ComitteeOfficerEntititesToDelete = await _ComitteeOfficerRepository
                .Where(x => x.CommitteeId == Request.Id)
                .ToListAsync();

            List<ComitteeOfficer> NewComitteeOfficerEntities = Request.OfficersIds
                .Select(x => new ComitteeOfficer()
                {
                    ArbitratorId = x,
                    CommitteeId = Request.Id
                }).ToList();

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
                    _Mapper.Map(Request, CommitteeEntityToUpdate, typeof(UpdateCommitteeCommand), typeof(Committee));

                    await _CommitteeRepository.UpdateAsync(CommitteeEntityToUpdate);

                    IQueryable<ComitteeArbitrator> DeleteComitteeArbitratorEntites = _ComitteeArbitratorRepository
                        .Where(x => x.CommitteeId == Request.Id &&
                            DeleteComitteeArbitratorIds.Contains(x.ArbitratorId));

                    if (DeleteComitteeArbitratorEntites.Count() > 0)
                        await _ComitteeArbitratorRepository.DeleteListAsync(DeleteComitteeArbitratorEntites);

                    IEnumerable<ComitteeArbitrator> NewComitteeArbitratorEntites = NewComitteeArbitratorIds
                        .Select(x => new ComitteeArbitrator()
                        {
                            CommitteeId = Request.Id,
                            ArbitratorId = x,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        });

                    if (NewComitteeArbitratorEntites.Count() > 0)
                        await _ComitteeArbitratorRepository.AddRangeAsync(NewComitteeArbitratorEntites);

                    IQueryable<CategoryCommittee> DeleteCategoryCommitteeEntites = _CategoryCommitteeRepository
                        .Where(x => x.CommitteeId == Request.Id &&
                            DeleteCategoryCommitteeIds.Contains(x.CategoryId));

                    if (DeleteCategoryCommitteeEntites.Count() > 0)
                        await _CategoryCommitteeRepository.DeleteListAsync(DeleteCategoryCommitteeEntites);

                    IEnumerable<CategoryCommittee> NewCategoryCommitteeEntites = NewCategoryCommitteeIds
                        .Select(x => new CategoryCommittee()
                        {
                            CommitteeId = Request.Id,
                            CategoryId = x,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        });

                    if (NewCategoryCommitteeEntites.Count() > 0)
                        await _CategoryCommitteeRepository.AddRangeAsync(NewCategoryCommitteeEntites);

                    if (ComitteeOfficerEntititesToDelete.Any())
                        await _ComitteeOfficerRepository.DeleteListAsync(ComitteeOfficerEntititesToDelete);

                    if (NewComitteeOfficerEntities.Any())
                        await _ComitteeOfficerRepository.AddRangeAsync(NewComitteeOfficerEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Committee has been updated successfully"
                        : "تم تعديل اللجنة بنجاح";

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
