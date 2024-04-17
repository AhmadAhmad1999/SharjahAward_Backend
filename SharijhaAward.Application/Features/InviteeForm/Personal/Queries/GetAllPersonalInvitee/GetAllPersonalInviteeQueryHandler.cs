using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InvitationModels;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee
{
    public class GetAllPersonalInviteeQueryHandler
        : IRequestHandler<
            GetAllPersonalInviteeQuery, BaseResponse<List<PersonalInviteeListVM>>>
    {
        private readonly IAsyncRepository<PersonalInvitee> _PersonalInviteeRepository;
        private readonly IMapper _mapper;
        public GetAllPersonalInviteeQueryHandler(IAsyncRepository<PersonalInvitee> personalInviteeRepository, IMapper mapper)
        {
            _PersonalInviteeRepository = personalInviteeRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<PersonalInviteeListVM>>> Handle(GetAllPersonalInviteeQuery request, CancellationToken cancellationToken)
        {
            List<PersonalInvitee> allPersonalInvitee;
            if (request.name != null)
            {
                allPersonalInvitee = request.pageSize == -1 || request.page == 0
                    ? _PersonalInviteeRepository
                        .Where(g => g.Name.ToLower().Contains(request.name.ToLower()) &&
                            request.EventId != null
                                ? g.EventId == request.EventId
                                : true).OrderBy(g => g.CreatedAt).ToList()
                    : _PersonalInviteeRepository
                        .Where(g => g.Name.ToLower().Contains(request.name!.ToLower()) &&
                            request.EventId != null
                                ? g.EventId == request.EventId
                                : true)
                        .Skip((request.page - 1) * request.pageSize)
                        .Take(request.pageSize)
                        .OrderBy(g => g.CreatedAt)
                        .ToList();
            }
            else
            {
                allPersonalInvitee = (List<PersonalInvitee>)(request.pageSize == -1 || request.page == 0
                    ? await _PersonalInviteeRepository.Where(g => request.EventId != null
                        ? g.EventId == request.EventId
                        : true).ToListAsync()
                    : await _PersonalInviteeRepository.GetWhereThenPagedReponseAsync(g => request.EventId != null
                        ? g.EventId == request.EventId
                        : true, request.page, request.pageSize));
            }
            
            var data = _mapper.Map<List<PersonalInviteeListVM>>(allPersonalInvitee);
            var Count = _PersonalInviteeRepository.ListAllAsync().Result.Count();
            return new BaseResponse<List<PersonalInviteeListVM>>("Retrive Succssfully", true, 200, data, Count);
        }
    }
}
