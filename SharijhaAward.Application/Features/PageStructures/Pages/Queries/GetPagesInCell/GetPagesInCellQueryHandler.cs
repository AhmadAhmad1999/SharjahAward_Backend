using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPages;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPagesInCell
{
    public class GetPagesInCellQueryHandler
        : IRequestHandler<GetPagesInCellQuery, BaseResponse<List<MainPageListVM>>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public GetPagesInCellQueryHandler(IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<MainPageListVM>>> Handle(GetPagesInCellQuery request, CancellationToken cancellationToken)
        {
            var mainPages = await _pageStructureRepository
                     .GetWhereThenPagedReponseAsync(
                             p => p.ParentId == null
                         && !p.IsHide
                         &&  p.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells,
                             request.page, request.perPage);

            var data = _mapper.Map<List<MainPageListVM>>(mainPages).OrderBy(p => p.orderId).ToList();

            foreach (var page in data)
            {
                page.numberOfSubPages = _pageStructureRepository.GetCount(p => p.ParentId == page.Id && !p.isDeleted);

                page.Title = request.lang == "en" ? page.EnglishTitle : page.ArabicTitle;
            }

            int TotalCount = await _pageStructureRepository
                .GetCountAsync(p => p.ParentId == null && !p.isDeleted);

            Pagination pagination = new Pagination(request.page,
                request.perPage, TotalCount);

            return new BaseResponse<List<MainPageListVM>>("", true, 200, data, pagination);
        }
    }
}
