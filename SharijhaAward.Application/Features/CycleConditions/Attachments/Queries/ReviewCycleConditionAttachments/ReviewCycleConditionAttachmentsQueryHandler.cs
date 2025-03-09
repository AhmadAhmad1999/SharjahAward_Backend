using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

namespace SharijhaAward.Application.Features.CycleConditions.Attachments.Queries.ReviewCycleConditionAttachments
{
    public class ReviewCycleConditionAttachmentsQueryHandler
        : IRequestHandler<ReviewCycleConditionAttachmentsQuery, BaseResponse<List<CycleConditionListVM>>>
    {
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<CycleCondition> _CycleConditionRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _CycleConditionsProvidedFormRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository;

        public ReviewCycleConditionAttachmentsQueryHandler(IAsyncRepository<Cycle> _CycleRepository,
            IAsyncRepository<CycleCondition> _CycleConditionRepository,
            IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository, 
            IAsyncRepository<CycleConditionsProvidedForm> _CycleConditionsProvidedFormRepository, 
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository, 
            IHttpContextAccessor _HttpContextAccessor,
            IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository)
        {
            this._CycleRepository = _CycleRepository;
            this._CycleConditionRepository = _CycleConditionRepository;
            this._CycleConditionAttachmentRepository = _CycleConditionAttachmentRepository;
            this._CycleConditionsProvidedFormRepository = _CycleConditionsProvidedFormRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._CycleConditionAttachmentTypeRepository = _CycleConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<List<CycleConditionListVM>>> Handle(ReviewCycleConditionAttachmentsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CycleEntity = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            if (CycleEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Cycle is not found"
                    : "الدورة غير موجودة";

                return new BaseResponse<List<CycleConditionListVM>>(ResponseMessage, false, 404);
            }

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = _ProvidedFormRepository
                .FirstOrDefault(x => x.Id == Request.formId);

            if (ProvidedFormEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Form is not found"
                    : "الإستمارة غير موجودة";

                return new BaseResponse<List<CycleConditionListVM>>(ResponseMessage, false, 404);
            }

            List<CycleCondition> CycleConditionEntities = await _CycleConditionRepository
                .WhereThenInclude(x => x.CycleId == CycleEntity.Id)
                .ToListAsync();

            List<CycleConditionAttachmentType> CycleConditionAttachmentTypeEntities = await _CycleConditionAttachmentTypeRepository
                .Where(x => CycleConditionEntities.Select(y => y.Id).Contains(x.CycleConditionId))
                .ToListAsync();

            List<CycleConditionsProvidedForm> CycleConditionsProvidedFormEntities = await _CycleConditionsProvidedFormRepository
                .Where(x => CycleConditionEntities.Select(y => y.Id).Contains(x.CycleConditionId) &&
                    x.ProvidedFormId == ProvidedFormEntity.Id)
                .ToListAsync();

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<CycleConditionAttachment> CycleConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                .Where(x => CycleConditionsProvidedFormEntities.Select(y => y.Id)
                    .Any(y => y == x.CycleConditionsProvidedFormId))
                .ToListAsync();

            List<CycleConditionListVM> Response = CycleConditionEntities
                .Select(x =>
                {
                    return new CycleConditionListVM()
                    {
                        Acceptance = CycleConditionsProvidedFormEntities
                            .Any(y => y.ProvidedFormId == ProvidedFormEntity.Id && y.CycleConditionId == x.Id)
                                ? CycleConditionsProvidedFormEntities
                                    .Where(y => y.ProvidedFormId == ProvidedFormEntity.Id &&
                                        y.CycleConditionId == x.Id)
                                    .Select(y => new CycleConditionProvidedFormListVm()
                                    {
                                        ProvidedFormId = y.ProvidedFormId,
                                        IsAgree = y.IsAgree,
                                        CycleConditionId = y.CycleConditionId
                                    }).FirstOrDefault()
                                : new CycleConditionProvidedFormListVm(),
                        Description = Request.lang == "en"
                            ? x.EnglishDescription
                            : x.ArabicDescription,
                        Attachments = CycleConditionAttachmentEntities
                            .Where(y => y.CycleConditionsProvidedForm!.CycleConditionId == x.Id)
                            .Select(y => new CycleConditionAttachmentListVm()
                            {
                                Id = y.Id,
                                AttachementPath = y.AttachementPath.Contains("wwwroot")
                                    ? (WWWRootFilePath + y.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                    : y.AttachementPath.Replace("\\", "/"),
                                Description = y.Description,
                                IsAccept = y.IsAccept,
                                Name = y.Name,
                                ReasonOfReject = y.ReasonOfReject,
                                SizeOfAttachmentInKB = y.SizeOfAttachmentInKB
                            }).ToList(),
                        NeedAttachment = x.NeedAttachment,
                        Id = x.Id,
                        ArabicDescription = x.ArabicDescription,
                        AttachmentType = CycleConditionAttachmentTypeEntities
                            .Where(y => y.CycleConditionId == x.Id &&
                                y.AttachmentType != null)
                            .Select(y => y.AttachmentType!.Value)
                            .ToList(),
                        CreatedAt = x.CreatedAt,
                        CycleId = x.CycleId,
                        EnglishDescription = x.EnglishDescription,
                        RequiredAttachmentNumber = x.RequiredAttachmentNumber,
                        SizeOfAttachmentInKB = x.SizeOfAttachmentInKB
                    };
                }).ToList();

            return new BaseResponse<List<CycleConditionListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}