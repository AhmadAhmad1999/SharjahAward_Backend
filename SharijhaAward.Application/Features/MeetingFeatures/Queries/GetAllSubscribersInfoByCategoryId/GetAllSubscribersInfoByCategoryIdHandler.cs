﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetAllSubscribersInfoByCategoryId
{
    public class GetAllSubscribersInfoByCategoryIdHandler 
        : IRequestHandler<GetAllSubscribersInfoByCategoryIdQuery, BaseResponse<List<GetAllSubscribersInfoByCategoryIdListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        public GetAllSubscribersInfoByCategoryIdHandler(IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository)
        {
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
        }

        public async Task<BaseResponse<List<GetAllSubscribersInfoByCategoryIdListVM>>> 
            Handle(GetAllSubscribersInfoByCategoryIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            var FormsEntities = await _ProvidedFormRepository
                .Where(x => Request.Ids.Any(y => y == x.categoryId) && x.PercentCompletion == 100)
                .OrderByDescending(x => x.CreatedAt)
                .Skip((Request.page - 1) * Request.perPage)
                .Take(Request.perPage)
                .Select(x => new
                {
                    x.User!.Email,
                    FormId = x.Id
                }).ToListAsync();

            var SubscribersNames = await _DynamicAttributeValueRepository
                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                    x.DynamicAttribute.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                    FormsEntities.Select(y => y.FormId).Any(y => y == x.RecordId))
                .Select(x => new
                {
                    x.Value,
                    x.RecordId
                }).ToListAsync();

            List<GetAllSubscribersInfoByCategoryIdListVM> Response = FormsEntities
                .Select(x => new GetAllSubscribersInfoByCategoryIdListVM()
                {
                    FormId = x.FormId,
                    Email = x.Email,
                    Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.FormId)!.Value
                }).ToList();

            int TotalCount = await _ProvidedFormRepository
                .GetCountAsync(x => Request.Ids.Any(y => y == x.categoryId) && x.PercentCompletion == 100);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllSubscribersInfoByCategoryIdListVM>>(ResponseMessage, true, 200,
                Response, PaginationParameter);
        }
    }
}
