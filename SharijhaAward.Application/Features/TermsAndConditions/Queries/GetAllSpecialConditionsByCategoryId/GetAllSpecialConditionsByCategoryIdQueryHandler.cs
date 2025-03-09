using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllSpecialConditionsByCategoryId
{
    public class GetAllSpecialConditionsByCategoryIdQueryHandler
        : IRequestHandler<GetAllSpecialConditionsByCategoryIdQuery, BaseResponse<List<TermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _ConditionsProvidedFormsRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository;

        public GetAllSpecialConditionsByCategoryIdQueryHandler(IAsyncRepository<Category> _CategoryRepository,
            IAsyncRepository<TermAndCondition> _TermAndConditionRepository,
            IAsyncRepository<ConditionsProvidedForms> _ConditionsProvidedFormsRepository,
            IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository,
            IUserRepository _UserRepository,
            IJwtProvider _JwtProvider,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor,
            IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository)
        {
            this._CategoryRepository = _CategoryRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._ConditionAttachmentRepository = _ConditionAttachmentRepository;
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._ConditionsProvidedFormsRepository = _ConditionsProvidedFormsRepository;
            this._UserRepository = _UserRepository;
            this._JwtProvider = _JwtProvider;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._TermAndConditionAttachmentTypeRepository = _TermAndConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<List<TermAndConditionListVM>>> 
            Handle(GetAllSpecialConditionsByCategoryIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            Category? CategoryEntity = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CategoryEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<List<TermAndConditionListVM>>(ResponseMessage, false, 404);
            }

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.formId);

            List<TermAndCondition> TermAndConditionEntities = await _TermAndConditionRepository
                .Where(t => t.CategoryId == CategoryEntity.Id)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            List<ConditionsProvidedForms> ConditionsProvidedFormsEntities = await _ConditionsProvidedFormsRepository
                .Where(x => TermAndConditionEntities.Select(y => y.Id).Contains(x.TermAndConditionId) &&
                    x.ProvidedFormId == ProvidedFormEntity!.Id)
                .ToListAsync();

            for (int i = 0; i < TermAndConditionEntities.Count(); i++)
            {
                var conditionsProvidedsobject =
                     ConditionsProvidedFormsEntities.FirstOrDefault(
                         c => c.ProvidedFormId == ProvidedFormEntity!.Id && c.TermAndConditionId == TermAndConditionEntities[i].Id);

                if(conditionsProvidedsobject == null)
                {
                    var conditionsProvided = new ConditionsProvidedForms()
                    {
                        ProvidedFormId = ProvidedFormEntity!.Id,
                        TermAndConditionId = TermAndConditionEntities[i].Id,
                        IsAgree = false
                    };

                    await _ConditionsProvidedFormsRepository.AddAsync(conditionsProvided);
                    ConditionsProvidedFormsEntities.Add(conditionsProvided);
                }
            }

            var data = _Mapper.Map<List<TermAndConditionListVM>>(TermAndConditionEntities);

            List<ConditionAttachment> AllConditionAttachmentEntities = await _ConditionAttachmentRepository
                .Where(x => ConditionsProvidedFormsEntities.Select(y => y.Id).Any(y => y == x.ConditionsProvidedFormsId))
                .ToListAsync();

            List<TermAndConditionAttachmentType> TermAndConditionAttachmentTypeEntities = _TermAndConditionAttachmentTypeRepository
                .Where(x => TermAndConditionEntities.Select(y => y.Id).Contains(x.TermAndConditionId) &&
                    x.AttachmentType != null)
                .ToList();

            for (int i = 0; i < data.Count; i++)
            {
                ConditionsProvidedForms? ConditionsProvidedFormsEntity = ConditionsProvidedFormsEntities
                    .FirstOrDefault(x => x.TermAndConditionId == data[i].Id);

                if (ConditionsProvidedFormsEntity is not null)
                {
                    data[i].ConditionsAttachments = new ConditionProvidedFormListVm()
                    {
                        ProvidedFormId = ConditionsProvidedFormsEntity.ProvidedFormId,
                        IsAgree = ConditionsProvidedFormsEntity.IsAgree,
                        TermAndConditionId = ConditionsProvidedFormsEntity.TermAndConditionId
                    };

                    if (data[i].NeedAttachment)
                    {
                        data[i].ConditionsAttachments!.Attachments = _Mapper.Map<List<AttachmentListVM>>(AllConditionAttachmentEntities
                            .Where(x => x.ConditionsProvidedFormsId == ConditionsProvidedFormsEntity.Id)
                            .Select(x => new AttachmentListVM()
                            {
                                Id = x.Id,
                                Name = x.Name,
                                Description = x.Description,
                                AttachementPath = x.AttachementPath.Contains("wwwroot")
                                    ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                    : x.AttachementPath.Replace("\\", "/")
                            }).ToList());

                        if (data[i].ConditionsAttachments!.Attachments.Any(a => a.IsAccept == false))
                            data[i].Rejected = true;
                    }
                }

                data[i].Description = Request.lang == "en"
                    ? data[i].EnglishDescription
                    : data[i].ArabicDescription;

                data[i].AttachmentType = TermAndConditionAttachmentTypeEntities
                    .Where(x => x.TermAndConditionId == data[i].Id)
                    .Select(x => x.AttachmentType!.Value)
                    .ToList();
            }

            data = data.OrderByDescending(a => a.CreateAt).ToList();

            return new BaseResponse<List<TermAndConditionListVM>>("", true, 200, data);
        }
    }
}
