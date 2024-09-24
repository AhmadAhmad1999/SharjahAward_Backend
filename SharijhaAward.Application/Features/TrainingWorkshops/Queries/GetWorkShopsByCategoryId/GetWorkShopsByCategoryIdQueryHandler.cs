using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments;
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
        private readonly IAsyncRepository<TrainingWrokshopeAttachment> _TrainingWrokshopeAttachmentRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetWorkShopsByCategoryIdQueryHandler(
            IAsyncRepository<TrainingWorkshop> workShopRepository,
            IAsyncRepository<TrainingWrokshopeAttachment> TrainingWrokshopeAttachmentRepository,
            IAsyncRepository<Category> categoryRepository, 
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor
            )
        {
            _workShopRepository = workShopRepository;
            _TrainingWrokshopeAttachmentRepository = TrainingWrokshopeAttachmentRepository;
            _categoryRepository = categoryRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<TrainingWorkshopListVm>>> Handle(GetWorkShopsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            var category = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == request.CategoryId);
            if (category != null)
            {
                var WorkShops = _workShopRepository.WhereThenInclude(
                    w => w.CategoryId == request.CategoryId, filterObject)
                    .Skip((request.page - 1) * request.perPage)
                    .Take(request.perPage)
                    .ToList();

                var data = _mapper.Map<List<TrainingWorkshopListVm>>(WorkShops);

                List<TrainingWrokshopeAttachment> AllTrainingWrokshopeAttachmentEntitites = await _TrainingWrokshopeAttachmentRepository
                    .Where(x => data.Select(y => y.Id).Contains(x.WorkshopeId))
                    .ToListAsync();

                for (int i = 0; i < data.Count; i++)
                {
                    data[i].Attachments = AllTrainingWrokshopeAttachmentEntitites
                        .Where(x => x.WorkshopeId == data[i].Id)
                        .Select(x => new WorkshopAttachmentListVM()
                        {
                            Id = x.Id,
                            ArabicName = x.ArabicName,
                            AttachementURl = x.AttachementPath,
                            AttachmentType = x.AttachmentType,
                            EnglishName = x.EnglishName,
                            SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                            Name = request.lang == "en"
                                ? x.EnglishName
                                : x.ArabicName
                        }).ToList();
                    
                    data[i].Title = request.lang == "en" ? data[i].EnglishTitle : data[i].ArabicTitle;
                }

                data = data.OrderByDescending(t => t.CreatedAt).ToList();

                var count = await _workShopRepository.GetCountAsync(w => w.CategoryId == category.Id);
                
                Pagination pagination = new Pagination(request.page, request.perPage, count);
               
                return new BaseResponse<List<TrainingWorkshopListVm>>("", true, 200, data,pagination);
            }

            return new BaseResponse<List<TrainingWorkshopListVm>>("", false, 404);
        }
    }
}
