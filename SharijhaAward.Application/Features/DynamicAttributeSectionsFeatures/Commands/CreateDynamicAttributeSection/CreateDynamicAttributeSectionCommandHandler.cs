using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection
{
    public class CreateDynamicAttributeSectionCommandHandler : IRequestHandler<CreateDynamicAttributeSectionCommand, 
        BaseResponse<CreateDynamicAttributeSectionCommandResponse>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<AttributeTableName> _AttributeTableNameRepository;
        public CreateDynamicAttributeSectionCommandHandler(IMapper Mapper,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<AttributeTableName> AttributeTableNameRepository)
        {
            _Mapper = Mapper;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _AttributeTableNameRepository = AttributeTableNameRepository;
        }
        public async Task<BaseResponse<CreateDynamicAttributeSectionCommandResponse>> Handle(CreateDynamicAttributeSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AttributeTableName? CheckIfAttributeTableNameIdDoesExist = await _AttributeTableNameRepository
                .FirstOrDefaultAsync(x => x.Id == Request.AttributeTableNameId);
            if (CheckIfAttributeTableNameIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Attribute data type is not Found"
                  : "نوع الحقل غير موجود";

                return new BaseResponse<CreateDynamicAttributeSectionCommandResponse>(ResponseMessage, false, 404);
            }

            DynamicAttributeSection NewDynamicAttributeSectionEntity = _Mapper.Map<DynamicAttributeSection>(Request);
            await _DynamicAttributeSectionRepository.AddAsync(NewDynamicAttributeSectionEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء الحقل بنجاح";

            return new BaseResponse<CreateDynamicAttributeSectionCommandResponse>()
            {
                data = new CreateDynamicAttributeSectionCommandResponse()
                {
                    CreateDynamicAttributeSectionDto = new CreateDynamicAttributeSectionDto()
                    {
                        Id = NewDynamicAttributeSectionEntity.Id,
                        ArabicName = NewDynamicAttributeSectionEntity.ArabicName,
                        EnglishName = NewDynamicAttributeSectionEntity.EnglishName
                    }
                },
                message = ResponseMessage,
                statusCode = 200,
                success = true
            };
        }
    }
}
