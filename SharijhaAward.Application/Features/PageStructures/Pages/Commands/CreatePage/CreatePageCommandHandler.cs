using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.CreatePage
{
    public class CreatePageCommandHandler
        : IRequestHandler<CreatePageCommand, BaseResponse<object>>
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

        public async Task<BaseResponse<object>> Handle(CreatePageCommand request, CancellationToken cancellationToken)
        {
            var ParentPage = await _pageStructureRepository.GetByIdAsync(request.ParentId);
            if(ParentPage == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            var page = _mapper.Map<PageStructure>(request);

            if(request.Icon != null)
            {
                page.IconUrl = await _fileService.SaveFileAsync(request.Icon);
            }

            await _pageStructureRepository.AddAsync(page);

            return new BaseResponse<object>("", true, 200);

        }
    }
}
