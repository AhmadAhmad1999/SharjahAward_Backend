using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.InterviewModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllFormsByItsEligibleStatus
{
    public class GetAllFormsByItsEligibleStatusHandler 
        : IRequestHandler<GetAllFormsByItsEligibleStatusQuery, BaseResponse<List<GetAllFormsByItsEligibleStatusListVM>>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<RequestForChangeInterviewEligibilityStatus> _RequestForChangeInterviewEligibilityStatusRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        public GetAllFormsByItsEligibleStatusHandler(IAsyncRepository<Interview> _InterviewRepository,
            IAsyncRepository<RequestForChangeInterviewEligibilityStatus> _RequestForChangeInterviewEligibilityStatusRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository)
        {
            this._InterviewRepository = _InterviewRepository;
            this._RequestForChangeInterviewEligibilityStatusRepository = _RequestForChangeInterviewEligibilityStatusRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
        }

        public async Task<BaseResponse<List<GetAllFormsByItsEligibleStatusListVM>>> 
            Handle(GetAllFormsByItsEligibleStatusQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.StatusFilter == StatusFilter.RequestedForChangeStatus)
            {
                List<RequestForChangeInterviewEligibilityStatus> RequestForChangeInterviewEligibilityStatusEntities = await _RequestForChangeInterviewEligibilityStatusRepository
                    .OrderByDescending(x => x.ProvidedFormId, Request.page, Request.perPage)
                    .ToListAsync();

                List<DynamicAttributeValue> SubscribersNames = await _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                        x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                        x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                        RequestForChangeInterviewEligibilityStatusEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId))
                    .ToListAsync();

                List<GetAllFormsByItsEligibleStatusListVM> Response = RequestForChangeInterviewEligibilityStatusEntities
                    .AsEnumerable()
                    .DistinctBy(x => x.ProvidedFormId)
                    .AsEnumerable()
                    .Select(x => new GetAllFormsByItsEligibleStatusListVM()
                    {
                        Id = x.ProvidedFormId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                        
                    }).ToList();

                foreach (var Responses in Response)
                {
                    Responses.SubscriberName = SubscribersNames
                        .FirstOrDefault(y => y.RecordId == Responses.Id)?.Value ?? string.Empty;
                }

                int TotalCount = _RequestForChangeInterviewEligibilityStatusRepository
                    .Where(x => true)
                    .AsEnumerable()
                    .DistinctBy(x => x.ProvidedFormId)
                    .AsEnumerable()
                    .DistinctBy(x => x.ProvidedFormId)
                    .Count();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFormsByItsEligibleStatusListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
            else
            {
                List<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormEntities = new List<Domain.Entities.ProvidedFormModel.ProvidedForm>();
                
                if (Request.page != 0 &&
                    Request.perPage != -1)
                {
                    ProvidedFormEntities = await _ProvidedFormRepository
                        .Where(x => Request.StatusFilter == StatusFilter.NotEligibile
                            ? !x.EligibileForInterview
                            : x.EligibileForInterview)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();
                }
                else
                {
                    ProvidedFormEntities = await _ProvidedFormRepository
                        .Where(x => Request.StatusFilter == StatusFilter.NotEligibile
                            ? !x.EligibileForInterview
                            : x.EligibileForInterview)
                        .ToListAsync();
                }

                List<DynamicAttributeValue> SubscribersNames = await _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                        x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                        x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                        ProvidedFormEntities.Select(y => y.Id).Any(y => y == x.RecordId))
                    .ToListAsync();

                List<GetAllFormsByItsEligibleStatusListVM> Response = ProvidedFormEntities
                    .Select(x => new GetAllFormsByItsEligibleStatusListVM()
                    {
                        Id = x.Id,
                        CategoryName = Request.lang == "en"
                            ? x.Category!.EnglishName
                            : x.Category!.ArabicName,
                        SubscriberName = SubscribersNames
                            .FirstOrDefault(y => y.RecordId == x.Id)?.Value ?? string.Empty
                    }).ToList();

                int TotalCount = await _ProvidedFormRepository
                    .GetCountAsync(x => Request.StatusFilter == StatusFilter.NotEligibile
                        ? !x.EligibileForInterview
                        : x.EligibileForInterview);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFormsByItsEligibleStatusListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
        }
    }
}
