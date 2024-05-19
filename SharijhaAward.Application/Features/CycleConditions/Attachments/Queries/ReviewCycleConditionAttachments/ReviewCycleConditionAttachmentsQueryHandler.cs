using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Attachments.Queries.ReviewCycleConditionAttachments
{
    public class ReviewCycleConditionAttachmentsQueryHandler
        : IRequestHandler<ReviewCycleConditionAttachmentsQuery, BaseResponse<List<CycleConditionListVM>>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _attachmentRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _cycleConditionsFormRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public ReviewCycleConditionAttachmentsQueryHandler(IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<CycleCondition> cycleConditionRepository, IAsyncRepository<CycleConditionAttachment> attachmentRepository, IAsyncRepository<CycleConditionsProvidedForm> cycleConditionsFormRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _cycleConditionRepository = cycleConditionRepository;
            _attachmentRepository = attachmentRepository;
            _cycleConditionsFormRepository = cycleConditionsFormRepository;
            _formRepository = formRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CycleConditionListVM>>> Handle(ReviewCycleConditionAttachmentsQuery request, CancellationToken cancellationToken)
        {
            var Cycle = await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active);
            if (Cycle == null)
            {
                return new BaseResponse<List<CycleConditionListVM>>("", false, 404);
            }
            var form = _formRepository.FirstOrDefault(p => p.Id == request.formId);
            if(form == null)
            {
                return new BaseResponse<List<CycleConditionListVM>>("", false, 400);
            }

            var Terms = _cycleConditionRepository.WhereThenInclude(t => t.CycleId == Cycle.Id && t.NeedAttachment==true, t => t.ConditionAttachments).ToList();

            List<CycleConditionsProvidedForm> conditionsProvideds = new List<CycleConditionsProvidedForm>();

            for (int i = 0; i < Terms.Count(); i++)
            {
                var conditionsProvidedsobject =
                 _cycleConditionsFormRepository.WhereThenInclude(
                     c => c.ProvidedFormId == form!.Id && c.CycleConditionId == Terms[i].Id,
                     c => c.Attachments).FirstOrDefault();

                if (conditionsProvidedsobject != null)
                    conditionsProvideds.Add(conditionsProvidedsobject!);
            }


            var data = _mapper.Map<List<CycleConditionListVM>>(Terms);
            for (int i = 0; i < data.Count; i++)
            {

                data[i].Attachments = _mapper.Map<List<CycleConditionAttachmentListVm>>(conditionsProvideds[i].Attachments);


                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                    ? data[i].EnglishDescription
                    : data[i].ArabicDescription;
            }
            return new BaseResponse<List<CycleConditionListVM>>("", true, 200, data);

        }
    }
}
//var UserId = _jwtProvider.GetUserIdFromToken(request.token);
//var User = await _userRepository.GetByIdAsync(int.Parse(UserId));

//if (User == null)
//{
//    return new BaseResponse<List<CycleConditionListVM>>("", false, 401);
//}