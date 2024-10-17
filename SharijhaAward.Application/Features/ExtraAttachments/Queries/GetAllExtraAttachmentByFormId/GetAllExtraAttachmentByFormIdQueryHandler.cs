using Aspose.Pdf.LogicalStructure;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachmentByFormId;
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
        private readonly IAsyncRepository<ExtraAttachmentFile> _AttachmentRepository;
        private readonly IMapper _mapper;

        public GetAllExtraAttachmentByFormIdQueryHandler(IAsyncRepository<ExtraAttachmentFile> AttachmentRepository,IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formModelRepository,IAsyncRepository<ExtraAttachment> extraAttachmentRepository, IMapper mapper)
        {
            _extraAttachmentRepository = extraAttachmentRepository;
            _AttachmentRepository = AttachmentRepository;
            _formModelRepository = formModelRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<ExtraAttachmentListVM>>> Handle(GetAllExtraAttachmentByFormIdQuery request, CancellationToken cancellationToken)
        {
            var ExtraAttachments = await _extraAttachmentRepository
                .Where(e => e.ProvidedFormId == request.formId)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            List<ExtraAttachmentFile> AllAttachmentEntities = await _AttachmentRepository
                .Where(x => ExtraAttachments.Select(y => y.Id).Contains(x.ExtraAttachmentId))
                .ToListAsync();

            var data = _mapper.Map<List<ExtraAttachmentListVM>>(ExtraAttachments);

            for(int i = 0; i<ExtraAttachments.Count(); i++)
            {
                data[i].Title = request.lang == "en" ? data[i].EnglishTitle : data[i].ArabicTitle;
                data[i].Description = request.lang == "en" ? data[i].EnglishDescription : data[i].ArabicDescription;

                data[i].AttachmentList = _mapper.Map<List<AttachmentDto>>(AllAttachmentEntities
                    .Where(x => x.ExtraAttachmentId == data[i].Id)
                    .Select(x => new AttachmentDto()
                    {
                        Id = x.Id,
                        FileDescription = x.FileDescription,
                        FileName = x.FileName,
                        FileUrl = x.FileUrl,
                        IsAccept = x.IsAccept,
                        ReasonOfReject = x.ReasonOfReject
                    }).ToList());

                if (data[i].AttachmentList!.Any(a => a.IsAccept == false))
                    data[i].Rejected = true;
            }

            return new BaseResponse<List<ExtraAttachmentListVM>>("", true, 200, data);
        }
    }
}
