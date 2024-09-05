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

namespace SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetTextCardById
{
    public class GetTextCardByIdQueryHandler
        : IRequestHandler<GetTextCardByIdQuery, BaseResponse<TextCardDto>>
    {
        private readonly IAsyncRepository<PageCard> _textCardRepository;
        private readonly IMapper _mapper;

        public GetTextCardByIdQueryHandler(IAsyncRepository<PageCard> textCardRepository, IMapper mapper)
        {
            _textCardRepository = textCardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<TextCardDto>> Handle(GetTextCardByIdQuery request, CancellationToken cancellationToken)
        {
            var textCard = await _textCardRepository.GetByIdAsync(request.Id);
           
            if (textCard == null)
            {
               string msg = request.lang == "en"
                ? "Text Card not Found"
                : " بطاقة النص غير موجودة";

                return new BaseResponse<TextCardDto>(msg, false, 404);
            }

            var data = _mapper.Map<TextCardDto>(textCard);

            return new BaseResponse<TextCardDto>("", true, 200, data);
        }
    }
}
