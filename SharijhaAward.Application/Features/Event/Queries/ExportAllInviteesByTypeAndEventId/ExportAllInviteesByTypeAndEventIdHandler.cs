using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EventModel;

namespace SharijhaAward.Application.Features.Event.Queries.ExportAllInviteesByTypeAndEventId
{
    public class ExportAllInviteesByTypeAndEventIdHandler : IRequestHandler<ExportAllInviteesByTypeAndEventIdQuery, BaseResponse<ExportAllInviteesByTypeAndEventIdResponse>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository;
        private readonly IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;

        public ExportAllInviteesByTypeAndEventIdHandler(IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository,
            IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository,
            IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository,
            IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository)
        {
            this._DynamicAttributeRepository = _DynamicAttributeRepository;
            this._DynamicAttributeSectionRepository = _DynamicAttributeSectionRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._PersonalInviteeVirtualTableRepository = _PersonalInviteeVirtualTableRepository;
            this._GroupInviteeVirtualTableRepository = _GroupInviteeVirtualTableRepository;
            this._DynamicAttributeListValueRepository = _DynamicAttributeListValueRepository;
            this._DynamicAttributeTableValueRepository = _DynamicAttributeTableValueRepository;
            this._EventRepository = _EventRepository;
        }

        public async Task<BaseResponse<ExportAllInviteesByTypeAndEventIdResponse>>
            Handle(ExportAllInviteesByTypeAndEventIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.EventModel.Event? EventEntity = await _EventRepository
                .FirstOrDefaultAsync(x => x.Id == Request.EventId);

            if (EventEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Event is not found"
                    : "الفعالية غير موجودة";

                return new BaseResponse<ExportAllInviteesByTypeAndEventIdResponse>(ResponseMessage, false, 404);
            }

            if (Request.GetColumnsNamesOnly)
            {
                List<DynamicAttribute> DynamicAttributeEntities = await _DynamicAttributeRepository
                    .Where(x => x.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId &&
                        x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                        x.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                        x.DynamicAttributeSection!.InviteeType == Request.InviteeType)
                    .ToListAsync();

                List<DynamicAttributeListValue> DynamicAttributeListValueEntities = await _DynamicAttributeListValueRepository
                    .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                    .ToListAsync();

                List<IGrouping<int, DynamicAttributeTableValue>> DynamicAttributeTableValueEntities = await _DynamicAttributeTableValueRepository
                    .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                    .GroupBy(x => x.DynamicAttributeId)
                    .ToListAsync();

                // Assuming ColumnsNames should be a dictionary
                Dictionary<string, Tuple<object, string>> ColumnsDictionary = DynamicAttributeEntities
                    .ToDictionary(
                        Entity => Entity.EnglishLabel,
                        Entity => Tuple.Create((object)Entity.ArabicLabel, Entity.AttributeDataType!.Name));

                List<IGrouping<int, DynamicAttributeValue>> ValueEntities = new List<IGrouping<int, DynamicAttributeValue>>();

                if (Request.page != 0 && Request.perPage != -1)
                    ValueEntities = _DynamicAttributeValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId!.Value)
                        .AsEnumerable()
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToList();

                else
                    ValueEntities = _DynamicAttributeValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId!.Value)
                        .AsEnumerable()
                        .ToList();

                List<int> VirtualTableIdsForValueEntities = ValueEntities
                    .Select(x => x.Key)
                    .ToList();

                List<Dictionary<string, object>> TableValueEntities = new List<Dictionary<string, object>>();

                List<IGrouping<int, DynamicAttributeTableValue>> xTableValueEntities = new List<IGrouping<int, DynamicAttributeTableValue>>();

