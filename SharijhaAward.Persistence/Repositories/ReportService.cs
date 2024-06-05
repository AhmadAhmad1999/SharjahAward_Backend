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

        public async Task<List<Dictionary<string, object>>> GetDynamicReportAsync(
            string[] cyclesColumns, 
            string[] categoryColumns, 
            string[] providedFormColumns, 
            string[] userColumns,
            string[] coordinatorColumns,
            string[] arbitratorColumns)
        {
            var cyclesQuery = _context.Cycles.AsQueryable();

            if (userColumns.Length > 0)
            {
                cyclesQuery = cyclesQuery
                    .Include(c => c.Categories)
                    .ThenInclude(c => c.ProvidedForms)
                    .ThenInclude(c => c.User);
            }
            if (arbitratorColumns.Length > 0)
            {
                cyclesQuery = cyclesQuery
                   .Include(c => c.Categories)
                   .ThenInclude(c => c.ProvidedForms)
                   .ThenInclude(c => c.ArbitratorProvidedForms)
                   .ThenInclude(c => c.Arbitrator);
            }
            if (coordinatorColumns.Length > 0)
            {
                cyclesQuery = cyclesQuery
                    .Include(c => c.Categories)
                    .ThenInclude(c => c.ProvidedForms)
                    .ThenInclude(c => c.CoordinatorProvidedForms)
                    .ThenInclude(c => c.Coordinator);
            }
            else if (providedFormColumns.Length > 0)
            {
                cyclesQuery = cyclesQuery.Include(c => c.Categories.Where(c => c.ParentId != null)).ThenInclude(c => c.ProvidedForms);
            }

            else if (categoryColumns.Length > 0)
            {
                cyclesQuery = cyclesQuery.Include(c => c.Categories);
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

                        if(providedFormColumns.Length > 0 && category.ProvidedForms != null)
                        {
                            var providedForms = new List<Dictionary<string, object>>();

                            foreach (var form in category.ProvidedForms)
                            {
                                var formDict = new Dictionary<string, object>();
                                foreach (var formColumn in providedFormColumns)
                                {
                                    var value = form.GetType().GetProperty(formColumn)?.GetValue(form, null);
                                    formDict[formColumn] = value!;
                                }

                                if (userColumns.Length > 0 && form.User != null)
                                {
                                    var userDic = new Dictionary<string, object>();
                                    foreach( var userColumn in userColumns)
                                    {
                                        var value = form.User.GetType().GetProperty(userColumn)?.GetValue(form.User, null);
                                        userDic[userColumn] = value!;
                                    }

                                    formDict["Subscriber"] = userDic;

                                }

                                if (coordinatorColumns.Length > 0 && form.CoordinatorProvidedForms != null)
                                {
                                    var coordinators = new List<Dictionary<string, object>>();

                                    foreach (var coordinatorForm in form.CoordinatorProvidedForms)
                                    {
                                        var coordinatorDic = new Dictionary<string, object>();
                                       
                                        var coordinator = coordinatorForm.Coordinator;
                                        
                                        foreach(var coordinatorColumn in coordinatorColumns)
                                        {
                                            var value = coordinator.GetType().GetProperty(coordinatorColumn)?.GetValue(coordinator, null);
                                            coordinatorDic[coordinatorColumn] = value!;
                                        }

                                        coordinators.Add(coordinatorDic);
                                    }

                                    formDict["Coordinators"] = coordinators;
                                }

                                if (arbitratorColumns.Length > 0 && form.ArbitratorProvidedForms != null)
                                {
                                    var arbitrators = new List<Dictionary<string, object>>();

                                    foreach (var arbitratorForm in form.ArbitratorProvidedForms)
                                    {
                                        var arbitratorDic = new Dictionary<string, object>();
                                       
                                        var arbitrator = arbitratorForm.Arbitrator;
                                       
                                        foreach (var arbitratorColumn in arbitratorColumns)
                                        {
                                            var value = arbitrator.GetType().GetProperty(arbitratorColumn)?.GetValue(arbitrator, null);
                                            arbitratorDic[arbitratorColumn] = value!;
                                        }

                                        arbitrators.Add(arbitratorDic);
                                    }

                                    formDict["Arbitrators"] = arbitrators;
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
