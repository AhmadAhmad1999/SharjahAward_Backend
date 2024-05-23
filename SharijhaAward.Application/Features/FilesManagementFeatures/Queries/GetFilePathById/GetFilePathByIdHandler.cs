using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetFilePathById
{
    public class GetFilePathByIdHandler 
        : IRequestHandler<GetFilePathByIdQuery, BaseResponse<GetFilePathByIdDto>>
    {
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        public GetFilePathByIdHandler(IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository)
        {
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
        }

        public async Task<BaseResponse<GetFilePathByIdDto>>
            Handle(GetFilePathByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.FilterId == (int)FilesFilter.Criterion)
            {
                CriterionAttachment? CriterionAttachmentEntity = await _CriterionAttachmentRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.Id);

                if (CriterionAttachmentEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Criterion attachment is not Found"
                        : "ملحق المعيار غير موجود";

                    return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, false, 404);
                }

                GetFilePathByIdDto Response = new GetFilePathByIdDto()
                {
                    FilePath = CriterionAttachmentEntity.AttachementPath
                };

                return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, true, 200, Response);
            }
            else if (Request.FilterId == (int)FilesFilter.CriterionItem)
            {
                CriterionItemAttachment? CriterionItemAttachmentEntity = await _CriterionItemAttachmentRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.Id);

                if (CriterionItemAttachmentEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Criterion item attachment is not Found"
                        : "ملحق عنصر المعيار غير موجود";

                    return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, false, 404);
                }

                GetFilePathByIdDto Response = new GetFilePathByIdDto()
                {
                    FilePath = CriterionItemAttachmentEntity.AttachementPath
                };

                return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, true, 200, Response);
            }
            else if (Request.FilterId == (int)FilesFilter.SpecialCondition)
            {
                ConditionAttachment? ConditionAttachmentEntity = await _ConditionAttachmentRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.Id);

                if (ConditionAttachmentEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Special condition attachment is not Found"
                        : "ملف الشرط الخاص غير موجود";

                    return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, false, 404);
                }

                GetFilePathByIdDto Response = new GetFilePathByIdDto()
                {
                    FilePath = ConditionAttachmentEntity.AttachementPath
                };

                return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, true, 200, Response);
            }
            else if (Request.FilterId == (int)FilesFilter.GeneralCondition)
            {
                CycleConditionAttachment? CycleConditionAttachmentEntity = await _CycleConditionAttachmentRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.Id);

                if (CycleConditionAttachmentEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "General condition attachment is not Found"
                        : "ملف الشرط العام غير موجود";

                    return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, false, 404);
                }

                GetFilePathByIdDto Response = new GetFilePathByIdDto()
                {
                    FilePath = CycleConditionAttachmentEntity.AttachementPath
                };

                return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, true, 200, Response);
            }
            else if (Request.FilterId == (int)FilesFilter.SubscriberPersonalAndAcademicInformation ||
                Request.FilterId == (int)FilesFilter.CoordinatorFiles ||
                Request.FilterId == (int)FilesFilter.ArbitratorFiles)
            {
                if (Request.RowId is null)
                {
                    DynamicAttributeValue? DynamicAttributeValueEntity = await _DynamicAttributeValueRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (DynamicAttributeValueEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Personal and academic information attachment is not Found"
                            : "ملف الاستمارة غير موجود";

                        return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, false, 404);
                    }

                    GetFilePathByIdDto Response = new GetFilePathByIdDto()
                    {
                        FilePath = DynamicAttributeValueEntity.Value
                    };

                    return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, true, 200, Response);
                }
                else
                {
                    DynamicAttributeTableValue? DynamicAttributeTableValueEntity = await _DynamicAttributeTableValueRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.Id && x.RowId == Request.RowId);

                    if (DynamicAttributeTableValueEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Personal and academic information attachment is not Found"
                            : "ملف الاستمارة غير موجود";

                        return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, false, 404);
                    }

                    GetFilePathByIdDto Response = new GetFilePathByIdDto()
                    {
                        FilePath = DynamicAttributeTableValueEntity.Value
                    };

                    return new BaseResponse<GetFilePathByIdDto>(ResponseMessage, true, 200, Response);
                }
            }
            
            throw new NotImplementedException();
        }
    }
}
