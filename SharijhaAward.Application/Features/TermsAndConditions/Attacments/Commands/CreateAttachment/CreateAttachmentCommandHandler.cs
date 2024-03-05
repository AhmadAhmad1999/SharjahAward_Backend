using AutoMapper;
using MediatR;
using Microsoft.VisualBasic;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.CreateAttachment
{
    public class CreateAttachmentCommandHandler
        : IRequestHandler<CreateAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ConditionsAttachment> _attachmentsRepository;
        private readonly IAsyncRepository<TermAndCondition> _termsRepository;
        private readonly IMapper _mapper;

        public CreateAttachmentCommandHandler
            (
                 IAsyncRepository<ConditionsAttachment> attachmentsRepository,
                 IAsyncRepository<TermAndCondition> termsRepository,
                 IMapper mapper
            )
        {
            _attachmentsRepository = attachmentsRepository;
            _termsRepository = termsRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAttachmentCommand request, CancellationToken cancellationToken)
        {
            var term = await _termsRepository.GetByIdAsync(request.TermAndConditionId);
            string msg;
            if (term == null)
            {
                msg = request.lang == "en"
                    ? "The TermAndCondition Not Found"
                    : "الشرط غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            var data = _mapper.Map<ConditionsAttachment>(request);

            await _attachmentsRepository.AddAsync(data);

            return new BaseResponse<object>("", true, 200);
        }
    }
}

