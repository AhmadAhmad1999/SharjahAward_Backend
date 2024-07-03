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

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards
{
    public class GetAllImageCardsQueryHandler
        : IRequestHandler<GetAllImageCardsQuery, BaseResponse<List<ImageCardListVM>>>
    {
        private readonly IAsyncRepository<ImageCard> _imageCardsRepository;
        private readonly IMapper _mapper;

        public GetAllImageCardsQueryHandler(IAsyncRepository<ImageCard> imageCardsRepository, IMapper mapper)
        {
            _imageCardsRepository = imageCardsRepository;
            _mapper = mapper;
        }

        public Task<BaseResponse<List<ImageCardListVM>>> Handle(GetAllImageCardsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
