using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachmentByFormId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;

namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachment
{
    public class GetAllExtraAttachmentByFormIdQueryHandler
        : IRequestHandler<GetAllExtraAttachmentByFormIdQuery, BaseResponse<List<ExtraAttachmentListVM>>>
    {
        private readonly IAsyncRepository<ExtraAttachment> _ExtraAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<ExtraAttachmentFile> _ExtraAttachmentFileRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<ExtraAttachmentAttachmentType> _ExtraAttachmentAttachmentTypeRepository;

        public GetAllExtraAttachmentByFormIdQueryHandler(IAsyncRepository<ExtraAttachmentFile> _ExtraAttachmentFileRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository,
            IAsyncRepository<ExtraAttachment> _ExtraAttachmentRepository, 
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor,
            IAsyncRepository<ExtraAttachmentAttachmentType> _ExtraAttachmentAttachmentTypeRepository)
        {
            this._ExtraAttachmentRepository = _ExtraAttachmentRepository;
            this._ExtraAttachmentFileRepository = _ExtraAttachmentFileRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._ExtraAttachmentAttachmentTypeRepository = _ExtraAttachmentAttachmentTypeRepository;
        }

        public async Task<BaseResponse<List<ExtraAttachmentListVM>>> Handle(GetAllExtraAttachmentByFormIdQuery Request, CancellationToken cancellationToken)
        {
            List<ExtraAttachment> ExtraAttachmentEntities = await _ExtraAttachmentRepository
                .Where(x => x.ProvidedFormId == Request.formId &&
                    x.isAccepted != Request.GetOnlyTheRequests)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            List<ExtraAttachmentFile> ExtraAttachmentFileEntitites = await _ExtraAttachmentFileRepository
                .Where(x => ExtraAttachmentEntities.Select(y => y.Id).Contains(x.ExtraAttachmentId))
                .ToListAsync();

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<ExtraAttachmentAttachmentType> ExtraAttachmentAttachmentTypeEntities = _ExtraAttachmentAttachmentTypeRepository
                .Where(x => x.ExtraAttachment!.ProvidedFormId == Request.formId)
                .ToList();

            List<ExtraAttachmentListVM> Response = ExtraAttachmentEntities
                .Select(x => new ExtraAttachmentListVM()
                {
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                    ArabicDescription = x.ArabicDescription,
                    ArabicTitle = x.ArabicTitle,
                    AttachmentList = ExtraAttachmentFileEntitites
                        .Where(y => y.ExtraAttachmentId == x.Id)
                        .Select(y => new AttachmentDto()
                        {
                            Id = y.Id,
                            FileDescription = y.FileDescription,
                            FileName = y.FileName,
                            FileUrl = y.FileUrl.Contains("wwwroot")
                                ? (WWWRootFilePath + y.FileUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                : y.FileUrl.Replace("\\", "/"),
                            IsAccept = y.IsAccept,
                            ReasonOfReject = y.ReasonOfReject
                        }).ToList(),
                    AttachmentType = ExtraAttachmentAttachmentTypeEntities
                        .Where(y => y.ExtraAttachmentId == x.Id)
                        .Select(y => y.AttachmentType)
                        .ToList(),
                    Description = Request.lang == "en"
                        ? x.EnglishDescription
                        : x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    EnglishTitle = x.EnglishTitle,
                    Id = x.Id,
                    RequiredAttachmentNumber = x.RequiredAttachmentNumber,
                    Title = Request.lang == "en" 
                        ? x.EnglishTitle 
                        : x.ArabicTitle,
                    Rejected = ExtraAttachmentFileEntitites.Any(y => y.IsAccept == false)
                        ? true : false
                }).ToList();

            return new BaseResponse<List<ExtraAttachmentListVM>>(string.Empty, true, 200, Response);
        }
    }
}
