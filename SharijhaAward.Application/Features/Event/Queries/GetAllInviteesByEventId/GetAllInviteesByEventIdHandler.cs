using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EventModel;

namespace SharijhaAward.Application.Features.Event.Queries.GetAllInviteesByEventId
{
    public class GetAllInviteesByEventIdHandler 
        : IRequestHandler<GetAllInviteesByEventIdQuery, BaseResponse<List<GetAllInviteesByEventIdListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository;
        private readonly IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository;
        public GetAllInviteesByEventIdHandler(IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository,
            IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository)
        {
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._PersonalInviteeVirtualTableRepository = _PersonalInviteeVirtualTableRepository;
            this._GroupInviteeVirtualTableRepository = _GroupInviteeVirtualTableRepository;
        }

        public async Task<BaseResponse<List<GetAllInviteesByEventIdListVM>>> 
            Handle(GetAllInviteesByEventIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<DynamicAttributeValue> DynamicAttributeValueEntities = new List<DynamicAttributeValue>();
            
            if (!string.IsNullOrEmpty(Request.Email))
            {
                DynamicAttributeValueEntities = _DynamicAttributeValueRepository
                    .Where(x => x.Value.ToLower().StartsWith(Request.Email.ToLower()) &&
                        x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId &&
                        (Request.InviteeType == InviteeTypes.Personal
                            ? (x.DynamicAttribute!.EnglishLabel == "Email" &&
                                x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == InviteeTypes.Personal)
                            : (x.DynamicAttribute!.EnglishLabel == "Email (Student Supervisor)" &&
                                x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == InviteeTypes.Group)))
                    .AsEnumerable()
                    .DistinctBy(x => x.RecordId)
                    .AsEnumerable()
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToList();
            }
            else
            {
                DynamicAttributeValueEntities = _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId &&
                        (Request.InviteeType == InviteeTypes.Personal
                            ? (x.DynamicAttribute!.EnglishLabel == "Email" &&
                                x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == InviteeTypes.Personal)
                            : (x.DynamicAttribute!.EnglishLabel == "Email (Student Supervisor)" &&
                                x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == InviteeTypes.Group)))
                    .AsEnumerable()
                    .DistinctBy(x => x.RecordId)
                    .AsEnumerable()
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToList();
            }

            if (Request.InviteeType == InviteeTypes.Personal)
            {
                List<PersonalInviteeVirtualTable> PersonalInviteeVirtualTableEntity = await _PersonalInviteeVirtualTableRepository
                    .Where(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Contains(x.Id))
                    .ToListAsync();

                List<GetAllInviteesByEventIdListVM> Response = DynamicAttributeValueEntities
                    .Select(x => new GetAllInviteesByEventIdListVM()
                    {
                        Id = x.RecordId!.Value,
                        Email = x.Value,
                        UniqueIntegerId = PersonalInviteeVirtualTableEntity
                            .FirstOrDefault(y => y.Id == x.RecordId)?.UniqueIntegerId ?? 0,
                        IsAttend = PersonalInviteeVirtualTableEntity
                            .FirstOrDefault(y => y.Id == x.RecordId)?.IsAttend ?? false,
                    }).ToList();

                int TotalCount = _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId &&
                        x.DynamicAttribute!.EnglishLabel == "Email" &&
                        x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == InviteeTypes.Personal)
                .AsEnumerable()
                .DistinctBy(x => x.RecordId)
                .AsEnumerable()
                .Count();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllInviteesByEventIdListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
            else
            {
                List<GroupInviteeVirtualTable> GroupInviteeVirtualTableEntity = await _GroupInviteeVirtualTableRepository
                    .Where(x => DynamicAttributeValueEntities.Select(y => y.RecordId).Contains(x.Id))
                    .ToListAsync();

                List<GetAllInviteesByEventIdListVM> Response = DynamicAttributeValueEntities
                    .Select(x => new GetAllInviteesByEventIdListVM()
                    {
                        Id = x.RecordId!.Value,
                        Email = x.Value,
                        UniqueIntegerId = GroupInviteeVirtualTableEntity
                            .FirstOrDefault(y => y.Id == x.RecordId)?.UniqueIntegerId ?? 0,
                        NumberOfActualAttendance = GroupInviteeVirtualTableEntity
                            .FirstOrDefault(y => y.Id == x.RecordId)?.NumberOfActualAttendance ?? 0,
                        NumberOfExpectedAttendance = GroupInviteeVirtualTableEntity
                            .FirstOrDefault(y => y.Id == x.RecordId)?.NumberOfExpectedAttendance ?? 0,
                        IsAttend = GroupInviteeVirtualTableEntity
                            .FirstOrDefault(y => y.Id == x.RecordId)?.IsAttend ?? false,
                    }).ToList();

                int TotalCount = _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                        x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId &&
                        x.DynamicAttribute!.EnglishLabel == "Email (Student Supervisor)" &&
                        x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == InviteeTypes.Group)
                .AsEnumerable()
                .DistinctBy(x => x.RecordId)
                .AsEnumerable()
                .Count();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllInviteesByEventIdListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
        }
    }
}
