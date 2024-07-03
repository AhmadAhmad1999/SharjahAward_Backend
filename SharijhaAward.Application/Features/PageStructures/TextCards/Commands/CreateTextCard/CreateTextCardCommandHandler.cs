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

namespace SharijhaAward.Application.Features.PageStructures.TextCards.Commands.CreateTextCard
{
    public class CreateTextCardCommandHandler
        : IRequestHandler<CreateTextCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TextCard> _textCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public CreateTextCardCommandHandler(IAsyncRepository<TextCard> textCardRepository, IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _textCardRepository = textCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateTextCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Text Card has been Created"
                : "تم إنشاء بطاقة نص";

            var page = await _pageStructureRepository.GetByIdAsync(request.PageStructureId);
            
            if(page == null)
            {
                msg = request.lang == "en"
                ? "Page not found"
                : "الصفحة غير موجودة";

                return new BaseResponse<object>(msg, false, 400);
            }

            var textCard = _mapper.Map<TextCard>(request);

            await _textCardRepository.AddAsync(textCard);

            return new BaseResponse<object>(msg, true, 200);
            
        }
    }
}
