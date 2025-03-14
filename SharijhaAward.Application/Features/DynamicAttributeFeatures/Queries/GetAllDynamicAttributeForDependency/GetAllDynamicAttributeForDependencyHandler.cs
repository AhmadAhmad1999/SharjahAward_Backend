﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributeForDependency
{
    public class GetAllDynamicAttributeForDependencyHandler : IRequestHandler<GetAllDynamicAttributeForDependencyQuery,
        BaseResponse<List<GetAllDynamicAttributeForDependencyListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        public GetAllDynamicAttributeForDependencyHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }
        public async Task<BaseResponse<List<GetAllDynamicAttributeForDependencyListVM>>> 
            Handle(GetAllDynamicAttributeForDependencyQuery Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            if (Request.InviteeType is null &&
                Request.EventId is null &&
                Request.CategoryId is not null)
            {
                List<GetAllDynamicAttributeForDependencyListVM> DynamicAttributes = await _DynamicAttributeRepository
                    .Where(x => x.DynamicAttributeSection!.RecordIdOnRelation == Request.CategoryId &&
                        x.DynamicAttributeSection!.AttributeTableNameId == Request.AttributeTableNameId &&
                        !x.DynamicAttributeSection!.TableTypeSection)
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new GetAllDynamicAttributeForDependencyListVM()
                    {
                        Id = x.Id,
                        Label = Language == "ar"
                            ? x.ArabicLabel
                            : x.EnglishLabel
                    }).ToListAsync();

                return new BaseResponse<List<GetAllDynamicAttributeForDependencyListVM>>(ResponseMessage, true, 200, DynamicAttributes, 0);
            }
            else if (Request.InviteeType is not null &&
                Request.EventId is not null &&
                Request.CategoryId is null)
            {
                List<GetAllDynamicAttributeForDependencyListVM> DynamicAttributes = await _DynamicAttributeRepository
                    .Where(x => x.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId &&
                        x.DynamicAttributeSection!.InviteeType == Request.InviteeType &&
                        !x.DynamicAttributeSection!.TableTypeSection &&
                        x.DynamicAttributeSection!.AttributeTableNameId == Request.AttributeTableNameId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new GetAllDynamicAttributeForDependencyListVM()
                    {
                        Id = x.Id,
                        Label = Language == "ar"
                            ? x.ArabicLabel
                            : x.EnglishLabel
                    }).ToListAsync();

                return new BaseResponse<List<GetAllDynamicAttributeForDependencyListVM>>(ResponseMessage, true, 200, DynamicAttributes, 0);
            }
            else
                return new BaseResponse<List<GetAllDynamicAttributeForDependencyListVM>>(ResponseMessage, true, 200, new List<GetAllDynamicAttributeForDependencyListVM>(), 0);
        }
    }
}
