using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
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
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _attachmentRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _cycleConditionsFormRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public ReviewCycleConditionAttachmentsQueryHandler(IAsyncRepository<CycleCondition> cycleConditionRepository, IAsyncRepository<CycleConditionAttachment> attachmentRepository, IAsyncRepository<CycleConditionsProvidedForm> cycleConditionsFormRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
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
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));

            if(User == null)
            {
                return new BaseResponse<List<CycleConditionListVM>>("", false, 401);
            }

            var form = await _formRepository.GetByIdAsync(request.formId);
            if(form == null)
            {
                return new BaseResponse<List<CycleConditionListVM>>("", false, 404);
            }

            var Conditions = _cycleConditionRepository.ListAllAsync();

            throw new NotImplementedException();

        }
    }
}
