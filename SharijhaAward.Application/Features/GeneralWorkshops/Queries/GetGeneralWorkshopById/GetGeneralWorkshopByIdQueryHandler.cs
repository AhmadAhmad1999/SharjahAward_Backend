using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetGeneralWorkshopById
{
    public class GetGeneralWorkshopByIdQueryHandler
        : IRequestHandler<GetGeneralWorkshopByIdQuery, BaseResponse<GeneralWorkshopDto>>
    {
        private readonly IAsyncRepository<GeneralWorkshop> _generalWorkshopRepository;
        private readonly IMapper _mapper;

        public GetGeneralWorkshopByIdQueryHandler(IAsyncRepository<GeneralWorkshop> generalWorkshopRepository, IMapper mapper)
        {
            _generalWorkshopRepository = generalWorkshopRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<GeneralWorkshopDto>> Handle(GetGeneralWorkshopByIdQuery request, CancellationToken cancellationToken)
        {
            var WorkShop = await _generalWorkshopRepository.GetByIdAsync(request.Id);
          
            if (WorkShop == null)
            {
                return new BaseResponse<GeneralWorkshopDto>("", false, 404);
            }

            var data = _mapper.Map<GeneralWorkshopDto>(WorkShop);

            data.Title = request.lang == "en"
                ? data.EnglishTitle
                : data.ArabicTitle;

            data.Description = request.lang == "en"
                ? data.EnglishDescription
                : data.ArabicDescription;

            return new BaseResponse<GeneralWorkshopDto>("", true, 200, data);
        }
    }
}
