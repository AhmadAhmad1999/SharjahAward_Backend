using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsTickerModel;

namespace SharijhaAward.Application.Features.NewsTickerFeatures.Commands.CreateNewsTicker
{
    public class CreateNewsTickerHandler : IRequestHandler<CreateNewsTickerCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<NewsTicker> _NewsTickerRepository;

        public CreateNewsTickerHandler(IMapper Mapper,
            IAsyncRepository<NewsTicker> _NewsTickerRepository)
        {
            _Mapper = Mapper;
            this._NewsTickerRepository = _NewsTickerRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateNewsTickerCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            NewsTicker NewNewsTickerEntity = _Mapper.Map<NewsTicker>(Request);

            await _NewsTickerRepository.AddAsync(NewNewsTickerEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء الشريط الإخباري بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
