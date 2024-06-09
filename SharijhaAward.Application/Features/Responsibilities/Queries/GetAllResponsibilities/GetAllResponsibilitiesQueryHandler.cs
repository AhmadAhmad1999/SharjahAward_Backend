using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities
{
    public class GetAllResponsibilitiesQueryHandler
        : IRequestHandler<GetAllResponsibilitiesQuery, BaseResponse<List<ResponsibilityListVM>>>
    {
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;
        private readonly IMapper _mapper;

        public GetAllResponsibilitiesQueryHandler(IAsyncRepository<Responsibility> responsibilityRepository, IMapper mapper)
        {
            _responsibilityRepository = responsibilityRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<ResponsibilityListVM>>> Handle(GetAllResponsibilitiesQuery request, CancellationToken cancellationToken)
        {
            var responsibilities = request.RoleId == null
                ? await _responsibilityRepository.GetPagedReponseAsync(request.page, request.perPage)
                : await _responsibilityRepository.GetWhereThenPagedReponseAsync(r => r.RoleId == request.RoleId, request.page, request.perPage);

            var data = _mapper.Map<List<ResponsibilityListVM>>(responsibilities);

            var count = _responsibilityRepository.GetCount(r=>!r.isDeleted);

            Pagination pagination = new Pagination(request.page, request.perPage, count);

            return new BaseResponse<List<ResponsibilityListVM>>("", true, 200, data, pagination);
        }
    }
}
