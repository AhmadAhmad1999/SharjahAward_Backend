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

namespace SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.CreateDarkCard
{
    public class CreateDarkCardCommandHandler
        : IRequestHandler<CreateDarkCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PageCard> _darkCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public CreateDarkCardCommandHandler(IAsyncRepository<PageCard> darkCardRepository, IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _darkCardRepository = darkCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateDarkCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Dark Card has been Created"
                : "تم إنشاء العنصر ";

            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);
           
            if(page == null)
            {
                msg = request.lang == "en"
                ? "Page Not found"
                : "الصفحة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var DarkCard = _mapper.Map<PageCard>(request);

            DarkCard.CardType = CardType.DarkCard;

            await _darkCardRepository.AddAsync(DarkCard);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
