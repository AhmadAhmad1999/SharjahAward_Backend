using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetAllGeneralWorkshops
{
    public class GetAllGeneralWorkshopsQueryHandler
        : IRequestHandler<GetAllGeneralWorkshopsQuery, BaseResponse<List<GeneralWorkshopsListVM>>>
    {
        private readonly IAsyncRepository<GeneralWorkshop> _generalWorkshopRepository;
        private readonly IMapper _mapper;

        public GetAllGeneralWorkshopsQueryHandler(IAsyncRepository<GeneralWorkshop> generalWorkshopRepository, IMapper mapper)
        {
            _generalWorkshopRepository = generalWorkshopRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<GeneralWorkshopsListVM>>> Handle(GetAllGeneralWorkshopsQuery request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            var generalWorkshops = await _generalWorkshopRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, request.page, request.perPage)
                .ToListAsync();
           
            if (!request.query.IsNullOrEmpty())
            {
                generalWorkshops = await _generalWorkshopRepository
                    .Where(n => n.EnglishTitle.ToLower().Contains(request.query!.ToLower()))
                    .OrderByDescending(x => x.CreatedAt).ToListAsync();

                if (generalWorkshops.Count() == 0)
                {
                    generalWorkshops = await _generalWorkshopRepository
                        .Where(n => n.ArabicTitle.ToLower().Contains(request.query!.ToLower()))
                        .OrderByDescending(x => x.CreatedAt).ToListAsync();
                }
            }

            var data = _mapper.Map<List<GeneralWorkshopsListVM>>(generalWorkshops);
            if (generalWorkshops.Count() > 0)
            {
                

                for(int i = 0; i < data.Count(); i++)
                {
                    data[i].Title = request.lang == "en"
                        ? data[i].EnglishTitle
                        : data[i].ArabicTitle;

                    data[i].Description = request.lang == "en"
                        ? data[i].EnglishDescription
                        : data[i].ArabicDescription;
                }
            }
            int count = await _generalWorkshopRepository.GetCountAsync(g => !g.isDeleted);

            Pagination pagination = new Pagination(request.page, request.perPage, count);

            return new BaseResponse<List<GeneralWorkshopsListVM>>("", true, 200, data, pagination);
        }
    }
}
