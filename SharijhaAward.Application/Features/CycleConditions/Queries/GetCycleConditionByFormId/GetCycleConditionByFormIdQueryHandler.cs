using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId
{
    public class GetCycleConditionByFormIdQueryHandler
        : IRequestHandler<GetCycleConditionByFormIdQuery, BaseResponse<List<CyclePublicConditionListVm>>>
    {
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<CycleConditionAttachment> _conditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _conditionsProvidedFormsRepository;
        private readonly IUserRepository _userRepository;
       
     
        public GetCycleConditionByFormIdQueryHandler(IAsyncRepository<CycleCondition> cycleConditionRepository, IAsyncRepository<Cycle> cycleRepository, IMapper mapper, IAsyncRepository<CycleConditionAttachment> conditionAttachmentRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IAsyncRepository<CycleConditionsProvidedForm> conditionsProvidedFormsRepository, IUserRepository userRepository)
        {
            _cycleConditionRepository = cycleConditionRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
            _conditionAttachmentRepository = conditionAttachmentRepository;
            _providedFormRepository = providedFormRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _userRepository = userRepository;
        }

        public async Task<BaseResponse<List<CyclePublicConditionListVm>>> Handle(GetCycleConditionByFormIdQuery request, CancellationToken cancellationToken)
        {
            var Cycle = await _cycleRepository.FirstOrDefaultAsync(c=>c.Status == Domain.Constants.Common.Status.Active);
            if(Cycle == null)
            {
                return new BaseResponse<List<CyclePublicConditionListVm>>("", false, 404);
            }
            var form = _providedFormRepository.FirstOrDefault(p => p.Id == request.formId);

            var Terms = await _cycleConditionRepository.Where(t => t.CycleId == Cycle.Id).ToListAsync();

            List<CycleConditionsProvidedForm> conditionsProvideds = await _conditionsProvidedFormsRepository
                .Where(x => Terms.Select(y => y.Id).Contains(x.CycleConditionId) &&
                    x.ProvidedFormId == form!.Id)
                .ToListAsync(); ;

            for (int i = 0; i < Terms.Count(); i++)
            {
                var conditionsProvidedsobject =
                     conditionsProvideds.FirstOrDefault(c => c.CycleConditionId == Terms[i].Id);

                if (conditionsProvidedsobject != null)
                    conditionsProvideds.Add(conditionsProvidedsobject!);

                else
                {
                    var CycleConditionsProvidedForm = new CycleConditionsProvidedForm()
                    {
                        ProvidedFormId = form!.Id,
                        CycleConditionId = Terms[i].Id,
                        IsAgree = false,
                    };

                    var conditionProvided = await _conditionsProvidedFormsRepository.AddAsync(CycleConditionsProvidedForm);
                    conditionsProvideds.Add(conditionProvided);
                }
            }

            var data = _mapper.Map<List<CyclePublicConditionListVm>>(Terms);

            List<CycleConditionAttachment> AllConditionAttachmentEntities = await _conditionAttachmentRepository
                .Where(x => conditionsProvideds.Select(y => y.Id).Any(y => y == x.CycleConditionsProvidedFormId))
                .ToListAsync();

            for (int i = 0; i < data.Count(); i++)
            {
                data[i].ConditionsAttachments = _mapper.Map<CycleConditionProvidedFormListVm>(conditionsProvideds
                    .FirstOrDefault(x => x.CycleConditionId == data[i].Id));
               
                if (data[i].NeedAttachment)
                {
                    List<CycleConditionAttachment> AllConditionAttachmentEntitiesForThisTerm = AllConditionAttachmentEntities
                        .Where(x => conditionsProvideds[i].Id == x.CycleConditionsProvidedFormId)
                        .ToList();

                    data[i].ConditionsAttachments!.Attachments = 
                        _mapper.Map<List<CycleConditionAttachmentListVm>>(AllConditionAttachmentEntitiesForThisTerm);
                   
                    if (data[i].ConditionsAttachments!.Attachments.Any(a => a.IsAccept == false))
                        data[i].Rejected = true;
                }

                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                    ? data[i].EnglishDescription
                    : data[i].ArabicDescription;
            }

            return new BaseResponse<List<CyclePublicConditionListVm>>("", true, 200, data);
        }
    }
}
