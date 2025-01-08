using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsTickerModel;

namespace SharijhaAward.Application.Features.NewsTickerFeatures.Commands.DeleteNewsTicker
{
    public class DeleteNewsTickerHandler : IRequestHandler<DeleteNewsTickerCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<NewsTicker> _NewsTickerRepository;
        public DeleteNewsTickerHandler(IAsyncRepository<NewsTicker> _NewsTickerRepository)
        {
            this._NewsTickerRepository = _NewsTickerRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteNewsTickerCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            NewsTicker? NewsTickerEntityToDelete = await _NewsTickerRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (NewsTickerEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "News ticker is not found"
                    : "الشريط الإخباري غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _NewsTickerRepository.DeleteAsync(NewsTickerEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "News ticker has been deleted successfully"
                : "تم حذف الشريط الإخباري بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
