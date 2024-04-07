using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllStudentsByClassId
{
    public class GetAllStudentsByClassIdHandler
        : IRequestHandler<GetAllStudentsByClassIdQuery, BaseResponse<List<GetAllStudentsByClassIdListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public GetAllStudentsByClassIdHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _ProvidedFormRepository = ProvidedFormRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }
        public async Task<BaseResponse<List<GetAllStudentsByClassIdListVM>>> Handle(GetAllStudentsByClassIdQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormsEntities = await _ProvidedFormRepository
                .Where(x => x.CategoryEducationalClassId != null && x.PercentCompletion == 100)
                .Include(x => x.CategoryEducationalClass!)
                .Where(x => x.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId)
                .Skip((Request.page - 1) * Request.pageSize)
                .Take(Request.pageSize)
                .Include(x => x.Category!)
                .ToListAsync();

            List<GetAllStudentsByClassIdListVM> Response = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                .Where(x => (x.DynamicAttribute!.EnglishLabel.ToLower() == "Full name (identical to Emirates ID)".ToLower() ||
                        x.DynamicAttribute.ArabicLabel == "الاسم الكامل (مطابق للهوية الإماراتية)") &&
                    x.RecordId != null &&
                    ProvidedFormsEntities.Select(y => y.categoryId)
                        .Any(y => y == x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation) &&
                    ProvidedFormsEntities.Select(y => y.Id)
                        .Any(y => y == x.RecordId))
                .Select(x => new GetAllStudentsByClassIdListVM()
                {
                    Id = x.RecordId!.Value,
                    FullName = x.Value,
                    CategoryName = Request.lang == "en"
                        ? ProvidedFormsEntities.FirstOrDefault(y => y.Id == x.RecordId!)!.Category!.EnglishName
                        : ProvidedFormsEntities.FirstOrDefault(y => y.Id == x.RecordId!)!.Category!.ArabicName
                }).ToListAsync();

            int TotalCount = await _ProvidedFormRepository
                .Where(x => x.CategoryEducationalClassId != null && x.PercentCompletion == 100)
                .Include(x => x.CategoryEducationalClass!)
                .Where(x => x.CategoryEducationalClass!.EducationalClassId == Request.EducationalClassId)
                .CountAsync();


            return new BaseResponse<List<GetAllStudentsByClassIdListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}
