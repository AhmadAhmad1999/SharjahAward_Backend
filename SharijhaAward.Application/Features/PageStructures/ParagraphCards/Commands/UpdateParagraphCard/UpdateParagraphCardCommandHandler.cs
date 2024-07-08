using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.UpdateDarkCard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.UpdateParagraphCard
{
    public class UpdateParagraphCardCommandHandler
        : IRequestHandler<UpdateParagraphCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ParagraphCard> _paragraphCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateParagraphCardCommandHandler(IAsyncRepository<PageStructure> pageStructureRepository, IAsyncRepository<ParagraphCard> paragraphCardRepository, IFileService fileService, IMapper mapper)
        {
            _paragraphCardRepository = paragraphCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateParagraphCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                       ? "Dark Card has been Updated"
                       : "تم تعديل العنصر ";

            var ParagraphCard = await _paragraphCardRepository.GetByIdAsync(request.Id);
            if (ParagraphCard == null)
            {
                msg = request.lang == "en"
                    ? "Dark Card Not Found"
                    : "العنصر غير وجود ";

                return new BaseResponse<object>(msg, false, 404);
            }

            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);
            if (page == null)
            {
                msg = request.lang == "en"
                    ? "Page Not found"
                    : "الصفحة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, ParagraphCard, typeof(UpdateParagraphCardCommand), typeof(ParagraphCard));
         
            if(request.UpdateonImage != null && request.UpdateonImage == true)
            {
                ParagraphCard.ImageUrl = await _fileService.SaveFileAsync(request.Image!, SystemFileType.Images);
            }
            
            await _paragraphCardRepository.UpdateAsync(ParagraphCard);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
