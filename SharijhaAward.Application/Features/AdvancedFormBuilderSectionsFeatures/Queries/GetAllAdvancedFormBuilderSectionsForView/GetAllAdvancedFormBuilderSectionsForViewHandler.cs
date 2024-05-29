﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuildersBySectionId;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForView
{
    public class GetAllAdvancedFormBuilderSectionsForViewHandler : IRequestHandler<GetAllAdvancedFormBuilderSectionsForViewQuery,
        BaseResponse<List<AdvancedFormBuilderSectionListVM>>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;

        public GetAllAdvancedFormBuilderSectionsForViewHandler(IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IAsyncRepository<VirtualTableForSection> VirtualTableForSectionRepository)
        {
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _VirtualTableForSectionRepository = VirtualTableForSectionRepository;
        }

        public async Task<BaseResponse<List<AdvancedFormBuilderSectionListVM>>> 
            Handle(GetAllAdvancedFormBuilderSectionsForViewQuery Request, CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

            string ResponseMessage = string.Empty;

            VirtualTableForSection? VirtualTableForSectionEntity = await _VirtualTableForSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.VirtualTableForSectionId);

            if (VirtualTableForSectionEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Virtual table for section is not found"
                    : "الجدول الافتراضي للقسم غير موجود";

                return new BaseResponse<List<AdvancedFormBuilderSectionListVM>>(ResponseMessage, false, 404);
            }

            List<AdvancedFormBuilderSectionListVM> DynamicAttributeSections = new List<AdvancedFormBuilderSectionListVM>();

            if (Request.page != 0 && Request.pageSize != -1)
                DynamicAttributeSections = await _AdvancedFormBuilderSectionRepository
                    .Where(x => x.VirtualTableForSectionId == Request.VirtualTableForSectionId)
                    .OrderBy(x => x.OrderId)
                    .Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .Select(x => new AdvancedFormBuilderSectionListVM()
                    {
                        Id = x.Id,
                        Name = Language == "ar"
                            ? x.ArabicName
                            : x.EnglishName,
                        TableTypeSection = x.TableTypeSection
                    }).ToListAsync();

            else
                DynamicAttributeSections = await _AdvancedFormBuilderSectionRepository
                    .Where(x => x.VirtualTableForSectionId == Request.VirtualTableForSectionId)
                    .OrderBy(x => x.OrderId)
                    .Select(x => new AdvancedFormBuilderSectionListVM()
                    {
                        Id = x.Id,
                        Name = Language == "ar"
                            ? x.ArabicName
                            : x.EnglishName,
                        TableTypeSection = x.TableTypeSection
                    }).ToListAsync();

            List<AdvancedFormBuilder> AdvancedFormBuilderEntities = await _AdvancedFormBuilderRepository
                .Where(x => DynamicAttributeSections.Select(y => y.Id).Contains(x.AdvancedFormBuilderSectionId))
                .Include(x => x.AttributeDataType!)
                .ToListAsync();

            foreach (AdvancedFormBuilderSectionListVM DynamicAttributeSection in DynamicAttributeSections)
            {
                DynamicAttributeSection.AdvancedFormBuilders = AdvancedFormBuilderEntities
                    .Where(x => x.AdvancedFormBuilderSectionId == DynamicAttributeSection.Id)
                    .OrderBy(x => x.OrderId)
                    .Select(x => new AdvancedFormBuilderListVM()
                    {
                        Id = x.Id,
                        AttributeDataTypeName = x.AttributeDataType!.Name,
                        Label = Language.ToLower() == "ar"
                            ? x.ArabicLabel
                            : x.EnglishLabel,
                        PlaceHolder = Language.ToLower() == "ar"
                            ? x.ArabicPlaceHolder
                            : x.EnglishPlaceHolder,
                        Status = x.Status.ToString()
                    }).ToList();
            }




            throw new NotImplementedException();
        }
    }
}
