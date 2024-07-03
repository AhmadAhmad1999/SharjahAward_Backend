using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetAllTextCard
{
    public class GetAllTextCardsQueryHandler
        : IRequestHandler<GetAllTextCardsQuery, BaseResponse<List<TextCardListVM>>>
    {
        private readonly IAsyncRepository<TextCard> _textCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public GetAllTextCardsQueryHandler(IAsyncRepository<TextCard> textCardRepository, IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _textCardRepository = textCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<TextCardListVM>>> Handle(GetAllTextCardsQuery request, CancellationToken cancellationToken)
        {
            var textCards = request.pageId == null
                ? await _textCardRepository.GetPagedReponseAsync(request.page, request.perPage)
                : await _textCardRepository.GetPagedReponseWithPredicateAsync(t => t.PageStructureId == request.pageId, request.page, request.perPage);
    
            var data = _mapper.Map<List<TextCardListVM>>(textCards);

            return new BaseResponse<List<TextCardListVM>>("", true, 200, data);
        }
    }
}
