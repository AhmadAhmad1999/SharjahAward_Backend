using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.CreateParagraphCard
{
    public class CreateParagraphCardCommandHandler
        : IRequestHandler<CreateParagraphCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ParagraphCard> _paragraphCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateParagraphCardCommandHandler(IAsyncRepository<ParagraphCard> paragraphCardRepository, IAsyncRepository<PageStructure> pageStructureRepository, IFileService fileService, IMapper mapper)
        {
            _paragraphCardRepository = paragraphCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateParagraphCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Dark Card has been Created"
                : "تم إنشاء العنصر ";

            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);

            if (page == null)
            {
                msg = request.lang == "en"
                ? "Page Not found"
                : "الصفحة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var ParagraphCard = _mapper.Map<ParagraphCard>(request);

            if(request.Image != null)
            {
                ParagraphCard.ImageUrl = await _fileService.SaveFileAsync(request.Image);
            }

            await _paragraphCardRepository.AddAsync(ParagraphCard);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
