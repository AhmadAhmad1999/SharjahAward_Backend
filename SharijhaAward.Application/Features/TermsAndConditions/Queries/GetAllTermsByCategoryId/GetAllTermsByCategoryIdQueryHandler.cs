using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId
{
    public class GetAllTermsByCategoryIdQueryHandler
        : IRequestHandler<GetAllTermsByCategoryIdQuery, BaseResponse<List<TermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _ConditionsProvidedFormsRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository;
        private readonly IMapper _Mapper;

        public GetAllTermsByCategoryIdQueryHandler(
            IAsyncRepository<Category> _CategoryRepository,
            IAsyncRepository<TermAndCondition> _TermAndConditionRepository,
            IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository,
            IAsyncRepository<ConditionsProvidedForms> _ConditionsProvidedFormsRepository,
            IUserRepository _UserRepository,
            IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository,
            IMapper _Mapper)
        {
            this._CategoryRepository = _CategoryRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._ConditionAttachmentRepository = _ConditionAttachmentRepository;
            this._ConditionsProvidedFormsRepository = _ConditionsProvidedFormsRepository;
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._UserRepository = _UserRepository;
            this._TermAndConditionAttachmentTypeRepository = _TermAndConditionAttachmentTypeRepository;
            this._Mapper = _Mapper;
        }
        public async Task<BaseResponse<List<TermAndConditionListVM>>> 
            Handle(GetAllTermsByCategoryIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CategoryEntity = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CategoryEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<List<TermAndConditionListVM>>(ResponseMessage, false, 404);
            }

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = _ProvidedFormRepository
                .FirstOrDefault(x => x.Id == Request.formId);

            List<TermAndCondition> TermAndConditionEntities = await _TermAndConditionRepository
                .Where(t => t.CategoryId == CategoryEntity.Id)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
            
            List<ConditionsProvidedForms> ConditionsProvidedFormsEntities = await _ConditionsProvidedFormsRepository
                .Where(x => TermAndConditionEntities.Select(y => y.Id).Contains(x.TermAndConditionId) &&
                    x.ProvidedFormId == ProvidedFormEntity!.Id)
                .ToListAsync();
           
            var Response = _Mapper.Map<List<TermAndConditionListVM>>(TermAndConditionEntities);

            List<ConditionAttachment> AllConditionAttachmentEntities = await _ConditionAttachmentRepository
                .Where(x => ConditionsProvidedFormsEntities.Select(y => y.Id).Any(y => y == x.ConditionsProvidedFormsId))
                .ToListAsync();

            List<TermAndConditionAttachmentType> TermAndConditionAttachmentTypeEntities = _TermAndConditionAttachmentTypeRepository
                .Where(x => TermAndConditionEntities.Select(y => y.Id).Contains(x.TermAndConditionId) &&
                    x.AttachmentType != null)
                .ToList();

            for (int i = 0; i < Response.Count; i++)
            {
                Response[i].ConditionsAttachments = _Mapper.Map<ConditionProvidedFormListVm>(ConditionsProvidedFormsEntities[i]);
               
                if (Response[i].NeedAttachment)
                {
                    Response[i].ConditionsAttachments!.Attachments = _Mapper.Map<List<AttachmentListVM>>(AllConditionAttachmentEntities
                        .Where(x => x.ConditionsProvidedFormsId == ConditionsProvidedFormsEntities[i].Id)
                        .ToList());
                }

                Response[i].Description = Request.lang == "en"
                    ? Response[i].EnglishDescription
                    : Response[i].ArabicDescription;

                Response[i].AttachmentType = TermAndConditionAttachmentTypeEntities
                    .Where(x => x.TermAndConditionId == Response[i].Id)
                    .Select(x => x.AttachmentType!.Value)
                    .ToList();
            }

            return new BaseResponse<List<TermAndConditionListVM>>(string.Empty, true, 200, Response);
        }
    }
}
