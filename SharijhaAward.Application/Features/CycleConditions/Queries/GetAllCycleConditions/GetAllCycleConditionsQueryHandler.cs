using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleConditionModel;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions
{
    public class GetAllCycleConditionsQueryHandler
        : IRequestHandler<GetAllCycleConditionsQuery, BaseResponse<List<CycleConditionListVM>>>
    {
        private readonly IAsyncRepository<CycleCondition> _CycleConditionRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository;

        public GetAllCycleConditionsQueryHandler(IAsyncRepository<CycleCondition> _CycleConditionRepository,
            IMapper _Mapper,
            IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository)
        {
            this._CycleConditionRepository = _CycleConditionRepository;
            this._Mapper = _Mapper;
            this._CycleConditionAttachmentTypeRepository = _CycleConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<List<CycleConditionListVM>>> Handle(GetAllCycleConditionsQuery Request, CancellationToken cancellationToken)
        {
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            List<CycleCondition> CycleConditionEntities = new List<CycleCondition>();

            if (Request.page != 0 &&
                Request.perPage != -1)
            {
                CycleConditionEntities = await _CycleConditionRepository
                    .WhereThenFilter(x => Request.CycleId != null
                        ? x.CycleId == Request.CycleId
                        : true, FilterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToListAsync();
            }
            else
            {
                CycleConditionEntities = await _CycleConditionRepository
                    .WhereThenFilter(x => Request.CycleId != null
                        ? x.CycleId == Request.CycleId
                        : true, FilterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync();
            }

            List<CycleConditionAttachmentType> CycleConditionAttachmentTypeEntities = _CycleConditionAttachmentTypeRepository
                .Where(x => CycleConditionEntities.Select(y => y.Id).Contains(x.CycleConditionId) &&
                    x.AttachmentType != null)
                .ToList();

            List<CycleConditionListVM> Response = CycleConditionEntities
                .Select(x => new CycleConditionListVM()
                {
                    Id = x.Id,
                    ArabicDescription = x.ArabicDescription,
                    AttachmentType = CycleConditionAttachmentTypeEntities
                        .Where(y => y.CycleConditionId == x.Id)
                        .Select(y => y.AttachmentType!.Value)
                        .ToList(),
                    CreatedAt = x.CreatedAt,
                    CycleId = x.CycleId,
                    Description = Request.lang == "en"
                        ? x.EnglishDescription
                        : x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    NeedAttachment = x.NeedAttachment,
                    RequiredAttachmentNumber = x.RequiredAttachmentNumber,
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB
                }).ToList();

            int TotalCount = await _CycleConditionRepository
                .WhereThenFilter(x => Request.CycleId != null
                    ? x.CycleId == Request.CycleId
                    : true, FilterObject)
                .CountAsync();

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);
            
            return new BaseResponse<List<CycleConditionListVM>>(string.Empty, true, 200, Response, Pagination);
        }
    }
}
