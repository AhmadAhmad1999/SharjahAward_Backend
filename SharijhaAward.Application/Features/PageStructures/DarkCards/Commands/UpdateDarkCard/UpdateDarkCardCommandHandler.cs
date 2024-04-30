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

namespace SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.UpdateDarkCard
{
    public class UpdateDarkCardCommandHandler
        : IRequestHandler<UpdateDarkCardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DarkCard> _darkCardRepository;
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;
        private readonly IMapper _mapper;

        public UpdateDarkCardCommandHandler(IAsyncRepository<DarkCard> darkCardRepository, IAsyncRepository<PageStructure> pageStructureRepository, IMapper mapper)
        {
            _darkCardRepository = darkCardRepository;
            _pageStructureRepository = pageStructureRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateDarkCardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                       ? "Dark Card has been Updated"
                       : "تم تعديل العنصر ";

            var darkCard = await _darkCardRepository.GetByIdAsync(request.Id);
            if (darkCard == null)
            {
                msg = request.lang == "en"
                    ? "Dark Card Not Found"
                    : "العنصر غير وجود ";

                return new BaseResponse<object>(msg, false, 404);
            }

            var page = await _pageStructureRepository.GetByIdAsync(request.PageId);
            if (page == null)
            {
                msg = request.lang == "en"
                    ? "Page Not found"
                    : "الصفحة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, darkCard, typeof(UpdateDarkCardCommand), typeof(DarkCard));

            await _darkCardRepository.UpdateAsync(darkCard);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
