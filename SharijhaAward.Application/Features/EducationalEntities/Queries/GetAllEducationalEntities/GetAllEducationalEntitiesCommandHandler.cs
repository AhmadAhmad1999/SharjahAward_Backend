using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntities
{
    public class GetAllEducationalEntitiesCommandHandler
        : IRequestHandler<GetAllEducationalEntitiesCommand, BaseResponse<List<EducationalEntitiesListVm>>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;

        public GetAllEducationalEntitiesCommandHandler(IAsyncRepository<EducationalEntity> _EducationalEntityRepository)
        {
            this._EducationalEntityRepository = _EducationalEntityRepository;
        }

        public async Task<BaseResponse<List<EducationalEntitiesListVm>>> 
            Handle(GetAllEducationalEntitiesCommand Request, CancellationToken cancellationToken)
        {
            var EducationalEntities = await _EducationalEntityRepository
                .OrderByDescending(x => x.CreatedAt, 0, -1).ToListAsync();

            if (Request.ArabicName != null && Request.EnglishName != null && EducationalEntities.Count() > 0)
            {
                EducationalEntities = _EducationalEntityRepository
                    .Where(x => x.ArabicName.ToLower().Contains(Request.ArabicName!.ToLower()) &&
                        x.EnglishName.ToLower().Contains(Request.EnglishName!.ToLower()) &&
                        x.CycleId == Request.CycleId)
                    .OrderByDescending(x => x.CreatedAt).ToList();
            }
            else if (Request.EnglishName != null && EducationalEntities.Count() > 0)
            {
                EducationalEntities = _EducationalEntityRepository
                    .Where(x => x.EnglishName.ToLower().Contains(Request.EnglishName!.ToLower()) &&
                        x.CycleId == Request.CycleId)
                    .OrderByDescending(x => x.CreatedAt).ToList();
            }
            else if (Request.ArabicName != null && EducationalEntities.Count() > 0)
            {
                EducationalEntities = _EducationalEntityRepository
                    .Where(x => x.ArabicName.ToLower().Contains(Request.ArabicName!.ToLower()) &&
                        x.CycleId == Request.CycleId)
                    .OrderByDescending(x => x.CreatedAt).ToList();
            }

            List<EducationalEntitiesListVm> Response = EducationalEntities
                .Select(x => new EducationalEntitiesListVm()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName
                }).ToList();

            return new BaseResponse<List<EducationalEntitiesListVm>>(string.Empty, true, 200, Response);
        }
    }
}
