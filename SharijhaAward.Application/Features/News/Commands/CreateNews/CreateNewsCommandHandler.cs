using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Commands.CreateNews
{
    public class CreateNewsCommandHandler
        : IRequestHandler<CreateNewsCommand , BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public CreateNewsCommandHandler(IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {
            var cycle = await _cycleRepository.GetByIdAsync(request.CycleId);
            string msg;

            if (cycle == null)
            {
                 msg = request.lang == "en"
                  ?  "Cycle is not Found"
                  :  "الدورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            if (cycle.Status == Domain.Constants.Common.Status.Close)
            {
                msg = request.lang == "en"
                    ? "The Status of Cycle is Close"
                    : "حالة الدورة مغلقة";

                return new BaseResponse<object>(msg, false, 400);
            }
            var news = _mapper.Map<Domain.Entities.NewsModel.News>(request);

            await _newsRepository.AddAsync(news);

             msg = request.lang == "en"
                ? "Created Succsess"
                : "تم إنشاء الخبر بنجاح";

             return new BaseResponse<object>(msg, true, 200);
        }
    }
}
