using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetDarkCardById
{
    public class GetDarkCardByIdQueryHandler
        : IRequestHandler<GetDarkCardByIdQuery, BaseResponse<DarkCardDto>>
    {
        private readonly IAsyncRepository<PageCard> _darkCardRepository;
        private readonly IMapper _mapper;

        public GetDarkCardByIdQueryHandler(IAsyncRepository<PageCard> darkCardRepository, IMapper mapper)
        {
            _darkCardRepository = darkCardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<DarkCardDto>> Handle(GetDarkCardByIdQuery request, CancellationToken cancellationToken)
        {
            var DarkCard = await _darkCardRepository.GetByIdAsync(request.Id);
            if (DarkCard == null)
            {
                string msg = request.lang == "en"
                       ? "Dark Card Not Found"
                       : "العنصر غير وجود ";

                return new BaseResponse<DarkCardDto>(msg, false, 404);
            }

            var data = _mapper.Map<DarkCardDto>(DarkCard);

            data.Title = request.lang == "en" ? data.EnglishTitle : data.ArabicTitle;
            data.Content = request.lang == "en" ? data.EnglishContent : data.ArabicContent;

            return new BaseResponse<DarkCardDto>("", true, 200, data);
        }
    }
}
