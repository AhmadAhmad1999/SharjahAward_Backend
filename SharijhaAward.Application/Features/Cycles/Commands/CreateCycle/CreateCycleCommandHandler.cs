using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Cycles.Commands.CreateCycle
{
    public class CreateCycleCommandHandler 
        : IRequestHandler<CreateCycleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IMapper _mapper;

        public CreateCycleCommandHandler(IAsyncRepository<Cycle> cycleRepository,
            IAsyncRepository<EducationalClass> EducationalClassRepository,
            IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _EducationalClassRepository = EducationalClassRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateCycleCommand request, CancellationToken cancellationToken)
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
                    string msg = request.lang == "en"
                        ? "Cycle has been Created"
                        : "تم إنشاء الدورة بنجاح";

                    var cycle = _mapper.Map<Cycle>(request);
                    if (cycle.Status == Domain.Constants.Common.Status.Active)
                    {
                        var ActiveCycle = await _cycleRepository.Where(c => c.Status == Domain.Constants.Common.Status.Active).FirstOrDefaultAsync();
                        if (ActiveCycle != null)
                        {
                            msg = request.lang == "en"
                              ? "You can't add to Active Cycle"
                              : "لا يمكن إضافة أكثر من دورة فعالة";

                            return new BaseResponse<object>(msg, false, 400);
                        }

                    }
                    var data = await _cycleRepository.AddAsync(cycle);

                    List<EducationalClass> EducationalClassesEntities = new List<EducationalClass>()
                    {
                        new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                            ArabicName = "الصف الأول",
                            EnglishName = "First class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                            ArabicName = "الصف الثاني",
                            EnglishName = "Second class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                            ArabicName = "الصف الثالث",
                            EnglishName = "Third class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                            ArabicName = "الصف الرابع",
                            EnglishName = "Forth class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                            ArabicName = "الصف الخامس",
                            EnglishName = "Fifth class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                            ArabicName = "الصف السادس",
                            EnglishName = "Sixth class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                            ArabicName = "الصف السابع",
                            EnglishName = "Seventh class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                            ArabicName = "الصف الثامن",
                            EnglishName = "Eighth class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                            ArabicName = "الصف التاسع",
                            EnglishName = "Ninth class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                            ArabicName = "الصف العاشر",
                            EnglishName = "Tenth class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                            ArabicName = "الصف الحادي عشر",
                            EnglishName = "Eleventh class",
                            CycleId = cycle.Id
                        }, new EducationalClass()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                            ArabicName = "الصف الثاني عشر",
                            EnglishName = "Twelfth class",
                            CycleId = cycle.Id
                        }
                    };

                    await _EducationalClassRepository.AddRangeAsync(EducationalClassesEntities);

                    Transaction.Complete();

                    return new BaseResponse<object>(msg, true, 200, data.Id);
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
