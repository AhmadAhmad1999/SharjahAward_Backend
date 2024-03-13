using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetProvidedFormById
{
    public class GetProvidedFormByIdQueryHandler
        : IRequestHandler<GetProvidedFormByIdQuery, BaseResponse<ProvidedFormDto>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IMapper _mapper;

        public GetProvidedFormByIdQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ProvidedFormDto>> Handle(GetProvidedFormByIdQuery request, CancellationToken cancellationToken)
        {
            var form = await _formRepository.GetByIdAsync(request.Id);
            
            if(form == null)
            {
                return new BaseResponse<ProvidedFormDto>("", false, 404);
            }
            var data = _mapper.Map<ProvidedFormDto>(form);
           
            return new BaseResponse<ProvidedFormDto>("", true, 200, data);
           
        }
    }
}
