using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsTickerModel;

namespace SharijhaAward.Application.Features.NewsTickerFeatures.Commands.UpdateNewsTicker
{
    public class UpdateNewsTickerHandler : IRequestHandler<UpdateNewsTickerCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<NewsTicker> _NewsTickerRepository;
        private readonly IMapper _Mapper;

        public UpdateNewsTickerHandler(IMapper Mapper,
            IAsyncRepository<NewsTicker> NewsTickerRepository)
        {
            _NewsTickerRepository = NewsTickerRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateNewsTickerCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            NewsTicker? NewsTickerEntityToUpdate = await _NewsTickerRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (NewsTickerEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "News ticker is not found"
                    : "الشريط الإخباري غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, NewsTickerEntityToUpdate, typeof(UpdateNewsTickerCommand), typeof(NewsTicker));

            await _NewsTickerRepository.UpdateAsync(NewsTickerEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "News ticker has been updated successfully"
                : "تم تعديل الشريط الإخباري بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}