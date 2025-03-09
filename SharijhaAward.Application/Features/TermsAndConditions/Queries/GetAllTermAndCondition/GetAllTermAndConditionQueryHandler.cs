using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition
{
    public class GetAllTermAndConditionQueryHandler
        : IRequestHandler<GetAllTermAndConditionQuery, BaseResponse<List<TermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository;

        public GetAllTermAndConditionQueryHandler(IAsyncRepository<TermAndCondition> _TermAndConditionRepository,
            IAsyncRepository<TermAndConditionAttachmentType> _TermAndConditionAttachmentTypeRepository)
        {
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._TermAndConditionAttachmentTypeRepository = _TermAndConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<List<TermAndConditionListVM>>> 
            Handle(GetAllTermAndConditionQuery Request, CancellationToken cancellationToken)
        {
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            List<TermAndCondition> TermAndConditionEntities = new List<TermAndCondition>();

            if (Request.page != 0 &&
                Request.perPage != -1)
            {
                TermAndConditionEntities = await _TermAndConditionRepository
                    .WhereThenFilter(x => Request.CategoryId != null
                        ? x.CategoryId == Request.CategoryId
                        : true, FilterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToListAsync();
            }
            else
            {
                TermAndConditionEntities = await _TermAndConditionRepository
                    .WhereThenFilter(x => Request.CategoryId != null
                        ? x.CategoryId == Request.CategoryId
                        : true, FilterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync();
            }

            List<TermAndConditionAttachmentType> TermAndConditionAttachmentTypeEntities = _TermAndConditionAttachmentTypeRepository
                .Where(x => TermAndConditionEntities.Select(y => y.Id).Contains(x.TermAndConditionId) &&
                    x.AttachmentType != null)
                .ToList();

            List<TermAndConditionListVM> Response = TermAndConditionEntities
                .Select(x => new TermAndConditionListVM()
                {
                    ArabicDescription = x.ArabicDescription,
                    AttachmentType = TermAndConditionAttachmentTypeEntities
                        .Where(y => y.TermAndConditionId == x.Id)
                        .Select(y => y.AttachmentType!.Value)
                        .ToList(),
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    CreateAt = x.CreatedAt,
                    Description = Request.lang == "en"
                        ? x.EnglishDescription
                        : x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    IsSpecial = true,
                    NeedAttachment = x.NeedAttachment,
                    RequiredAttachmentNumber = x.RequiredAttachmentNumber,
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB
                }).ToList();

            int TotalCount = await _TermAndConditionRepository
                .WhereThenFilter(x => Request.CategoryId != null
                    ? x.CategoryId == Request.CategoryId
                    : true, FilterObject)
                .CountAsync();

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<TermAndConditionListVM>>(string.Empty, true, 200, Response, Pagination);    
        }
    }
}
