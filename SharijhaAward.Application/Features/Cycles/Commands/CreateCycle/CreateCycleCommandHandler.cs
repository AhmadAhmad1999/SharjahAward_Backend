﻿using AutoMapper;
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
        private readonly IMapper _mapper;

        public CreateCycleCommandHandler(IAsyncRepository<Cycle> cycleRepository,
            IMapper mapper)
        {
            _cycleRepository = cycleRepository;
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
