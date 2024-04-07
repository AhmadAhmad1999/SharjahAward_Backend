using Aspose.Pdf.LogicalStructure;
using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachment
{
    public class GetAllExtraAttachmentByFormIdQueryHandler
        : IRequestHandler<GetAllExtraAttachmentByFormIdQuery, BaseResponse<List<ExtraAttachmentListVM>>>
    {
        private readonly IAsyncRepository<ExtraAttachment> _extraAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formModelRepository;
        private readonly IAsyncRepository<ExtraAttachmentProvidedForm> _AttachmentRepository;
        private readonly IMapper _mapper;

        public GetAllExtraAttachmentByFormIdQueryHandler(IAsyncRepository<ExtraAttachmentProvidedForm> AttachmentRepository,IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formModelRepository,IAsyncRepository<ExtraAttachment> extraAttachmentRepository, IMapper mapper)
        {
            _extraAttachmentRepository = extraAttachmentRepository;
            _AttachmentRepository = AttachmentRepository;
            _formModelRepository = formModelRepository;
            _mapper = mapper;
        }

        public Task<BaseResponse<List<ExtraAttachmentListVM>>> Handle(GetAllExtraAttachmentByFormIdQuery request, CancellationToken cancellationToken)
        {
            var ExtraAttachments = _AttachmentRepository.WhereThenInclude(a => a.ProvidedFormId == request.formId, a => a.ExtraAttachment!).ToList();
            throw new NotImplementedException();
        }
    }
}
