using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributeForDependency
{
    public class GetAllDynamicAttributeForDependencyHandler : IRequestHandler<GetAllDynamicAttributeForDependencyQuery,
        BaseResponse<List<GetAllDynamicAttributeForDependencyListVM>>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        public GetAllDynamicAttributeForDependencyHandler(IMapper Mapper,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _Mapper = Mapper;
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }
        public async Task<BaseResponse<List<GetAllDynamicAttributeForDependencyListVM>>> Handle(GetAllDynamicAttributeForDependencyQuery Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllDynamicAttributeForDependencyListVM> DynamicAttributes = await _DynamicAttributeRepository
                    .Include(x => x.DynamicAttributeSection!)
                    .Where(x => x.DynamicAttributeSection!.RecordIdOnRelation == Request.CategoryId &&
                        x.DynamicAttributeSection.AttributeTableNameId == Request.AttributeTableNameId)
                    .Select(x => new GetAllDynamicAttributeForDependencyListVM()
                    {
                        Id = x.Id,
                        Label = Language == "ar"
                            ? x.ArabicLabel
                            : x.EnglishLabel
                    }).ToListAsync();

            return new BaseResponse<List<GetAllDynamicAttributeForDependencyListVM>>(ResponseMessage, true, 200, DynamicAttributes, 0);
        }
    }
}
