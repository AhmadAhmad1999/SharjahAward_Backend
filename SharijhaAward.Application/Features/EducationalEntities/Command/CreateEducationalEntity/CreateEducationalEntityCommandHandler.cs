using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity
{
    public class CreateEducationalEntityCommandHandler :
        IRequestHandler<CreateEducationalEntityCommand, BaseResponse<Guid>>
    {
        private readonly IAsyncRepository<EducationalEntity> _educationalEntityRepository;
        private readonly IMapper _mapper;

        public CreateEducationalEntityCommandHandler(IAsyncRepository<EducationalEntity> educationalEntityRepository, IMapper mapper)
        {
            _mapper = mapper;
            _educationalEntityRepository = educationalEntityRepository;
        }
        public async Task<BaseResponse<Guid>> Handle(CreateEducationalEntityCommand request, CancellationToken cancellationToken)
        {
            var EducationalEntity = _mapper.Map<EducationalEntity>(request);
            var data = await _educationalEntityRepository.AddAsync(EducationalEntity);
            string msg = request.lang == "en"
                ? "Educational Entity Added Succssuflly"
                : "تم إضافة الجهة التعليمية بنجاح";

            return new BaseResponse<Guid>(msg, true, 200, data.Id);
        }
    }
}
