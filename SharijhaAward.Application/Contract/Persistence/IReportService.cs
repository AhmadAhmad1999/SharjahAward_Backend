using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Persistence
{
    public interface IReportService
    {
        public Task<List<Dictionary<string, object>>> GetDynamicReportAsync(
        string[] cyclesColumns, 
        string[] categoryColumns, 
        string[] providedFormColumns, 
        string[] userColumns,
        string[] coordinatorColums,
        string[] arbitratorColums);
    }
}
