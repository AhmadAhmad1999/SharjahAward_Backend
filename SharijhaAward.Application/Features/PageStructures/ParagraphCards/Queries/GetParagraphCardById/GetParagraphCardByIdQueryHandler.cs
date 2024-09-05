using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetDarkCardById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetParagraphCardById
{
    public class GetParagraphCardByIdQueryHandler
        : IRequestHandler<GetParagraphCardByIdQuery, BaseResponse<ParagraphCardDto>>
    {
        private readonly IAsyncRepository<PageCard> _paragraphCardRepository;
        private readonly IMapper _mapper;

        public GetParagraphCardByIdQueryHandler(IAsyncRepository<PageCard> paragraphCardRepository, IMapper mapper)
        {
            _paragraphCardRepository = paragraphCardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ParagraphCardDto>> Handle(GetParagraphCardByIdQuery request, CancellationToken cancellationToken)
        {
            var ParagraphCard = await _paragraphCardRepository.GetByIdAsync(request.Id);
            if (ParagraphCard == null)
            {
                string msg = request.lang == "en"
                       ? "Dark Card Not Found"
                       : "العنصر غير وجود ";

                return new BaseResponse<ParagraphCardDto>(msg, false, 404);
            }

            var data = _mapper.Map<ParagraphCardDto>(ParagraphCard);

            data.Title = request.lang == "en" ? data.EnglishTitle : data.ArabicTitle;
            data.Content = request.lang == "en" ? data.EnglishContent : data.ArabicContent;

            return new BaseResponse<ParagraphCardDto>("", true, 200, data);
        }
    }
}
