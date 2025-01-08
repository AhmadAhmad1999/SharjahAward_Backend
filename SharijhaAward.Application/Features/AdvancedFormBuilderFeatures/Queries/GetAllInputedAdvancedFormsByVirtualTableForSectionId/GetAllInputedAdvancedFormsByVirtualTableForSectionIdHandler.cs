using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllInputedAdvancedFormsByVirtualTableForSectionId
{
    public class GetAllInputedAdvancedFormsByVirtualTableForSectionIdHandler 
        : IRequestHandler<GetAllInputedAdvancedFormsByVirtualTableForSectionIdQuery, BaseResponse<GetAllInputedAdvancedFormsByVirtualTableForSectionIdListVM>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderTableValue> _AdvancedFormBuilderTableValueRepository;
        public GetAllInputedAdvancedFormsByVirtualTableForSectionIdHandler(IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository,
            IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AdvancedFormBuilderTableValue> _AdvancedFormBuilderTableValueRepository)
        {
            this._AdvancedFormBuilderRepository = _AdvancedFormBuilderRepository;
            this._AdvancedFormBuilderSectionRepository = _AdvancedFormBuilderSectionRepository;
            this._AdvancedFormBuilderValueRepository = _AdvancedFormBuilderValueRepository;
            this._VirtualTableForSectionRepository = _VirtualTableForSectionRepository;
            this._AdvancedFormBuilderListValueRepository = _AdvancedFormBuilderListValueRepository;
            this._AdvancedFormBuilderTableValueRepository = _AdvancedFormBuilderTableValueRepository;
        }

        public async Task<BaseResponse<GetAllInputedAdvancedFormsByVirtualTableForSectionIdListVM>>
            Handle(GetAllInputedAdvancedFormsByVirtualTableForSectionIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            VirtualTableForSection? VirtualTableForSectionEntity = await _VirtualTableForSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.VirtualTableForSectionId);

            if (VirtualTableForSectionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Virtual table for section is not found"
                    : "النموذج غير موجود";

                return new BaseResponse<GetAllInputedAdvancedFormsByVirtualTableForSectionIdListVM>(ResponseMessage, false, 404);
            }

            List<AdvancedFormBuilder> AdvancedFormBuilderEntities = new List<AdvancedFormBuilder>();

            if (Request.ExportToExcel)
                AdvancedFormBuilderEntities = await _AdvancedFormBuilderRepository
                    .WhereThenFilter(x => x.AdvancedFormBuilderSection!.VirtualTableForSectionId == Request.VirtualTableForSectionId &&
                        x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active, FilterObject)
                    .ToListAsync();
            else
                AdvancedFormBuilderEntities = await _AdvancedFormBuilderRepository
                    .WhereThenFilter(x => x.AdvancedFormBuilderSection!.VirtualTableForSectionId == Request.VirtualTableForSectionId &&
                        x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                        x.ViewInTable, FilterObject)
                    .ToListAsync();
                
            List<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueEntities = await _AdvancedFormBuilderListValueRepository
                .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                .ToListAsync();

            List<IGrouping<int, AdvancedFormBuilderTableValue>> AdvancedFormBuilderTableValueEntities = await _AdvancedFormBuilderTableValueRepository
                .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                .GroupBy(x => x.AdvancedFormBuilderId)
                .ToListAsync();

            // Assuming ColumnsNames should be a dictionary
            Dictionary<string, Tuple<object, string>> ColumnsDictionary = AdvancedFormBuilderEntities
                .ToDictionary(
                    Entity => Entity.EnglishLabel,
                    Entity => Tuple.Create((object)Entity.ArabicLabel, Entity.AttributeDataType!.Name));

            ColumnsDictionary.Add("VirtualTableId", Tuple.Create((object)"المعرف", "Number"));

            ColumnsDictionary = ColumnsDictionary.Reverse().ToDictionary();

            List<IGrouping<int, AdvancedFormBuilderValue>> ValueEntities = new List<IGrouping<int, AdvancedFormBuilderValue>>();
            
            if (Request.page != 0 && Request.perPage != -1)
                ValueEntities = _AdvancedFormBuilderValueRepository
                    .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                    .GroupBy(x => x.VirtualTableId)
                    .AsEnumerable()
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToList();

            else
                ValueEntities = _AdvancedFormBuilderValueRepository
                    .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                    .GroupBy(x => x.VirtualTableId)
                    .AsEnumerable()
                    .ToList();

            List<int> VirtualTableIdsForValueEntities = ValueEntities
                .Select(x => x.Key)
                .ToList();
                    
            List<Dictionary<string, object>> TableValueEntities = new List<Dictionary<string, object>>();

            List<IGrouping<int, AdvancedFormBuilderTableValue>> xTableValueEntities = new List<IGrouping<int, AdvancedFormBuilderTableValue>>();
            
            if (Request.page != 0 && Request.perPage != -1)
                xTableValueEntities = _AdvancedFormBuilderTableValueRepository
                    .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                    .GroupBy(x => x.VirtualTableId)
                    .AsEnumerable()
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToList();
            else
                xTableValueEntities = _AdvancedFormBuilderTableValueRepository
                    .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                    .GroupBy(x => x.VirtualTableId)
                    .AsEnumerable()
                    .ToList();

            List<int> VirtualTableIdsForTableValueEntities = xTableValueEntities
                .Select(x => x.Key)
                .ToList();

            List<int> AllVirtualTableIds = VirtualTableIdsForValueEntities
                .Union(VirtualTableIdsForTableValueEntities)
                .ToList();

            List<Dictionary<string, object>> ValuesResponse = new List<Dictionary<string, object>>();
                
            foreach (int VirtualTableId in AllVirtualTableIds)
            {
                Dictionary<string, object> ForEachResponse = new Dictionary<string, object>()
                {
                    { "VirtualTableId", VirtualTableId }
                };

                if (ValueEntities.Any())
                {
                    Dictionary<string, object> ValueEntitiesForThisVirtualTableId = ValueEntities
                        .FirstOrDefault(x => x.Key == VirtualTableId)!
                        .ToDictionary(Entity => Request.lang == "en"
                            ? Entity.AdvancedFormBuilder!.EnglishLabel
                            : Entity.AdvancedFormBuilder!.ArabicLabel,
                            Entity => (object)Entity.Value);

                    ForEachResponse = ForEachResponse
                        .Concat(ValueEntitiesForThisVirtualTableId)
                        .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                }

                if (xTableValueEntities.Any())
                {
                    Dictionary<string, object>? TableValueEntitiesFortThisVirtualTableId = xTableValueEntities
                        .FirstOrDefault(x => x.Key == VirtualTableId)
                        ? .GroupBy(x => x.AdvancedFormBuilderId!)
                        .ToDictionary(Entity => Request.lang == "en"
                                ? Entity.FirstOrDefault()!.AdvancedFormBuilder!.EnglishLabel
                                : Entity.FirstOrDefault()!.AdvancedFormBuilder!.ArabicLabel,
                            Entity => (object)string.Join(" $$ ", Entity.ToList()
                                .Select(x => x.Value)));

                    if (TableValueEntitiesFortThisVirtualTableId is not null)
                        ForEachResponse = ForEachResponse
                            .Concat(TableValueEntitiesFortThisVirtualTableId)
                            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                }

                if (ForEachResponse.Any())
                    ValuesResponse.Add(ForEachResponse);
            }

            GetAllInputedAdvancedFormsByVirtualTableForSectionIdListVM Response = new GetAllInputedAdvancedFormsByVirtualTableForSectionIdListVM()
            {
                ColumnsNames = ColumnsDictionary.Select(kvp => new { kvp.Key, Label = kvp.Value.Item1, Type = kvp.Value.Item2 }).Cast<object>().ToList(),
                Values = ValuesResponse.ToList<object>()
            };

            int TotalCount = await _AdvancedFormBuilderValueRepository
                .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                .GroupBy(x => x.VirtualTableId)
                .CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<GetAllInputedAdvancedFormsByVirtualTableForSectionIdListVM>(ResponseMessage, true, 200, Response, PaginationParameter);
        }
    }
}
