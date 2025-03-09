using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.CommitteeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Commands.CreateCommittee
{
    public class CreateCommitteeHandler : IRequestHandler<CreateCommitteeCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Committee> _CommitteeRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<CategoryCommittee> _CategoryCommitteeRepository;
        private readonly IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository;

        public CreateCommitteeHandler(IMapper _Mapper,
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

        public async Task<BaseResponse<object>> Handle(CreateCommitteeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

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
                    Committee NewCommitteeEntity = _Mapper.Map<Committee>(Request);

                    await _CommitteeRepository.AddAsync(NewCommitteeEntity);

                    if (Request.ArbitratorsIds.Any())
                    {
                        List<ComitteeArbitrator> NewComitteeArbitratorEntities = Request.ArbitratorsIds
                            .Select(x => new ComitteeArbitrator()
                            {
                                ArbitratorId = x,
                                CommitteeId = NewCommitteeEntity.Id
                            }).ToList();

                        await _ComitteeArbitratorRepository.AddRangeAsync(NewComitteeArbitratorEntities);
                    }

                    if (Request.CategoriesIds.Any())
                    {
                        List<CategoryCommittee> NewCategoryCommitteeEntities = Request.CategoriesIds
                            .Select(x => new CategoryCommittee()
                            {
                                CategoryId = x,
                                CommitteeId = NewCommitteeEntity.Id
                            }).ToList();

                        await _CategoryCommitteeRepository.AddRangeAsync(NewCategoryCommitteeEntities);
                    }

                    if (Request.OfficersIds.Any())
                    {
                        List<ComitteeOfficer> NewCategoryCommitteeEntities = Request.OfficersIds
                            .Select(x => new ComitteeOfficer()
                            {
                                ArbitratorId = x,
                                CommitteeId = NewCommitteeEntity.Id
                            }).ToList();

                        await _ComitteeOfficerRepository.AddRangeAsync(NewCategoryCommitteeEntities);
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء اللجنة بنجاح";

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
