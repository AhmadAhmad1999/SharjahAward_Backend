using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById
{
    public class GetTrainingWorkshopByIdQueryHandler 
        : IRequestHandler<GetTrainingWorkshopByIdQuery, BaseResponse<TrainingWorkshopDto>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository;
        private readonly IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository;

        public GetTrainingWorkshopByIdQueryHandler(IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository,
            IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor,
            IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository)
        {
            this._TrainingWorkshopRepository = _TrainingWorkshopRepository;
            this._TrainingWorkshopAttachmentRepository = _TrainingWorkshopAttachmentRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._TrainingWorkshopAttachmentTypeRepository = _TrainingWorkshopAttachmentTypeRepository;
        }

        public async Task<BaseResponse<TrainingWorkshopDto>> Handle(GetTrainingWorkshopByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TrainingWorkshop? TrainingWorkshopEntity = await _TrainingWorkshopRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (TrainingWorkshopEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Training workshop is not found"
                    : "الورشة التدريبية غير موجودة";

                return new BaseResponse<TrainingWorkshopDto>(ResponseMessage, false, 404);
            }

            TrainingWorkshopDto Response = _Mapper.Map<TrainingWorkshopDto>(TrainingWorkshopEntity);

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<TrainingWorkshopAttachment> TrainingWorkshopAttachmentEntities = _TrainingWorkshopAttachmentRepository
                .Where(x => x.TrainingWorkshopId == Request.Id)
                .ToList();

            if (TrainingWorkshopAttachmentEntities.Any())
            {
                List<TrainingWorkshopAttachmentType> TrainingWorkshopAttachmentTypeEntities = _TrainingWorkshopAttachmentTypeRepository
                    .Where(x => TrainingWorkshopAttachmentEntities.Select(y => y.Id).Contains(x.TrainingWorkshopAttachmentId))
                    .ToList();

                Response.Attachments = TrainingWorkshopAttachmentEntities
                    .Select(x =>
                    {
                        return new WorkshopAttachmentListVM()
                        {
                            Id = x.Id,
                            ArabicName = x.ArabicName,
                            EnglishName = x.EnglishName,
                            Name = Request.lang == "en"
                                ? x.EnglishName
                                : x.ArabicName,
                            AttachementURl = x.AttachementPath.Contains("wwwroot")
                                ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.AttachementPath.Replace("\\", "/"),
                            SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                            AttachmentType = TrainingWorkshopAttachmentTypeEntities
                                .Where(y => y.TrainingWorkshopAttachmentId == x.Id)
                                .Select(y => y.AttachmentType)
                                .ToList()
                        };
                    }).ToList();
            }

            Response.Title = Request.lang == "en" 
                ? TrainingWorkshopEntity.EnglishTitle
                : TrainingWorkshopEntity.ArabicTitle;

            Response.Thumbnail = Response.Thumbnail.Contains("wwwroot")
                ? (WWWRootFilePath + Response.Thumbnail.Split("wwwroot")[1]).Replace("\\", "/")
                : Response.Thumbnail.Replace("\\", "/");

            return new BaseResponse<TrainingWorkshopDto>(ResponseMessage, true, 200, Response);
        }
    }
}
