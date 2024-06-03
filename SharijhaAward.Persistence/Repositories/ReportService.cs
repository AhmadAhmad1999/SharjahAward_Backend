using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Repositories
{
    public class ReportService : IReportService
    {
        private readonly SharijhaAwardDbContext _context;

        public ReportService(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task<List<Dictionary<string, object>>> GetDynamicReportAsync(string[] cyclesColumns, string[] categoryColumns, string[] subCategoryColumns, string[] providedFormColums)
        {
            var cyclesQuery = _context.Cycles.AsQueryable();
            
            //if(cyclesColumns.Length > 0)
            //{
            //    //var selectedColumnsFromCycle = string.Join(", ", cyclesColumns);
            //    //cyclesQuery = _context.Cycles.FromSqlRaw($"SELECT {selectedColumnsFromCycle} FROM Cycles")!;
                
            //}
            if(categoryColumns.Length > 0 || subCategoryColumns.Length > 0)
            {
                cyclesQuery = cyclesQuery.Include(c => c.Categories);
            }

            if(providedFormColums.Length > 0)
            {
                cyclesQuery = cyclesQuery.Include(c => c.Categories).ThenInclude(c => c.ProvidedForms);
            }
            
            var cycles = await cyclesQuery.ToListAsync();
            
            var result = new List<Dictionary<string, object>>();
           
            foreach( var cycle in cycles)
            {
                var cyclesDict = new Dictionary<string, object>();
                
                foreach(var cycleColumn in cyclesColumns)
                {
                    var value = cycle.GetType().GetProperty(cycleColumn)?.GetValue(cycle, null);
                    cyclesDict[cycleColumn] = value!;
                }

                if(categoryColumns.Length > 0 && cycle.Categories != null)
                {
                    var categories = new List<Dictionary<string, object>>();

                    foreach(var category in cycle.Categories)
                    {
                        var categoryDict = new Dictionary<string, object>();

                        foreach(var categoryColumn in categoryColumns)
                        {
                            var value = category.GetType().GetProperty(categoryColumn)?.GetValue(category, null);
                            categoryDict[categoryColumn] = value!;
                        }

                        if(providedFormColums.Length > 0 && category.ProvidedForms != null)
                        {
                            var providedForms = new List<Dictionary<string, object>>();

                            foreach (var form in category.ProvidedForms)
                            {
                                var formDict = new Dictionary<string, object>();
                                foreach (var formColumn in providedFormColums)
                                {
                                    var value = form.GetType().GetProperty(formColumn)?.GetValue(form, null);
                                    formDict[formColumn] = value!;
                                }
                                providedForms.Add(formDict);
                            }

                            categoryDict["ProvidedForms"] = providedForms;

                        }
                        categories.Add(categoryDict);
                        
                    }
                    cyclesDict["Categories"] = categories;
                }
                result.Add(cyclesDict);
            }

            return result;
        }
    }
}
