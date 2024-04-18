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

        public CreateCommitteeHandler(IMapper Mapper,
            IAsyncRepository<Committee> CommitteeRepository,
            IAsyncRepository<ComitteeArbitrator> ComitteeArbitratorRepository,
            IAsyncRepository<CategoryCommittee> CategoryCommitteeRepository)
        {
            _Mapper = Mapper;
            _CommitteeRepository = CommitteeRepository;
            _ComitteeArbitratorRepository = ComitteeArbitratorRepository;
            _CategoryCommitteeRepository = CategoryCommitteeRepository;
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

                    List<ComitteeArbitrator> NewComitteeArbitratorEntities = Request.ArbitratorsIds
                        .Select(x => new ComitteeArbitrator()
                        {
                            ArbitratorId = x,
                            CommitteeId = NewCommitteeEntity.Id
                        }).ToList();

                    await _ComitteeArbitratorRepository.AddRangeAsync(NewComitteeArbitratorEntities);

                    List<CategoryCommittee> NewCategoryCommitteeEntities = Request.CategoriesIds
                        .Select(x => new CategoryCommittee()
                        {
                            CategoryId = x,
                            CommitteeId = NewCommitteeEntity.Id
                        }).ToList();

                    await _CategoryCommitteeRepository.AddRangeAsync(NewCategoryCommitteeEntities);

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
