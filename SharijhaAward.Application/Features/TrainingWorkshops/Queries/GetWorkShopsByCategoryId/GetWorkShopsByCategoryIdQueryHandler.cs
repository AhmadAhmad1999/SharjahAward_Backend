using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
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
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetWorkShopsByCategoryIdQueryHandler(
            IAsyncRepository<TrainingWorkshop> workShopRepository, 
            IAsyncRepository<Category> categoryRepository, 
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor
            )
        {
            _workShopRepository = workShopRepository;
            _categoryRepository = categoryRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<TrainingWorkshopListVm>>> Handle(GetWorkShopsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if (category != null)
            {
                var WorkShops = _workShopRepository.WhereThenInclude(w => w.CategoryId == request.CategoryId, w => w.Attachments).ToList();
                var data = _mapper.Map<List<TrainingWorkshopListVm>>(WorkShops);
                 bool isHttps = _httpContextAccessor.HttpContext.Request.IsHttps;

                for (int i = 0; i < data.Count; i++)
                {
                    data[i].Attachments =  _mapper.Map<List<WorkshopAttachmentListVM>>(data[i].Attachments);
                    for(int j = 0; j < data[i].Attachments.Count; j++)
                    {
                        data[i].Attachments[j].Name = request.lang == "en"
                            ? data[i].Attachments[j].EnglishName
                            : data[i].Attachments[j].ArabicName;
                        data[i].Attachments[j].AttachementURl = WorkShops[i].Attachments[j].AttachementPath;
                    }
                    data[i].Title = request.lang == "en" ? data[i].EnglishTitle : data[i].ArabicTitle;
                }

                return new BaseResponse<List<TrainingWorkshopListVm>>("", true, 200, data);
            }
            return new BaseResponse<List<TrainingWorkshopListVm>>("", false, 404);
        }
    }
}
