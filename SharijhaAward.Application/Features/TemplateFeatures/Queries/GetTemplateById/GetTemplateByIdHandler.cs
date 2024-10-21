using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Queries.GetTemplateById
{
    public class GetTemplateByIdHandler : IRequestHandler<GetTemplateByIdQuery, BaseResponse<GetTemplateByIdDto>>
    {
        private readonly IAsyncRepository<Template> _TemplateRepository;
        private readonly IMapper _Mapper;

        public GetTemplateByIdHandler(IAsyncRepository<Template> TemplateRepository,
            IMapper Mapper)
        {
            _TemplateRepository = TemplateRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetTemplateByIdDto>> Handle(GetTemplateByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Template? TemplateEntity = await _TemplateRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (TemplateEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Template is not found"
                    : "النموذج غير موجود";

                return new BaseResponse<GetTemplateByIdDto>(ResponseMessage, false, 404);
            }

            GetTemplateByIdDto GetTemplateByIdDto = _Mapper.Map<GetTemplateByIdDto>(TemplateEntity);

            return new BaseResponse<GetTemplateByIdDto>(ResponseMessage, true, 200, GetTemplateByIdDto);
        }
    }
}
