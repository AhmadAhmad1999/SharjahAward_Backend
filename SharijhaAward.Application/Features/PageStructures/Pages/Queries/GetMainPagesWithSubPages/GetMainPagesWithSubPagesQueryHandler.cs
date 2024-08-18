using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.PageStructureModel;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPagesWithSubPages
{
    public class GetMainPagesWithSubPagesQueryHandler
        : IRequestHandler<GetMainPagesWithSubPagesQuery, BaseResponse<List<MainPageWithSubPageListVM>>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public GetMainPagesWithSubPagesQueryHandler(IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<MainPageWithSubPageListVM>>> Handle(GetMainPagesWithSubPagesQuery request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            var mainPages = await _pageStructureRepository
                    .GetWhereThenPagedReponseAsync(p => p.ParentId == null, filterObject, request.page, request.perPage);

            var subPages = await _pageStructureRepository.Where(p => p.ParentId != null).ToListAsync();
            
            var MainPages = _mapper.Map<List<MainPageWithSubPageListVM>>(mainPages);

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

            int TotalCount = await _pageStructureRepository
                .GetCountAsync(p => p.ParentId == null);

            Pagination PaginationParameter = new Pagination(request.page,
                request.perPage, TotalCount);

            return new BaseResponse<List<MainPageWithSubPageListVM>>("", true, 200, MainPages, PaginationParameter);
        }
    }
}
