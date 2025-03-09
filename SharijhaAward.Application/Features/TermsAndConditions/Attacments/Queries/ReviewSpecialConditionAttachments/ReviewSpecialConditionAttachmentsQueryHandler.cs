using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Queries.ReviewSpecialConditionAttachments
{
    public class ReviewSpecialConditionAttachmentsQueryHandler
        : IRequestHandler<ReviewSpecialConditionAttachmentsQuery, BaseResponse<List<SpecialTermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _ConditionsProvidedFormsRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public ReviewSpecialConditionAttachmentsQueryHandler(IAsyncRepository<TermAndCondition> _TermAndConditionRepository,
            IAsyncRepository<ConditionsProvidedForms> _ConditionsProvidedFormsRepository, 
            IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository, 
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository, 
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._ConditionsProvidedFormsRepository = _ConditionsProvidedFormsRepository;
            this._ConditionAttachmentRepository = _ConditionAttachmentRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<SpecialTermAndConditionListVM>>> 
            Handle(ReviewSpecialConditionAttachmentsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.formId);

            if (ProvidedFormEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Form is not found"
                    : "الإستمارة غير موجودة";

                return new BaseResponse<List<SpecialTermAndConditionListVM>>(ResponseMessage, false, 404);
            }

            List<TermAndCondition> TermAndConditionEntities = await _TermAndConditionRepository
                .Where(x => x.CategoryId == ProvidedFormEntity.categoryId)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            List<ConditionsProvidedForms> ConditionsProvidedFormsEntities = await _ConditionsProvidedFormsRepository
                .Where(x => x.ProvidedFormId == ProvidedFormEntity!.Id &&
                    TermAndConditionEntities.Select(y => y.Id).Contains(x.TermAndConditionId))
                .ToListAsync();

            List<ConditionAttachment> AllConditionAttachmentEntities = await _ConditionAttachmentRepository
                .Where(x => ConditionsProvidedFormsEntities.Select(y => y.Id).Any(y => y == x.ConditionsProvidedFormsId))
                .ToListAsync();

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<SpecialTermAndConditionListVM> Response = TermAndConditionEntities
                .Select(x => new SpecialTermAndConditionListVM()
                {
                    Id = x.Id,
                    Description = Request.lang == "en"
                        ? x.EnglishDescription
                        : x.ArabicDescription,
                    ArabicDescription = x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    NeedAttachment = x.NeedAttachment,
                    RequiredAttachmentNumber = x.RequiredAttachmentNumber,
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                    //AttachmentType = x.AttachmentType,
                    CategoryId = x.CategoryId,
                    CreateAt = x.CreatedAt,
                    Acceptance = ConditionsProvidedFormsEntities
                        .Where(y => x.Id == y.TermAndConditionId)
                        .Select(y => new ConditionProvidedFormListVm()
                        {
                            IsAgree = y.IsAgree,
                            TermAndConditionId = y.TermAndConditionId,
                            ProvidedFormId = y.ProvidedFormId
                        }).FirstOrDefault(),
                    Attachments = AllConditionAttachmentEntities
                        .Where(y => y.ConditionsProvidedForms!.TermAndConditionId == x.Id)
                        .Select(y => new AttachmentListVM()
                        {
                            Id = y.Id,
                            Name = y.Name,
                            Description = y.Description,
                            AttachementPath = y.AttachementPath.Contains("wwwroot")
                                ? (WWWRootFilePath + y.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                : y.AttachementPath.Replace("\\", "/"),
                            SizeOfAttachmentInKB = y.SizeOfAttachmentInKB,
                            IsAccept = y.IsAccept,
                            ReasonOfReject = y.ReasonOfReject
                        }).ToList()
                }).ToList();

            return new BaseResponse<List<SpecialTermAndConditionListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}
