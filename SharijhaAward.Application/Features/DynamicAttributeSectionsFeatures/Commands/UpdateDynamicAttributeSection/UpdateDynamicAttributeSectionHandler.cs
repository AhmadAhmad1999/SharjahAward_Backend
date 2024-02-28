using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Event.Commands.UpdateEvent;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection
{
    public class UpdateDynamicAttributeSectionHandler : IRequestHandler<UpdateDynamicAttributeSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IMapper _Mapper;

        public UpdateDynamicAttributeSectionHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository, 
            IMapper Mapper)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateDynamicAttributeSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttributeSection? DynamicAttributeSectionOldData = await _DynamicAttributeSectionRepository.GetByIdAsync(Request.Id);

            if (DynamicAttributeSectionOldData == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Section not Found"
                    : "هذا القسم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            UpdateDynamicAttributeSectionValidator Validator = new UpdateDynamicAttributeSectionValidator();
            ValidationResult ValidationResult = await Validator.ValidateAsync(Request);

            if (ValidationResult.Errors.Count > 0)
                throw new ValidationException(ValidationResult.Errors);

            _Mapper.Map(Request, DynamicAttributeSectionOldData, typeof(UpdateDynamicAttributeSectionCommand),
                typeof(DynamicAttributeSection));

            await _DynamicAttributeSectionRepository.UpdateAsync(DynamicAttributeSectionOldData);

            ResponseMessage = Request.lang == "en"
                ? "Section has been updated successfully"
                : "تم تعديل القسم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
