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
            if(request.categoryColumns == null)
            {
                request.categoryColumns = new string[0];
            }

            if(request.providedFormColumns == null)
            {
                request.providedFormColumns = new string[0];
            }
            
            if(request.subCategoryColumns == null)
            {
                request.subCategoryColumns = new string[0];
            }

            if(request.userColumns == null)
            {
                request.userColumns = new string[0];
            } 
            
            if(request.coordinatorColumns == null)
            {
                request.coordinatorColumns = new string[0];
            } 
            
            if(request.arbitratorColumns == null)
            {
                request.arbitratorColumns = new string[0];
            }

            var data = await _reportService.GetDynamicReportAsync(
                request.cycleColumns, 
                request.categoryColumns, 
                request.providedFormColumns,
                request.userColumns,
                request.coordinatorColumns,
                request.arbitratorColumns);

            return new BaseResponse<List<Dictionary<string, object>>>("", true, 200, data);
            
        }
    }
}