                if (Request.page != 0 && Request.perPage != -1)
                    xTableValueEntities = _DynamicAttributeTableValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId)
                        .AsEnumerable()
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToList();
                else
                    xTableValueEntities = _DynamicAttributeTableValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId)
                        .AsEnumerable()
                        .ToList();

                List<int> VirtualTableIdsForTableValueEntities = xTableValueEntities
                    .Select(x => x.Key)
                    .ToList();

                List<int> AllVirtualTableIds = VirtualTableIdsForValueEntities
                    .Union(VirtualTableIdsForTableValueEntities)
                    .ToList();

                if (Request.InviteeType == Domain.Constants.InviteeTypes.Personal)
                {
                    List<PersonalInviteeVirtualTable> VirtualEntities = await _PersonalInviteeVirtualTableRepository
                        .Where(x => AllVirtualTableIds.Contains(x.Id))
                        .ToListAsync();

                    ColumnsDictionary.Add("IsAttend", Tuple.Create((object)"حضر الفعالية", "boolean"));
                    ColumnsDictionary.Add("UniqueIntegerId", Tuple.Create((object)"المعرف الخاص", "Number"));
                    ColumnsDictionary.Add("Id", Tuple.Create((object)"معرف الدعوة", "Number"));

                    ColumnsDictionary = ColumnsDictionary.Reverse().ToDictionary();

                    ExportAllInviteesByTypeAndEventIdResponse Response = new ExportAllInviteesByTypeAndEventIdResponse()
                    {
                        ColumnsNames = ColumnsDictionary.Select(kvp => new { kvp.Key, Label = kvp.Value.Item1, Type = kvp.Value.Item2 }).Cast<object>().ToList(),
                        Values = new List<object>()
                    };

                    int TotalCount = await _DynamicAttributeValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId)
                        .CountAsync();

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<ExportAllInviteesByTypeAndEventIdResponse>(ResponseMessage, true, 200, Response, PaginationParameter);
                }
                else
                {
                    List<GroupInviteeVirtualTable> VirtualEntities = await _GroupInviteeVirtualTableRepository
                        .Where(x => AllVirtualTableIds.Contains(x.Id))
                        .ToListAsync();

                    ColumnsDictionary.Add("NumberOfExpectedAttendance", Tuple.Create((object)"عدد الحضور المتوقع", "Number"));
                    ColumnsDictionary.Add("NumberOfActualAttendance", Tuple.Create((object)"عدد الحضور الفعلي", "Number"));

                    ColumnsDictionary.Add("IsAttend", Tuple.Create((object)"حضر الفعالية", "boolean"));
                    ColumnsDictionary.Add("UniqueIntegerId", Tuple.Create((object)"المعرف الخاص", "Number"));
                    ColumnsDictionary.Add("Id", Tuple.Create((object)"معرف الدعوة", "Number"));

                    ColumnsDictionary = ColumnsDictionary.Reverse().ToDictionary();

                    var MainInformationDynamicSection = ColumnsDictionary
                        .FirstOrDefault(x => x.Key.ToLower() == "Email (Student Supervisor)".ToLower());

                    int IndexOfMainInformationSection = ColumnsDictionary.ToList().IndexOf(MainInformationDynamicSection);

                    var FirstDynamicSection = ColumnsDictionary.FirstOrDefault();

                    ColumnsDictionary.ToList()[1] = MainInformationDynamicSection;
                    ColumnsDictionary.ToList()[IndexOfMainInformationSection] = FirstDynamicSection;

                    ExportAllInviteesByTypeAndEventIdResponse Response = new ExportAllInviteesByTypeAndEventIdResponse()
                    {
                        ColumnsNames = ColumnsDictionary.Select(kvp => new { kvp.Key, Label = kvp.Value.Item1, Type = kvp.Value.Item2 }).Cast<object>().ToList(),
                        Values = new List<object>()
                    };

                    int TotalCount = await _DynamicAttributeValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId)
                        .CountAsync();

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<ExportAllInviteesByTypeAndEventIdResponse>(ResponseMessage, true, 200, Response, PaginationParameter);
                }
            }
            else
            {
                List<DynamicAttribute> DynamicAttributeEntities = await _DynamicAttributeRepository
                    .Where(x => x.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId &&
                        x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                        x.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                        x.DynamicAttributeSection!.InviteeType == Request.InviteeType)
                    .ToListAsync();

                
                List<IGrouping<int, DynamicAttributeTableValue>> DynamicAttributeTableValueEntities = await _DynamicAttributeTableValueRepository
                    .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                    .GroupBy(x => x.DynamicAttributeId)
                    .ToListAsync();

                List<DynamicAttribute> ListDynamicAttributeEntities = DynamicAttributeEntities
                    .Where(x => x.AttributeDataTypeId == 8)
                    .ToList();

                if (ListDynamicAttributeEntities.Any())
                {

                }

                List<IGrouping<int, DynamicAttributeValue>> ValueEntities = new List<IGrouping<int, DynamicAttributeValue>>();

                if (Request.page != 0 && Request.perPage != -1)
                    ValueEntities = _DynamicAttributeValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId!.Value)
                        .AsEnumerable()
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToList();

                else
                    ValueEntities = _DynamicAttributeValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId!.Value)
                        .AsEnumerable()
                        .ToList();

                List<int> VirtualTableIdsForValueEntities = ValueEntities
                    .Select(x => x.Key)
                    .ToList();

                List<Dictionary<string, object>> TableValueEntities = new List<Dictionary<string, object>>();

                List<IGrouping<int, DynamicAttributeTableValue>> xTableValueEntities = new List<IGrouping<int, DynamicAttributeTableValue>>();

                if (Request.page != 0 && Request.perPage != -1)
                    xTableValueEntities = _DynamicAttributeTableValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId)
                        .AsEnumerable()
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToList();
                else
                    xTableValueEntities = _DynamicAttributeTableValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId)
                        .AsEnumerable()
                        .ToList();

                List<int> VirtualTableIdsForTableValueEntities = xTableValueEntities
                    .Select(x => x.Key)
                    .ToList();

                List<int> AllVirtualTableIds = VirtualTableIdsForValueEntities
                    .Union(VirtualTableIdsForTableValueEntities)
                    .ToList();

                List<Dictionary<string, object>> ValuesResponse = new List<Dictionary<string, object>>();

                if (Request.InviteeType == Domain.Constants.InviteeTypes.Personal)
                {
                    List<PersonalInviteeVirtualTable> VirtualEntities = await _PersonalInviteeVirtualTableRepository
                        .Where(x => AllVirtualTableIds.Contains(x.Id))
                        .ToListAsync();

                    foreach (int VirtualTableId in AllVirtualTableIds)
                    {
                        PersonalInviteeVirtualTable PersonalInviteeVirtualTableEntity = VirtualEntities
                            .FirstOrDefault(x => x.Id == VirtualTableId)!;

                        Dictionary<string, object> ForEachResponse = new Dictionary<string, object>();

                        if (Request.lang == "en")
                        {
                            ForEachResponse = new Dictionary<string, object>()
                            {
                                { "Id", PersonalInviteeVirtualTableEntity.Id },
                                { "UniqueIntegerId", PersonalInviteeVirtualTableEntity.UniqueIntegerId },
                                { "IsAttend", PersonalInviteeVirtualTableEntity.IsAttend }
                            };
                        }
                        else
                        {
                            ForEachResponse = new Dictionary<string, object>()
                            {
                                { "معرف الدعوة", PersonalInviteeVirtualTableEntity.Id },
                                { "المعرف الخاص", PersonalInviteeVirtualTableEntity.UniqueIntegerId },
                                { "حضر الفعالية", PersonalInviteeVirtualTableEntity.IsAttend }
                            };
                        }

                        if (ValueEntities.Any())
                        {
                            Dictionary<string, object> ValueEntitiesForThisVirtualTableId = ValueEntities
                                .FirstOrDefault(x => x.Key == VirtualTableId)!
                                .ToDictionary(Entity => Request.lang == "en"
                                    ? Entity.DynamicAttribute!.EnglishLabel
                                    : Entity.DynamicAttribute!.ArabicLabel,
                                    Entity => (object)Entity.Value);

                            ForEachResponse = ForEachResponse
                                .Concat(ValueEntitiesForThisVirtualTableId)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                        }

                        if (xTableValueEntities.Any())
                        {
                            Dictionary<string, object>? TableValueEntitiesFortThisVirtualTableId = xTableValueEntities
                                .FirstOrDefault(x => x.Key == VirtualTableId)
                                ? .GroupBy(x => x.DynamicAttributeId)
                                    .ToDictionary(Entity => Request.lang == "en"
                                            ? Entity.FirstOrDefault()!.DynamicAttribute!.EnglishLabel
                                            : Entity.FirstOrDefault()!.DynamicAttribute!.ArabicLabel,
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

                    ExportAllInviteesByTypeAndEventIdResponse Response = new ExportAllInviteesByTypeAndEventIdResponse()
                    {
                        ColumnsNames = new List<object>(),
                        Values = ValuesResponse.ToList<object>()
                    };

                    int TotalCount = await _DynamicAttributeValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId)
                        .CountAsync();

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<ExportAllInviteesByTypeAndEventIdResponse>(ResponseMessage, true, 200, Response, PaginationParameter);
                }
                else
                {
                    List<GroupInviteeVirtualTable> VirtualEntities = await _GroupInviteeVirtualTableRepository
                        .Where(x => AllVirtualTableIds.Contains(x.Id))
                        .ToListAsync();

                    foreach (int VirtualTableId in AllVirtualTableIds)
                    {
                        GroupInviteeVirtualTable GroupInviteeVirtualTableEntity = VirtualEntities
                            .FirstOrDefault(x => x.Id == VirtualTableId)!;

                        Dictionary<string, object> ForEachResponse = new Dictionary<string, object>();

                        if (Request.lang == "en")
                        {
                            ForEachResponse = new Dictionary<string, object>() 
                            {
                                { "Id", GroupInviteeVirtualTableEntity.Id },
                                { "UniqueIntegerId", GroupInviteeVirtualTableEntity.UniqueIntegerId },
                                { "IsAttend", GroupInviteeVirtualTableEntity.IsAttend },
                                { "NumberOfExpectedAttendance", GroupInviteeVirtualTableEntity.NumberOfExpectedAttendance },
                                { "NumberOfActualAttendance", GroupInviteeVirtualTableEntity.NumberOfActualAttendance }
                            };
                        }
                        else
                        {
                            ForEachResponse = new Dictionary<string, object>()
                            {
                                { "معرف الدعوة", GroupInviteeVirtualTableEntity.Id },
                                { "المعرف الخاص", GroupInviteeVirtualTableEntity.UniqueIntegerId },
                                { "حضر الفعالية", GroupInviteeVirtualTableEntity.IsAttend },
                                { "عدد الحضور المتوقع", GroupInviteeVirtualTableEntity.NumberOfExpectedAttendance },
                                { "عدد الحضور الفعلي", GroupInviteeVirtualTableEntity.NumberOfActualAttendance }
                            };
                        }

                        if (ValueEntities.Any())
                        {
                            Dictionary<string, object> ValueEntitiesForThisVirtualTableId = ValueEntities
                                .FirstOrDefault(x => x.Key == VirtualTableId)!
                                .ToDictionary(Entity => Request.lang == "en"
                                    ? Entity.DynamicAttribute!.EnglishLabel 
                                    : Entity.DynamicAttribute!.ArabicLabel,
                                    Entity => (object)Entity.Value);

                            ForEachResponse = ForEachResponse
                                .Concat(ValueEntitiesForThisVirtualTableId)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                        }

                        if (xTableValueEntities.Any())
                        {
                            Dictionary<string, object>? TableValueEntitiesFortThisVirtualTableId = xTableValueEntities
                                .FirstOrDefault(x => x.Key == VirtualTableId)
                                ? .GroupBy(x => x.DynamicAttributeId)
                                .ToDictionary(Entity => Request.lang == "en"
                                        ? Entity.FirstOrDefault()!.DynamicAttribute!.EnglishLabel
                                        : Entity.FirstOrDefault()!.DynamicAttribute!.ArabicLabel,
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

                    ExportAllInviteesByTypeAndEventIdResponse Response = new ExportAllInviteesByTypeAndEventIdResponse()
                    {
                        ColumnsNames = new List<object>(),
                        Values = ValuesResponse.ToList<object>()
                    };

                    int TotalCount = await _DynamicAttributeValueRepository
                        .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                        .GroupBy(x => x.RecordId)
                        .CountAsync();

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<ExportAllInviteesByTypeAndEventIdResponse>(ResponseMessage, true, 200, Response, PaginationParameter);
                }
            }
        }
    }
}
