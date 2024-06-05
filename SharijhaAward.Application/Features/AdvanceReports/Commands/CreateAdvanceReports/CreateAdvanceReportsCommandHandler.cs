using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AdvanceReports.Commands.CreateAdvanceReports
{
    public class CreateAdvanceReportsCommandHandler
        : IRequestHandler<CreateAdvanceReportsCommand, BaseResponse<List<Dictionary<string, object>>>>
    {
        private readonly IReportService _reportService;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;

        public CreateAdvanceReportsCommandHandler(IReportService reportService, IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Category> categoryRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository)
        {
            _reportService = reportService;
            _cycleRepository = cycleRepository;
            _categoryRepository = categoryRepository;
            _providedFormRepository = providedFormRepository;
        }

        public async Task<BaseResponse<List<Dictionary<string, object>>>> Handle(CreateAdvanceReportsCommand request, CancellationToken cancellationToken)
        {
            if(request.categoryColums == null)
            {
                request.categoryColums = new string[0];
            }

            if(request.ProvidedFormColums == null)
            {
                request.ProvidedFormColums = new string[0];
            }
            
            if(request.subCategoryColums == null)
            {
                request.subCategoryColums = new string[0];
            }
            var data = await _reportService.GetDynamicReportAsync(request.cycleColums, request.categoryColums, request.ProvidedFormColums);

            return new BaseResponse<List<Dictionary<string, object>>>("", true, 200, data);
            
        }
    }
}
