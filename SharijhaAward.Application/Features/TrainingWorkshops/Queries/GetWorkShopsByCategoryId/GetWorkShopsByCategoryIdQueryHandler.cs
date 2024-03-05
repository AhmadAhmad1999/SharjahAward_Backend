using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId
{
    public class GetWorkShopsByCategoryIdQueryHandler
        : IRequestHandler<GetWorkShopsByCategoryIdQuery, BaseResponse<List<TrainingWorkshopListVm>>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _workShopRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetWorkShopsByCategoryIdQueryHandler(IAsyncRepository<TrainingWorkshop> workShopRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _workShopRepository = workShopRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<TrainingWorkshopListVm>>> Handle(GetWorkShopsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if (category != null)
            {
                var WorkShops = _workShopRepository.Where(w => w.CategoryId == request.CategoryId).ToList();
                var data = _mapper.Map<List<TrainingWorkshopListVm>>(WorkShops);
                for (int i = 0; i < data.Count; i++)
                {
                    data[i].Title = request.lang == "en" ? data[i].EnglishTitle : data[i].ArabicTitle;
                }

                return new BaseResponse<List<TrainingWorkshopListVm>>("", true, 200, data);
            }
            return new BaseResponse<List<TrainingWorkshopListVm>>("", false, 404);
        }
    }
}
