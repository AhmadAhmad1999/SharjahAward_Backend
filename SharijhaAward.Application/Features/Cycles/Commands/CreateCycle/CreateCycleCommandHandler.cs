using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using System.Text.RegularExpressions;
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

        public async Task<BaseResponse<object>> Handle(CreateCycleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = Request.lang == "en"
                ? "Cycle has been Created"
                : "تم إنشاء الدورة بنجاح";

            if (Request.Year is not null
                ? Request.Year.Contains('-')
                : false)
            {
                // Regex to match the pattern yyyy - yyyy, allowing spaces around the hyphen
                string Pattern = @"^\s*(?<leftYear>\d{4})\s*-\s*(?<rightYear>\d{4})\s*$";
                Match Match = Regex.Match(Request.Year, Pattern);

                if (Match.Success)
                {
                    // Extract the left and right year values
                    int LeftYear = int.Parse(Match.Groups["leftYear"].Value);
                    int RightYear = int.Parse(Match.Groups["rightYear"].Value);

                    // Check if rightYear is exactly one more than leftYear
                    if (RightYear != LeftYear + 1)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Cycle year must be in this format: \"yyyy-yyyy\" and the right year must be the next year for the left year"
                            : "يجب أن يكون عام الدورة بهذا التنسيق: \"yyyy-yyyy\" و أن يكون العام الموجود على اليمين هو العام التالي للعام الموجود على اليسار";

                        return new BaseResponse<object>(ResponseMessage, false, 400);
                    }
                }
                else
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Cycle year must be in this format: \"yyyy-yyyy\" and the right year must be the next year for the left year"
                        : "يجب أن يكون عام الدورة بهذا التنسيق: \"yyyy-yyyy\" و أن يكون العام الموجود على اليمين هو العام التالي للعام الموجود على اليسار";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
            }

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
                    var cycle = _mapper.Map<Cycle>(Request);
                    if (cycle.Status == Domain.Constants.Common.Status.Active)
                    {
                        var ActiveCycle = await _cycleRepository
                            .FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active);

                        if (ActiveCycle is not null)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? "You can't add to Active Cycle"
                                : "لا يمكن إضافة أكثر من دورة فعالة";

                            return new BaseResponse<object>(ResponseMessage, false, 400);
                        }
                    }
                    var data = await _cycleRepository.AddAsync(cycle);

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200, data.Id);
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
