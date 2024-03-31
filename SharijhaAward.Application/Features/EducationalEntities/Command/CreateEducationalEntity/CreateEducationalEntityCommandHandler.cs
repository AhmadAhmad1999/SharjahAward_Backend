using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity
{
    public class CreateEducationalEntityCommandHandler :
        IRequestHandler<CreateEducationalEntityCommand, BaseResponse<Guid>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IMapper _Mapper;

        public CreateEducationalEntityCommandHandler(IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository,
            IMapper Mapper)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<Guid>> Handle(CreateEducationalEntityCommand Request, CancellationToken cancellationToken)
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
                    EducationalEntity NewEducationalEntity = _Mapper.Map<EducationalEntity>(Request);

                    await _EducationalEntityRepository.AddAsync(NewEducationalEntity);

                    IEnumerable<EducationalInstitution> NewEducationalInstitutionEntities = Request.EducationalInstitutions
                        .Select(x => new EducationalInstitution()
                        {
                            ArabicName = x.ArabicName,
                            EnglishName = x.EnglishName,
                            EducationalEntityId = NewEducationalEntity.Id,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        });

                    await _EducationalInstitutionRepository.AddRangeAsync(NewEducationalInstitutionEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الجهة التعليمية بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<Guid>(ResponseMessage, true, 200, NewEducationalEntity.Id);
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
