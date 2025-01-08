using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.ArbitratorFormModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

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

            var cycles = await cyclesQuery.ToListAsync();
            
            var result = new List<Dictionary<string, object>>();
            
            List<Category> AllCategoryEntities = await _context
                .Categories.Where(x => cycles.Select(y => y.Id).Contains(x.CycleId))
                .ToListAsync();

            List<ProvidedForm> AllProvidedFormsEntities = await _context
                .ProvidedForms.Where(x => AllCategoryEntities.Select(y => y.Id).Contains(x.categoryId))
                .ToListAsync();

            List<CoordinatorForm> AllCoordinatorFormEntitites = await _context
                .CoordinatorForms.Where(x => AllProvidedFormsEntities.Select(y => y.Id).Contains(x.ProvidedFormId))
                .ToListAsync();

            List<ArbitratorForm> AllArbitratorFormEntitites = await _context
                .ArbitratorForms.Where(x => AllProvidedFormsEntities.Select(y => y.Id).Contains(x.ProvidedFormId))
                .ToListAsync();

            foreach ( var cycle in cycles)
            {
                List<Category> AllCategoryEntitiesForThisCycle = AllCategoryEntities
                    .Where(x => x.CycleId == cycle.Id)
                    .ToList();

                var cyclesDict = new Dictionary<string, object>();
                
                foreach(var cycleColumn in cyclesColumns)
                {
                    var value = cycle.GetType().GetProperty(cycleColumn)?.GetValue(cycle, null);
                    cyclesDict[cycleColumn] = value!;
                }

                if(categoryColumns.Length > 0 && AllCategoryEntitiesForThisCycle != null)
                {
                    var categories = new List<Dictionary<string, object>>();

                    foreach(var category in AllCategoryEntitiesForThisCycle)
                    {
                        List<ProvidedForm> AllProvidedFormsEntitiesForThisCategory = AllProvidedFormsEntities
                            .Where(x => x.categoryId == category.Id)
                            .ToList();

                        var categoryDict = new Dictionary<string, object>();

                        foreach(var categoryColumn in categoryColumns)
                        {
                            var value = category.GetType().GetProperty(categoryColumn)?.GetValue(category, null);
                            categoryDict[categoryColumn] = value!;
                        }

                        if(providedFormColumns.Length > 0 && AllProvidedFormsEntitiesForThisCategory != null)
                        {
                            var providedForms = new List<Dictionary<string, object>>();

                            foreach (var form in AllProvidedFormsEntitiesForThisCategory)
                            {
                                List<CoordinatorForm> AllCoordinatorFormEntititesForThisForm = AllCoordinatorFormEntitites
                                    .Where(x => x.ProvidedFormId == form.Id)
                                    .ToList();

                                List<ArbitratorForm> AllArbitratorFormEntititesForThisForm = AllArbitratorFormEntitites
                                    .Where(x => x.ProvidedFormId == form.Id)
                                    .ToList();

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

                                if (coordinatorColumns.Length > 0 && AllCoordinatorFormEntititesForThisForm != null)
                                {
                                    var coordinators = new List<Dictionary<string, object>>();

                                    foreach (var coordinatorForm in AllCoordinatorFormEntititesForThisForm)
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

                                if (arbitratorColumns.Length > 0 && AllArbitratorFormEntititesForThisForm != null)
                                {
                                    var arbitrators = new List<Dictionary<string, object>>();

                                    foreach (var arbitratorForm in AllArbitratorFormEntititesForThisForm)
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
