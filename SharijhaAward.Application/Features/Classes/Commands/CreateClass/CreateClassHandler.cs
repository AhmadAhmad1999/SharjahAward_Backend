using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Application.Features.Classes.Commands.CreateClass
{
    public class CreateClassHandler : IRequestHandler<CreateClassCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;

        public CreateClassHandler(IMapper Mapper,
            IAsyncRepository<EducationalClass> EducationalClassRepository)
        {
            _Mapper = Mapper;
            _EducationalClassRepository = EducationalClassRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateClassCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalClass NewEducationalClassEntity = _Mapper.Map<EducationalClass>(Request);

            await _EducationalClassRepository.AddAsync(NewEducationalClassEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء الدور بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
