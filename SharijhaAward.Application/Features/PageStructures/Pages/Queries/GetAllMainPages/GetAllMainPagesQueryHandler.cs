using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetAllMainPages
{
    public class GetAllMainPagesQueryHandler
        : IRequestHandler<GetAllMainPagesQuery, BaseResponse<List<MainPageListVM>>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public GetAllMainPagesQueryHandler(IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<MainPageListVM>>> Handle(GetAllMainPagesQuery request, CancellationToken cancellationToken)
        {
            var mainPages = _pageStructureRepository.Where(p => p.ParentId == null).ToList();

            var subPages = _pageStructureRepository.Where(p => p.ParentId != null).ToList();
            
            var MainPages = _mapper.Map<List<MainPageListVM>>(mainPages);

            List<PageStructure> pages = new List<PageStructure>();

            foreach (var page in MainPages)
            {
                pages.Clear();
                page.Title = request.lang == "en" ? page.EnglishTitle : page.ArabicTitle;

                foreach (var subPage in subPages)
                {
                    if(page.Id == subPage.ParentId)
                    {
                        pages.Add(subPage);
                    }
                }
                var SubPages = _mapper.Map<List<SubPageListVM>>(pages);

                foreach(var subPage in SubPages)
                {
                    subPage.Title = request.lang == "en" ? subPage.EnglishTitle : subPage.ArabicTitle;
                }

                page.SubPages = SubPages;
            }
             
            return new BaseResponse<List<MainPageListVM>>("", true, 200, MainPages);
        }
    }
}
