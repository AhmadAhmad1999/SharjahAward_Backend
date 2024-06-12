using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults
{
    public class GetAllArbitrationResultsHandler
        : IRequestHandler<GetAllArbitrationResultsQuery, BaseResponse<List<GetAllArbitrationResultsListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IMapper _Mapper;
        public GetAllArbitrationResultsHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IMapper Mapper)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllArbitrationResultsListVM>>> 
            Handle(GetAllArbitrationResultsQuery Request, CancellationToken cancellationToken)
        {
            List<ArbitrationResult> ArbitrationResultEntities = await _ArbitrationResultRepository
                .Include(x => x.ProvidedForm!)
                .Include(x => x.ProvidedForm!.Category!)
                .Include(x => x.ProvidedForm!.Category!.Cycle!)
                .ToListAsync();

            List<FinalArbitration> FinalArbitrationEntities = await _FinalArbitrationRepository
                .Where(x => ArbitrationResultEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                .ToListAsync();

            //var xx = await _ArbitrationRepository
            //    .Where(x => x)

            var FormData = await _FinalArbitrationRepository
                .Include(x => x.ProvidedForm!)
                .Include(x => x.ProvidedForm!.Category!)
                .Include(x => x.ProvidedForm!.Category!.Cycle!)
                .FirstOrDefaultAsync(x => x.isAcceptedFromChairman);

            //if (FormData is not null)
            //{
            //    var xxxx = new
            //    {
            //        FormData.ProvidedFormId,
            //        CategoryName = Request.lang == "en"
            //            ? FormData.ProvidedForm!.Category!.EnglishName
            //            : FormData.ProvidedForm!.Category!.ArabicName,
            //        FormData.ProvidedForm!.Category!.Cycle!.di
            //    };
            //}
            

            //var xx = await _FinalArbitrationRepository
            //    .Where(x => x.isAcceptedFromChairman)
            //    .ToListAsync();

            //var yy = xx.FirstOrDefault()!.ProvidedForm!.Category!


            throw new NotImplementedException();
        }
    }
}
