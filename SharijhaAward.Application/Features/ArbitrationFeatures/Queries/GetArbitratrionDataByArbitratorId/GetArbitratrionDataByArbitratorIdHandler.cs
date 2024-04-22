﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId
{
    public class GetArbitratrionDataByArbitratorIdHandler
        : IRequestHandler<GetArbitratrionDataByArbitratorIdQuery, BaseResponse<GetArbitratrionDataByArbitratorIdDto>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public GetArbitratrionDataByArbitratorIdHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }

        public async Task<BaseResponse<GetArbitratrionDataByArbitratorIdDto>> 
            Handle(GetArbitratrionDataByArbitratorIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<Arbitration> AllArbitratorAssingedForms = await _ArbitrationRepository
                .Where(x => x.ArbitratorId == Request.Id)
                .OrderByDescending(x => x.CreatedAt)
                .Include(x => x.ProvidedForm!)
                .Include(x => x.ProvidedForm!.Category!)
                .Include(x => x.ProvidedForm!.CategoryEducationalClass!)
                .Include(x => x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!)
                .Include(x => x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!)
                .ToListAsync();

            List<DynamicAttributeValue> SubscribersNames = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Include(x => x.DynamicAttribute!.DynamicAttributeSection)
                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                    AllArbitratorAssingedForms.Select(y => y.ProvidedFormId)
                        .Any(y => y == x.RecordId) &&
                    x.DynamicAttribute!.EnglishLabel.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                .ToListAsync();


            Arbitrator? ArbitratorEntity = await _ArbitratorRepository.FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ArbitratorEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not Found"
                    : "المحكم غير موجود";

                return new BaseResponse<GetArbitratrionDataByArbitratorIdDto>(ResponseMessage, false, 404);
            }

            GetArbitratrionDataByArbitratorIdDto Response = new GetArbitratrionDataByArbitratorIdDto()
            {
                ArbitratorName = Request.lang == "en"
                    ? ArbitratorEntity.EnglishName
                    : ArbitratorEntity.ArabicName,
                NumberOfAssignedForms = AllArbitratorAssingedForms.Count(),

                AssignedForms = AllArbitratorAssingedForms
                    .Select(x => Request.lang == "en"
                        ? new FormsListVMForArbitrationDto() 
                        {
                            Id = x.ProvidedFormId,
                            CategoryName = x.ProvidedForm!.Category!.EnglishName,
                            SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value,
                            EducationalClassName = x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.EnglishName
                        } 
                        : new FormsListVMForArbitrationDto() 
                        {
                            Id = x.ProvidedFormId,
                            CategoryName = x.ProvidedForm!.Category!.ArabicName,
                            SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value,
                            EducationalClassName = x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.ArabicName
                        }).ToList(),

                RemainingForms = await _ProvidedFormRepository
                    .Where(x => x.PercentCompletion == 100 &&
                        !AllArbitratorAssingedForms.Select(y => y.ProvidedFormId).Contains(x.Id))
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => Request.lang == "en"
                        ? new FormsListVMForArbitrationDto() 
                        {
                            Id = x.Id,
                            CategoryName = x.Category!.EnglishName,
                            SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) != null
                                ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value
                                : null,
                            EducationalClassName = x.CategoryEducationalClass != null
                                ? x.CategoryEducationalClass!.EducationalClass!.EnglishName
                                : null
                        } 
                        : new FormsListVMForArbitrationDto() 
                        {
                            Id = x.Id,
                            CategoryName = x.Category!.ArabicName,
                            SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) != null
                                ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value : null,
                            EducationalClassName = x.CategoryEducationalClass != null
                                ? x.CategoryEducationalClass!.EducationalClass!.ArabicName : null
                        }).ToListAsync()
            };

            return new BaseResponse<GetArbitratrionDataByArbitratorIdDto>(ResponseMessage, true, 200, Response);
        }
    }
}
