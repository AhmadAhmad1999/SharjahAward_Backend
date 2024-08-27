using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.ExportGroupToExcel;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InvitationModels;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees
{
    public class GetAllGroupInviteeQueryHandler
        : IRequestHandler<GetAllGroupInviteeQuery, BaseResponse<List<GroupInviteeListVM>>>
    {
        private readonly IAsyncRepository<GroupInvitee> _groupInviteeRepository;
        private readonly IAsyncRepository<Student> _StudentRepository;
        private readonly IMapper _mapper;
        public GetAllGroupInviteeQueryHandler(IAsyncRepository<GroupInvitee> groupInviteeRepository,
            IAsyncRepository<Student> StudentRepository,
            IMapper mapper)
        {
            _groupInviteeRepository = groupInviteeRepository;
            _StudentRepository = StudentRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<GroupInviteeListVM>>> Handle(GetAllGroupInviteeQuery request, CancellationToken cancellationToken)
        {
            List<GroupInvitee> AllGroupInvitees;

            int count = 0;

            if (request.name != null)
            {
                var allDataWithoutPagenation = await _groupInviteeRepository
                    .Where(g => g.Name.ToLower().Contains(request.name.ToLower()) && 
                        (request.EventId != null 
                            ? g.EventId == request.EventId.Value
                            : true))
                    .OrderByDescending(x => x.CreatedAt).ToListAsync();

                count = allDataWithoutPagenation.Count();

                AllGroupInvitees = request.perPage == -1 || request.page == 0
                    ? allDataWithoutPagenation
                    : allDataWithoutPagenation
                      .Skip((request.page - 1) * request.perPage)
                      .Take(request.perPage)
                      .ToList();
            }
            else
            {
                AllGroupInvitees = request.perPage == -1 || request.page == 0
                    ? await _groupInviteeRepository.WhereThenInclude(g => request.EventId != null
                            ? g.EventId == request.EventId.Value
                            : true)
                        .OrderByDescending(x => x.CreatedAt).ToListAsync()
                    : await _groupInviteeRepository
                        .WhereThenInclude(g => request.EventId != null
                            ? g.EventId == request.EventId.Value
                            : true)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((request.page - 1) * request.perPage)
                        .Take(request.perPage)
                        .ToListAsync();

                count = await _groupInviteeRepository.GetCountAsync(g => request.EventId != null
                    ? g.EventId == request.EventId.Value
                    : true);
            }

            var data =  _mapper.Map<List<GroupInviteeListVM>>(AllGroupInvitees);

            List<Student> AllStudentEntities = await _StudentRepository
                .Where(x => data.Select(y => y.Id).Contains(x.GroupInviteeId))
                .ToListAsync();

            foreach (var item in data)
            {
                item.StudentNamesAsString = AllStudentEntities
                    .Where(x => x.GroupInviteeId == item.Id)
                    .Select(x => x.StudentName)
                    .ToList();
            }

            return new BaseResponse<List<GroupInviteeListVM>>("Retrive Succssfully",true,200,data,count);
        }
    }
}
