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

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.UpdatePage
{
    public class UpdatePageCommandHandler
        : IRequestHandler<UpdatePageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdatePageCommandHandler(IAsyncRepository<PageStructure> pageStructureRepository, IFileService fileService, IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdatePageCommand request, CancellationToken cancellationToken)
        {
            var page = await _pageStructureRepository.GetByIdAsync(request.Id);
            if(page == null)
            {
                return new BaseResponse<object>("", false, 404);
            }

            var Icon = page.IconUrl;

            if (request.PageType != Domain.Constants.PageType.MainPageWithoutSubPage && request.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells)
            {
                return new BaseResponse<object>("لا يمكن إضافة هذه الصفحة الى الخلايا", false, 400);
            }

            _mapper.Map(request, page, typeof(UpdatePageCommand), typeof(PageStructure));

            if (request.UpdateOnIcon != null && request.UpdateOnIcon == true)
                page.IconUrl = await _fileService.SaveFileAsync(request.Icon!, SystemFileType.Icons);
            else
                page.IconUrl = Icon;


            await _pageStructureRepository.UpdateAsync(page);

            string ResponseMessage = request.lang == "en"
                ? "Updated successfully"
                : "تم تعديل الصفحة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
