using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId
{
    public class GetWorkShopsByCategoryIdQueryHandler
        : IRequestHandler<GetWorkShopsByCategoryIdQuery, BaseResponse<List<TrainingWorkshopListVm>>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository;
        private readonly IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository;

        public GetWorkShopsByCategoryIdQueryHandler(IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository,
            IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository,
            IAsyncRepository<Category> _CategoryRepository, 
            IHttpContextAccessor _HttpContextAccessor,
            IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository)
        {
            this._TrainingWorkshopRepository = _TrainingWorkshopRepository;
            this._TrainingWorkshopAttachmentRepository = _TrainingWorkshopAttachmentRepository;
            this._CategoryRepository = _CategoryRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._TrainingWorkshopAttachmentTypeRepository = _TrainingWorkshopAttachmentTypeRepository;
        }

        public async Task<BaseResponse<List<TrainingWorkshopListVm>>> Handle(GetWorkShopsByCategoryIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            Category? CategoryEntity = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CategoryEntity is null) 
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<List<TrainingWorkshopListVm>>(ResponseMessage, false, 404);
            }

            List<TrainingWorkshop> TrainingWorkshopEntities = await _TrainingWorkshopRepository
                .WhereThenInclude(x => x.CategoryId == Request.CategoryId, FilterObject)
                .OrderByDescending(x => x.CreatedAt)
                .Skip((Request.page - 1) * Request.perPage)
                .Take(Request.perPage)
                .ToListAsync();

            List<TrainingWorkshopAttachment> TrainingWorkshopAttachmentEntities = await _TrainingWorkshopAttachmentRepository
                .Where(x => TrainingWorkshopEntities.Select(y => y.Id).Contains(x.TrainingWorkshopId))
                .ToListAsync();

            List<TrainingWorkshopAttachmentType> TrainingWorkshopAttachmentTypeEntities = _TrainingWorkshopAttachmentTypeRepository
                .Where(x => TrainingWorkshopAttachmentEntities.Select(y => y.Id).Contains(x.TrainingWorkshopAttachmentId))
                .ToList();

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

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
                    Attachments = TrainingWorkshopAttachmentEntities
                        .Where(y => y.TrainingWorkshopId == x.Id)
                        .Select(y => new WorkshopAttachmentListVM()
                        {
                            Id = y.Id,
                            ArabicName = y.ArabicName,
                            EnglishName = y.EnglishName,
                            Name = Request.lang == "en"
                                ? y.EnglishName
                                : y.ArabicName,
                            AttachementURl = y.AttachementPath.Contains("wwwroot")
                                ? (WWWRootFilePath + y.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                : y.AttachementPath.Replace("\\", "/"),
                            AttachmentType = TrainingWorkshopAttachmentTypeEntities
                                .Where(z => z.TrainingWorkshopAttachmentId == y.Id)
                                .Select(z => z.AttachmentType)
                                .ToList(),
                            SizeOfAttachmentInKB = y.SizeOfAttachmentInKB
                        }).ToList()
                }).ToList();

            int TotalCount = await _TrainingWorkshopRepository
                .WhereThenInclude(x => x.CategoryId == Request.CategoryId, FilterObject)
                .CountAsync();
                
            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);
               
            return new BaseResponse<List<TrainingWorkshopListVm>>(string.Empty, true, 200, Response, Pagination);
        }
    }
}
