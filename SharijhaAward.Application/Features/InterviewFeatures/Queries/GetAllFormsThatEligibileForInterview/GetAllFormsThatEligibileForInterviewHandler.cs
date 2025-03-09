using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllFormsThatEligibileForInterview
{
    public class GetAllFormsThatEligibileForInterviewHandler
        : IRequestHandler<GetAllFormsThatEligibileForInterviewQuery, BaseResponse<List<GetAllFormsThatEligibileForInterviewListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        public GetAllFormsThatEligibileForInterviewHandler(IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository)
        {
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
        }

        public async Task<BaseResponse<List<GetAllFormsThatEligibileForInterviewListVM>>> 
            Handle(GetAllFormsThatEligibileForInterviewQuery Request, CancellationToken cancellationToken)
        {
            List<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormEntities = new List<Domain.Entities.ProvidedFormModel.ProvidedForm>();
            
            if (Request.page != 0 &&
                Request.perPage != -1)
            {
                ProvidedFormEntities = await _ProvidedFormRepository
                    .Where(x => x.EligibileForInterview &&
                        x.Category!.Cycle!.Status == Domain.Constants.Common.Status.Active)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToListAsync();
            }
            else
            {
                ProvidedFormEntities = await _ProvidedFormRepository
                    .Where(x => x.EligibileForInterview &&
                        x.Category!.Cycle!.Status == Domain.Constants.Common.Status.Active)
                    .ToListAsync();
            }

            var SubscribersNames = await _DynamicAttributeValueRepository
                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                    x.DynamicAttribute.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                    ProvidedFormEntities.Select(y => y.Id).Any(y => y == x.RecordId))
                .Select(x => new
                {
                    x.Value,
                    x.RecordId
                }).ToListAsync();

            List<GetAllFormsThatEligibileForInterviewListVM> Response = ProvidedFormEntities
                .Select(x => new GetAllFormsThatEligibileForInterviewListVM()
                {
                    SubscriberId = x.userId,
                    Email = x.User!.Email,
                    SubscriberName = SubscribersNames
                        .FirstOrDefault(y => y.RecordId == x.Id)?.Value ?? string.Empty
                }).ToList();

            int TotalCount = await _ProvidedFormRepository
                .GetCountAsync(x => x.EligibileForInterview &&
                    x.Category!.Cycle!.Status == Domain.Constants.Common.Status.Active);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllFormsThatEligibileForInterviewListVM>>(string.Empty, true, 200,
                Response, PaginationParameter);
        }
    }
}
