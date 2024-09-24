using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorFormModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetFormsWithArbitrators
{
    public class GetFormsWithArbitratorsQueryHandler
        : IRequestHandler<GetFormsWithArbitratorsQuery, BaseResponse<List<FormsWithArbitratorsDto>>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<ArbitratorForm> _arbitratorFormRepository;
        private readonly IAsyncRepository<Arbitrator> _arbitratorRepository;
        private readonly IMapper _mapper;

        public GetFormsWithArbitratorsQueryHandler(IAsyncRepository<ArbitratorForm> arbitratorFormRepository, IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IAsyncRepository<Category> categoryRepository, IAsyncRepository<Arbitrator> arbitratorRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _categoryRepository = categoryRepository;
            _cycleRepository = cycleRepository;
            _arbitratorRepository = arbitratorRepository;
            _arbitratorFormRepository = arbitratorFormRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<FormsWithArbitratorsDto>>> Handle(GetFormsWithArbitratorsQuery request, CancellationToken cancellationToken)
        {
            var cycle = request.CycleId == null
                ? await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active)
                : await _cycleRepository.FirstOrDefaultAsync(c => c.Id == request.CycleId);


            if (cycle == null)
            {
                return new BaseResponse<List<FormsWithArbitratorsDto>>("", false, 200, new List<FormsWithArbitratorsDto>());
            }

            var Categories = await _categoryRepository
                .Where(c => c.CycleId == cycle!.Id && c.ParentId == null)
                .ToListAsync();
            
            var SubCategories = await _categoryRepository
                .Where(x => x.ParentId != null
                    ? (Categories.Select(y => y.Id).Any(y => y == x.ParentId))
                    : false)
                .Include(x => x.Parent)
                .ToListAsync();

            var providedForms = await _formRepository
                .Where(f => f.categoryId != null
                ? (SubCategories.Select(x => x.Id).Any(x=>x == f.categoryId))
                : false)
                .ToListAsync();



            var data = new List<FormsWithArbitratorsDto>();

            for(int i = 0; i < providedForms.Count(); i++)
            {
                var subCategory = SubCategories.FirstOrDefault(s => s.Id == providedForms[i].categoryId);

                var category = Categories.FirstOrDefault(c => c.Id == subCategory!.ParentId);

                var Arbitrators = await _arbitratorFormRepository
                    .Where(a => a.ProvidedFormId == providedForms[i].Id)
                    .Include(a => a.Arbitrator)
                    .Select(a => a.Arbitrator.ArabicName)
                    .ToListAsync();

                var FormsWithArbitratorsDto = new FormsWithArbitratorsDto()
                {
                    Id = providedForms[i].Id,
                    CategoryName = category!.ArabicName,
                    SubCategoryName = subCategory!.ArabicName,
                    ArbitratorsNames = Arbitrators,
                    CycleNumber = cycle.CycleNumber
                };

                data.Add(FormsWithArbitratorsDto);
            }

            return new BaseResponse<List<FormsWithArbitratorsDto>>("", true, 200, data);
        }
    }
}
