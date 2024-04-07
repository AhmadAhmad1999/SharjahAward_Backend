using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllProvidedFormByClassId
{
    public class GetAllProvidedFormByClassIdHandler
        : IRequestHandler<GetAllProvidedFormByClassIdQuery, BaseResponse<List<GetAllProvidedFormByClassIdListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        public GetAllProvidedFormByClassIdHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository)
        {
            _ProvidedFormRepository = ProvidedFormRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
        }
        public async Task<BaseResponse<List<GetAllProvidedFormByClassIdListVM>>> Handle(GetAllProvidedFormByClassIdQuery Request, 
            CancellationToken cancellationToken)
        {
            List<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormsEntities = await _ProvidedFormRepository
                .Where(x => x.CategoryEducationalClassId != null)
                .Include(x => x.CategoryEducationalClass!)
                .Where(x => x.CategoryEducationalClass!.EducationalClassId == Request.EducationallassId)
                .Skip((Request.page - 1) * Request.pageSize)
                .Take(Request.pageSize)
                .ToListAsync();

            List<DynamicAttributeSection> DynamicAttributeSectionsEntites = await _DynamicAttributeSectionRepository
                .Where(x => ProvidedFormsEntities.Select(y => y.categoryId).Any(y => y == x.RecordIdOnRelation) &&
                    (x.EnglishName.ToLower() == "Main Information".ToLower() || x.ArabicName == "المعلومات الأساسية"))
                .ToListAsync();

            //ProvidedFormsEntities = ProvidedFormsEntities
            //    .Where(x => DynamicAttributeSectionsEntites.Select(y => y.RecordIdOnRelation).Any(y => y == x.ca))

            int TotalCount = await _ProvidedFormRepository
                .Where(x => x.CategoryEducationalClassId != null)
                .Include(x => x.CategoryEducationalClass!)
                .Where(x => x.CategoryEducationalClass!.EducationalClassId == Request.EducationallassId)
                .CountAsync();

            foreach (Domain.Entities.ProvidedFormModel.ProvidedForm ProvidedFormsEntity in ProvidedFormsEntities)
            {
                DynamicAttributeSection? ProvidedFormDynamicAttributeSectionEntity = DynamicAttributeSectionsEntites
                    .FirstOrDefault(x => x.RecordIdOnRelation == ProvidedFormsEntity.categoryId);

                if (ProvidedFormDynamicAttributeSectionEntity is null && 
                    ProvidedFormsEntities.Count() != TotalCount)
                {

                }
            }

            
            throw new NotImplementedException();
        }
    }
}
