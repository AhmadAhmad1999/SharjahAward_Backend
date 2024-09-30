using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.PageStructureModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.CreatePage
{
    public class CreatePageCommandHandler
        : IRequestHandler<CreatePageCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreatePageCommandHandler(IAsyncRepository<PageStructure> pageStructureRepository, IFileService fileService, IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreatePageCommand request, CancellationToken cancellationToken)
        {
            if(request.ParentId != null)
            {
                var ParentPage = await _pageStructureRepository.GetByIdAsync(request.ParentId);
                if (ParentPage == null)
                {
                    return new BaseResponse<int>("", false, 404);
                }
            }
            var cellPages = _pageStructureRepository
                .Where(p => p.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells)
                .ToList();

            if(request.PageType != Domain.Constants.PageType.MainPageWithoutSubPage && request.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells)
            {
                return new BaseResponse<int>("لا يمكن إضافة هذه الصفحة الى الخلايا", false, 400);
            }

            if (cellPages.Count() >= 5)
            {
                return new BaseResponse<int>("لا يمكن إضافة أكثر من خمسة صفحات إلى الخلايا", false, 400);
            }

            var page = _mapper.Map<PageStructure>(request);

            if(request.Icon != null)
            {
                page.IconUrl = await _fileService.SaveFileAsync(request.Icon, SystemFileType.Icons);
            }

            var slug = request.Slug == null
                ? request.EnglishTitle
                : request.Slug;
            
            slug = slug.ToLower();
            page.Slug = slug.Replace(" ", "_");

            var data = await _pageStructureRepository.AddAsync(page);

            return new BaseResponse<int>("", true, 200, data.Id);

        }
    }
}
