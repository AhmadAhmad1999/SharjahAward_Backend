using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops
{
    public class GetAllTrainingWorkshopQueryHandler
        : IRequestHandler<GetAllTrainingWorkshopsQuery, BaseResponse<List<TrainingWorkshopListVm>>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllTrainingWorkshopQueryHandler(IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._TrainingWorkshopRepository = _TrainingWorkshopRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<TrainingWorkshopListVm>>> Handle(GetAllTrainingWorkshopsQuery Request, CancellationToken cancellationToken)
        {
            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<TrainingWorkshop> TrainingWorkshopEntities = await _TrainingWorkshopRepository
                .OrderByDescending(x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync();

            List<TrainingWorkshopListVm> Response = TrainingWorkshopEntities
                .Select(x => new TrainingWorkshopListVm()
                {
                    Id = x.Id,
                    Title = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    Thumbnail = x.Thumbnail.Contains("wwwroot")
                        ? (WWWRootFilePath + x.Thumbnail.Split("wwwroot")[1]).Replace("\\", "/")
                        : x.Thumbnail.Replace("\\", "/"),
                    ArabicTitle = x.ArabicTitle,
                    EnglishTitle = x.EnglishTitle,
                    CreatedAt = x.CreatedAt,
                    Attachments = new List<GetWorkShopsByCategoryId.WorkshopAttachmentListVM>()
                }).ToList();

            int TotalCount = await _TrainingWorkshopRepository.GetCountAsync(x => true);

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<TrainingWorkshopListVm>>(string.Empty, true, 200, Response, Pagination);
        }
    }
}
