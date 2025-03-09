using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId
{
    public class GetCycleConditionByFormIdQueryHandler
        : IRequestHandler<GetCycleConditionByFormIdQuery, BaseResponse<List<CyclePublicConditionListVm>>>
    {
        private readonly IAsyncRepository<CycleCondition> _CycleConditionRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _CycleConditionsProvidedFormRepository;
        private readonly IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;


        public GetCycleConditionByFormIdQueryHandler(IAsyncRepository<CycleCondition> _CycleConditionRepository,
            IAsyncRepository<Cycle> _CycleRepository, 
            IMapper _Mapper, 
            IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository, 
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository, 
            IAsyncRepository<CycleConditionsProvidedForm> _CycleConditionsProvidedFormRepository,
            IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository,
            IUserRepository _UserRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._CycleConditionRepository = _CycleConditionRepository;
            this._CycleRepository = _CycleRepository;
            this._Mapper = _Mapper;
            this._CycleConditionAttachmentRepository = _CycleConditionAttachmentRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._CycleConditionsProvidedFormRepository = _CycleConditionsProvidedFormRepository;
            this._CycleConditionAttachmentTypeRepository = _CycleConditionAttachmentTypeRepository;
            this._UserRepository = _UserRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<List<CyclePublicConditionListVm>>> 
            Handle(GetCycleConditionByFormIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CycleEntity = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            if (CycleEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no active cycle in the current time"
                    : "لا يوجد دورة فعالة في الوقت الحالي";

                return new BaseResponse<List<CyclePublicConditionListVm>>(ResponseMessage, false, 404);
            }

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.formId);

            List<CycleCondition> CycleConditionEntities = await _CycleConditionRepository
                .Where(x => x.CycleId == CycleEntity.Id)
                .ToListAsync();

            List<CycleConditionAttachmentType> CycleConditionAttachmentTypeEntities = _CycleConditionAttachmentTypeRepository
                .Where(x => CycleConditionEntities.Select(y => y.Id).Contains(x.CycleConditionId))
                .ToList();

            List<CycleConditionsProvidedForm> CycleConditionsProvidedFormEntities = await _CycleConditionsProvidedFormRepository
                .Where(x => CycleConditionEntities.Select(y => y.Id).Contains(x.CycleConditionId) &&
                    x.ProvidedFormId == ProvidedFormEntity!.Id)
                .ToListAsync(); ;

            List<CycleConditionAttachment> AllConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                .Where(x => CycleConditionsProvidedFormEntities.Select(y => y.Id).Any(y => y == x.CycleConditionsProvidedFormId))
                .ToListAsync();

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<CyclePublicConditionListVm> Response = CycleConditionEntities
                .Select(x => new CyclePublicConditionListVm()
                {
                    ConditionsAttachments = CycleConditionsProvidedFormEntities
                        .Where(y => y.CycleConditionId == x.Id)
                        .Select(y => new CycleConditionProvidedFormListVm()
                        {
                            CycleConditionId = y.CycleConditionId,
                            IsAgree = y.IsAgree,
                            ProvidedFormId = y.ProvidedFormId,
                            Attachments = (x.NeedAttachment
                                ? (AllConditionAttachmentEntities
                                    .Where(z => y.CycleConditionId == z.CycleConditionsProvidedForm!.CycleConditionId)
                                    .Select(z => new CycleConditionAttachmentListVm()
                                    {
                                        AttachementPath = z.AttachementPath.Contains("wwwroot")
                                            ? (WWWRootFilePath + z.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                            : z.AttachementPath.Replace("\\", "/"),
                                        Description = z.Description,
                                        Id = z.Id,
                                        IsAccept = z.IsAccept,
                                        Name = z.Name,
                                        ReasonOfReject = z.ReasonOfReject,
                                        SizeOfAttachmentInKB = z.SizeOfAttachmentInKB
                                    }).ToList())
                                : new List<CycleConditionAttachmentListVm>())
                        }).FirstOrDefault(),
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                    Id = x.Id,
                    Description = Request.lang == "en"
                        ? x.EnglishDescription
                        : x.ArabicDescription,
                    ArabicDescription = x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    AttachmentType = CycleConditionAttachmentTypeEntities
                        .Where(y => y.CycleConditionId == x.Id &&
                            y.AttachmentType != null)
                        .Select(y => y.AttachmentType!.Value)
                        .ToList(),
                    CycleId = x.CycleId,
                    NeedAttachment = x.NeedAttachment,
                    Rejected = AllConditionAttachmentEntities
                        .Any(z => z.IsAccept == false &&
                            z.CycleConditionsProvidedForm!.CycleConditionId == x.Id),
                    RequiredAttachmentNumber = x.RequiredAttachmentNumber
                }).ToList();
            
            return new BaseResponse<List<CyclePublicConditionListVm>>("", true, 200, Response);
        }
    }
}
