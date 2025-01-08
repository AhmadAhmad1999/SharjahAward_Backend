using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsTickerModel;

namespace SharijhaAward.Application.Features.NewsTickerFeatures.Queries.GetNewsTickerById
{
    public class GetNewsTickerByIdHandler : IRequestHandler<GetNewsTickerByIdQuery, BaseResponse<GetNewsTickerByIdDto>>
    {
        private readonly IAsyncRepository<NewsTicker> _NewsTickerRepository;
        private readonly IMapper _Mapper;
        public GetNewsTickerByIdHandler(IAsyncRepository<NewsTicker> _NewsTickerRepository,
            IMapper Mapper)
        {
            this._NewsTickerRepository = _NewsTickerRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetNewsTickerByIdDto>> Handle(GetNewsTickerByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            NewsTicker? NewsTickerEntity = await _NewsTickerRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (NewsTickerEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "News ticker is not found"
                    : "الشريط الإخباري غير موجود";

                return new BaseResponse<GetNewsTickerByIdDto>(ResponseMessage, false, 404);
            }

            GetNewsTickerByIdDto GetNewsTickerByIdDto = _Mapper.Map<GetNewsTickerByIdDto>(NewsTickerEntity);

            return new BaseResponse<GetNewsTickerByIdDto>(ResponseMessage, true, 200, GetNewsTickerByIdDto);
        }
    }
}
