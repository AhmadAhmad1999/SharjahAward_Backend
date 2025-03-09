using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Commands.UpdateCycle
{
    public class UpdateCycleCommandHandler
        : IRequestHandler<UpdateCycleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;

        private readonly IMapper _mapper;

        public UpdateCycleCommandHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IAsyncRepository<UserToken> UserTokenRepository,IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _UserTokenRepository = UserTokenRepository;
            _mapper = mapper;
            _providedFormRepository = providedFormRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCycleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CheckCycleNumberValidation = await _cycleRepository
                .FirstOrDefaultAsync(x => x.CycleNumber == Request.CycleNumber &&
                    x.Id != Request.Id);

            if (CheckCycleNumberValidation is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Cycle number is already used"
                    : "رقم الدورة مستخدم مسبقاً, الرجاء إدخال قيمة مختلفة";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

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

            var cycleToUpdate = await _cycleRepository.GetByIdAsync(Request.Id);
           
            
            if (cycleToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "The Cycle is Not Found"
                    : "الدورة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            var ActiveCycle = await _cycleRepository.Where(c => c.Status == 0 && c.Id != cycleToUpdate.Id).FirstOrDefaultAsync();
           
            if (Request.Status == 0)
            {
                if (ActiveCycle != null)
                {
                    ResponseMessage = Request.lang == "en"
                      ? "You can't add to Active Cycle"
                      : "لا يمكن إضافة أكثر من دورة فعالة";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }

            }

            // for Make all Forms Previous when Closed Cycle
            if (cycleToUpdate.Status == Domain.Constants.Common.Status.Active && Request.Status != Domain.Constants.Common.Status.Active)
            {
                var forms = _providedFormRepository
                    .Where(f => f.Category.CycleId == cycleToUpdate.Id)
                    .ToList();

                foreach (var form in forms)
                {
                    form.Type = Domain.Constants.ProvidedFromConstants.ProvidedFormType.Previous;
                }

                await _providedFormRepository.UpdateListAsync(forms);
            }
            else if (cycleToUpdate.Status != Domain.Constants.Common.Status.Active && Request.Status == Domain.Constants.Common.Status.Active)
            {
                var forms = _providedFormRepository
                    .Where(f => f.Category.CycleId == cycleToUpdate.Id)
                    .ToList();

                foreach (var form in forms)
                {
                    form.Type = Domain.Constants.ProvidedFromConstants.ProvidedFormType.Current;
                }

                await _providedFormRepository.UpdateListAsync(forms);
            }

            _mapper.Map(Request, cycleToUpdate, typeof(UpdateCycleCommand), typeof(Cycle));
            
            await _cycleRepository.UpdateAsync(cycleToUpdate);

            ActiveCycle = await _cycleRepository.Where(c => c.Status == Domain.Constants.Common.Status.Active).FirstOrDefaultAsync();
            
            if(ActiveCycle == null)
            {
                var UserTokenEntitiesToDelete = await _UserTokenRepository
                .ListAllAsync();

                await _UserTokenRepository.DeleteListAsync(UserTokenEntitiesToDelete);
            }

            ResponseMessage = Request.lang == "en"
                ? "The Cycle has been Updated"
                : "تم تعديل الدورة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
