using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.ReferenceSourcesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ReferenceSources.Commands.UpdateReferenceSourcePage
{
    public class UpdateReferenceSourcePageCommandHandler
        : IRequestHandler<UpdateReferenceSourcePageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ReferenceSource> _referenceSourceRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateReferenceSourcePageCommandHandler(IAsyncRepository<ReferenceSource> referenceSourceRepository, IFileService fileService, IMapper mapper)
        {
            _referenceSourceRepository = referenceSourceRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateReferenceSourcePageCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Reference Source Page has been Updated"
                : "تم تعديل صفحة المصادر المرجعية";

            var ReferenceSourcePage = await _referenceSourceRepository.FirstOrDefaultAsync(r => !r.isDeleted);
            
            if(ReferenceSourcePage == null)
            {
                msg = request.lang == "en"
                    ? "Reference Source Page Not Found"
                    : "المصادر المرجعية غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var ImageUrl = ReferenceSourcePage.ImageUrl;
            
            _mapper.Map(request, ReferenceSourcePage, typeof(UpdateReferenceSourcePageCommand), typeof(ReferenceSource));
            
            if (request.UpdateOnImage)
                ReferenceSourcePage.ImageUrl = await _fileService.SaveFileAsync(request.Image!, SystemFileType.Images);
            else
                ReferenceSourcePage.ImageUrl = ImageUrl;

            await _referenceSourceRepository.UpdateAsync(ReferenceSourcePage);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
