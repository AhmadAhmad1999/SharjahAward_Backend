using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllChangeStatusRequestsByProvidedFormId
{
    public class GetAllChangeStatusRequestsByProvidedFormIdHandler 
        : IRequestHandler<GetAllChangeStatusRequestsByProvidedFormIdQuery, BaseResponse<List<GetAllChangeStatusRequestsByProvidedFormIdListVM>>>
    {
        private readonly IAsyncRepository<RequestForChangeInterviewEligibilityStatus> _RequestForChangeInterviewEligibilityStatusRepository;
        public GetAllChangeStatusRequestsByProvidedFormIdHandler(IAsyncRepository<RequestForChangeInterviewEligibilityStatus> _RequestForChangeInterviewEligibilityStatusRepository)
        {
            this._RequestForChangeInterviewEligibilityStatusRepository = _RequestForChangeInterviewEligibilityStatusRepository;
        }

        public async Task<BaseResponse<List<GetAllChangeStatusRequestsByProvidedFormIdListVM>>> 
            Handle(GetAllChangeStatusRequestsByProvidedFormIdQuery Request, CancellationToken cancellationToken)
        {
            List<GetAllChangeStatusRequestsByProvidedFormIdListVM> Response = await _RequestForChangeInterviewEligibilityStatusRepository
                .Where(x => x.ProvidedFormId == Request.ProvidedFormId)
                .Select(x => new GetAllChangeStatusRequestsByProvidedFormIdListVM()
                {
                    Note = x.Note,
                    RequestedByEmail = x.RequestedBy!.Email,
                    RequestedById = x.RequestedById,
                    RequestedByName = Request.lang == "en"
                        ? x.RequestedBy!.EnglishName
                        : x.RequestedBy!.ArabicName
                }).ToListAsync();

            return new BaseResponse<List<GetAllChangeStatusRequestsByProvidedFormIdListVM>>(string.Empty, true, 200, Response);
        }
    }
}
