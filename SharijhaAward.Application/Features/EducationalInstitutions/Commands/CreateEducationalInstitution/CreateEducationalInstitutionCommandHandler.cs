using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution
{
    public class CreateEducationalInstitutionCommandHandler
        : IRequestHandler<CreateEducationalInstitutionCommand, BaseResponse<Guid>>
    {
        private readonly IAsyncRepository<EducationalInstitution> _educationalInstitutionRepository;
        private readonly IAsyncRepository<EducationalEntity> _educationalEntityRepository;
        private readonly IMapper _mapper;

        public CreateEducationalInstitutionCommandHandler(IAsyncRepository<EducationalInstitution> educationalInstitutionRepository, IAsyncRepository<EducationalEntity> educationalEntityRepository, IMapper mapper)
        {
            _educationalInstitutionRepository = educationalInstitutionRepository;
            _educationalEntityRepository = educationalEntityRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<Guid>> Handle(CreateEducationalInstitutionCommand request, CancellationToken cancellationToken)
        {
            string msg;
            var Entity = await _educationalEntityRepository.GetByIdAsync(request.EducationalEntityId);
           
            if(Entity == null)
            {
                msg = request.lang == "en"
                    ? "Educational Entity dose not Exist"
                    : "الجهة التعليمية غير موجودة";
                return new BaseResponse<Guid>(msg, false, 404);
            }
            var Institution = _mapper.Map<EducationalInstitution>(request);

            var data = await _educationalInstitutionRepository.AddAsync(Institution);

            msg = request.lang == "en"
                ? "Educational Institution has been Created"
                : "تم إنشاء المؤسسة التعليمية";

            return new BaseResponse<Guid>(msg, true, 200, data.Id);
        }
    }
}
