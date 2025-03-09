using AutoMapper;
using Google.Apis.Auth.OAuth2.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using Newtonsoft.Json;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Net.Http.Headers;
using System.Text;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.UpdateInterview
{
    public class UpdateInterviewHandler : IRequestHandler<UpdateInterviewCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        private readonly IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository;
        private readonly IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository;
        private readonly IMapper _Mapper;
        private readonly HttpClient _HttpClient;

        public UpdateInterviewHandler(IAsyncRepository<Interview> _InterviewRepository,
            IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository,
            IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository,
            IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository,
            IMapper _Mapper,
            HttpClient _HttpClient)
        {
            this._InterviewRepository = _InterviewRepository;
            this._InterviewInviteeRepository = _InterviewInviteeRepository;
            this._InterviewInviteeParticipantRepository = _InterviewInviteeParticipantRepository;
            this._InterviewInviteeNoteAndQuestionRepository = _InterviewInviteeNoteAndQuestionRepository;
            this._Mapper = _Mapper;
            this._HttpClient = _HttpClient;
        }

        public async Task<BaseResponse<object>> Handle(UpdateInterviewCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Interview? InterviewEntity = await _InterviewRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (InterviewEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview is not Found"
                    : "المقابلة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (Request.Type == Domain.Constants.MeetingTypes.OnSite &&
                string.IsNullOrEmpty(Request.Address) ||
                (InterviewEntity.Type == Domain.Constants.MeetingTypes.OnSite &&
                string.IsNullOrEmpty(Request.Address) &&
                Request.Type == Domain.Constants.MeetingTypes.OnSite))
            {
                ResponseMessage = Request.lang == "en"
                    ? "If the interview type is onsite then you have to insert the address"
                    : "إذا كان نوع المقابلة في الموقع، فيجب عليك إدخال العنوان";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            string? AccessToken = await GetAccessTokenAsync(Request.TenantId!, Request.ClientId!, Request.ClientSecret!);

            if (string.IsNullOrEmpty(AccessToken))
                return new BaseResponse<object>("Failed to acquire access token.", false, 500);

            string CreateMeetingExternalAPI = "https://graph.microsoft.com/v1.0/users/b1ea9cf6-8581-47bc-bda8-18f6f5b4c9b2/onlineMeetings";

            _HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            _HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    _Mapper.Map(Request, InterviewEntity, typeof(UpdateInterviewCommand), typeof(Interview));
                    
                    await _InterviewRepository.UpdateAsync(InterviewEntity);

                    IEnumerable<InterviewInviteeNoteAndQuestion> InterviewInviteeNoteAndQuestionEntitiesToAdd = new List<InterviewInviteeNoteAndQuestion>();
                    
                    IEnumerable<InterviewInviteeParticipant> InterviewInviteeParticipantEntitiesToAdd = new List<InterviewInviteeParticipant>();

                    List<InterviewInvitee> InterviewInviteeEntities = await _InterviewInviteeRepository
                        .Where(x => Request.Invitees.Select(y => y.Id).Contains(x.Id))
                        .ToListAsync();

                    IEnumerable<InterviewInviteeNoteAndQuestion> InterviewInviteeNoteAndQuestionEntitiesToDelete = await _InterviewInviteeNoteAndQuestionRepository
                        .Where(x => InterviewInviteeEntities.Select(y => y.Id).Contains(x.InterviewInviteeId))
                        .ToListAsync();

                    IEnumerable<InterviewInviteeParticipant> InterviewInviteeParticipantEntitiesToDelete = await _InterviewInviteeParticipantRepository
                        .Where(x => InterviewInviteeEntities.Select(y => y.Id).Contains(x.InterviewInviteeId))
                        .ToListAsync();

                    foreach (UpdateInterviewInviteeDto Invitee in Request.Invitees)
                    {
                        int InterviewInviteeEntityId = 0;

                        if (Invitee.Id is not 0)
                            InterviewInviteeEntityId = Invitee.Id;

                        else
                        {
                            var NewOnlineMeeting = new
                            {
                                startDateTime = InterviewEntity.StartDate
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1)),
                                endDateTime = InterviewEntity.StartDate
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1))
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes),
                                subject = InterviewEntity.ArabicName + " - " + InterviewEntity.EnglishName
                            };

                            StringContent StringContent = new StringContent(JsonConvert.SerializeObject(NewOnlineMeeting), Encoding.UTF8, "application/json");

                            var Response = await _HttpClient.PostAsync(CreateMeetingExternalAPI, StringContent, cancellationToken);

                            string InviteeLink = string.Empty;

                            if (Response.IsSuccessStatusCode)
                            {
                                string ResponseBody = await Response.Content.ReadAsStringAsync();
                                OnlineMeeting? CreatedMeeting = JsonConvert.DeserializeObject<OnlineMeeting>(ResponseBody);

                                if (CreatedMeeting is not null
                                    ? !string.IsNullOrEmpty(CreatedMeeting.JoinWebUrl)
                                    : false)
                                {
                                    InviteeLink = CreatedMeeting.JoinWebUrl;
                                }
                                else
                                {
                                    return new BaseResponse<object>($"Error creating meeting", false, (int)Response.StatusCode);
                                }
                            }
                            else
                            {
                                string ErrorResponse = await Response.Content.ReadAsStringAsync();
                                return new BaseResponse<object>($"Error creating meeting: {ErrorResponse}", false, (int)Response.StatusCode);
                            }

                            InterviewInvitee NewInterviewInviteeEntity = new InterviewInvitee()
                            {
                                OrderId = Invitee.OrderId,
                                InterviewId = InterviewEntity.Id,
                                StartDate = InterviewEntity.StartDate
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1)),
                                EndDate = InterviewEntity.StartDate
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1))
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes),
                                InviteeLink = InviteeLink
                            };

                            await _InterviewInviteeRepository.AddAsync(NewInterviewInviteeEntity);

                            InterviewInviteeEntityId = NewInterviewInviteeEntity.Id;
                        }

                        InterviewInvitee? InterviewInviteeEntityToUpdate = InterviewInviteeEntities
                            .FirstOrDefault(x => x.Id == InterviewInviteeEntityId);

                        if (InterviewInviteeEntityToUpdate is not null)
                        {
                            _Mapper.Map(Invitee, InterviewInviteeEntityToUpdate, typeof(UpdateInterviewInviteeDto), typeof(InterviewInvitee));

                            var NewOnlineMeeting = new
                            {
                                startDateTime = InterviewEntity.StartDate
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1)),
                                endDateTime = InterviewEntity.StartDate
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1))
                                    .AddMinutes(InterviewEntity.PeriodOfEachInviteeInMinutes),
                                subject = InterviewEntity.ArabicName + " - " + InterviewEntity.EnglishName
                            };

                            StringContent StringContent = new StringContent(JsonConvert.SerializeObject(NewOnlineMeeting), Encoding.UTF8, "application/json");

                            var Response = await _HttpClient.PostAsync(CreateMeetingExternalAPI, StringContent, cancellationToken);

                            string InviteeLink = string.Empty;

                            if (Response.IsSuccessStatusCode)
                            {
                                string ResponseBody = await Response.Content.ReadAsStringAsync();
                                OnlineMeeting? CreatedMeeting = JsonConvert.DeserializeObject<OnlineMeeting>(ResponseBody);

                                if (CreatedMeeting is not null
                                    ? !string.IsNullOrEmpty(CreatedMeeting.JoinWebUrl)
                                    : false)
                                {
                                    InviteeLink = CreatedMeeting.JoinWebUrl;
                                }
                                else
                                {
                                    return new BaseResponse<object>($"Error creating meeting", false, (int)Response.StatusCode);
                                }
                            }
                            else
                            {
                                string ErrorResponse = await Response.Content.ReadAsStringAsync();
                                return new BaseResponse<object>($"Error creating meeting: {ErrorResponse}", false, (int)Response.StatusCode);
                            }

                            InterviewInviteeEntityToUpdate.StartDate = Request.StartDate
                                .AddMinutes(Request.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1));

                            InterviewInviteeEntityToUpdate.EndDate = Request.StartDate
                                .AddMinutes(Request.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1))
                                .AddMinutes(Request.PeriodOfEachInviteeInMinutes);

                            InterviewInviteeEntityToUpdate.InviteeLink = InviteeLink;

                            await _InterviewInviteeRepository.UpdateAsync(InterviewInviteeEntityToUpdate);
                        }

                        List<string> CheckForDuplicatedEmails = Invitee.ExternalUsersEmails
                            .GroupBy(x => x.ToLower())
                            .Where(x => x.Count() > 1)
                            .Select(x => x.Key)
                            .ToList();

                        if (CheckForDuplicatedEmails.Any())
                        {
                            ResponseMessage = Request.lang == "en"
                                ? $"in invitee number: {Invitee.OrderId}, the following emails are duplicated: {string.Join(", ", CheckForDuplicatedEmails)}"
                                : $"في الدعوة ذات الرقم: {Invitee.OrderId} البُرُد الإلكترونية التالية مكررة: {string.Join(", ", CheckForDuplicatedEmails)}";

                            return new BaseResponse<object>(ResponseMessage, false, 400);
                        }

                        List<InterviewInviteeNoteAndQuestion> InterviewNoteEntitiesToDelete = await _InterviewInviteeNoteAndQuestionRepository
                            .Where(x => x.InterviewInviteeId == Request.Id)
                            .ToListAsync();

                        InterviewInviteeNoteAndQuestionEntitiesToDelete = InterviewInviteeNoteAndQuestionEntitiesToDelete
                            .Concat(InterviewNoteEntitiesToDelete);

                        if (Invitee.SubscribersIds.Any())
                            Invitee.SubscribersIds = Invitee.SubscribersIds.Distinct().ToList();

                        if (Invitee.ArbitratorsIds.Any())
                            Invitee.ArbitratorsIds = Invitee.ArbitratorsIds.Distinct().ToList();

                        IEnumerable<InterviewInviteeParticipant> InviteeArbitrators = Invitee.ArbitratorsIds
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = InterviewInviteeEntityId,
                                ArbitratorId = x,
                                CanImplementTheInterview = true
                            });

                        IEnumerable<InterviewInviteeParticipant> InviteeSubscribers = Invitee.SubscribersIds
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = InterviewInviteeEntityId,
                                SubscriberId = x,
                                CanImplementTheInterview = true
                            });

                        IEnumerable<InterviewInviteeParticipant> InviteeExternalUsers = Invitee.ExternalUsersEmails
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = InterviewInviteeEntityId,
                                ExternalUserEmail = x,
                                CanImplementTheInterview = true
                            });

                        InterviewInviteeParticipantEntitiesToAdd = InterviewInviteeParticipantEntitiesToAdd
                            .Concat(InviteeArbitrators)
                            .Concat(InviteeSubscribers)
                            .Concat(InviteeExternalUsers);

                        IEnumerable<InterviewInviteeNoteAndQuestion> InviteeNotes = Invitee.Notes
                            .Select(x => new InterviewInviteeNoteAndQuestion()
                            {
                                ArabicText = x.ArabicText,
                                EnglishText = x.EnglishText,
                                InterviewInviteeId = InterviewInviteeEntityId,
                                isQuestion = false
                            });

                        IEnumerable<InterviewInviteeNoteAndQuestion> InviteeQuestions = Invitee.Questions
                            .Select(x => new InterviewInviteeNoteAndQuestion()
                            {
                                ArabicText = x.ArabicText,
                                EnglishText = x.EnglishText,
                                InterviewInviteeId = InterviewInviteeEntityId,
                                isQuestion = true
                            });

                        InterviewInviteeNoteAndQuestionEntitiesToAdd = InterviewInviteeNoteAndQuestionEntitiesToAdd
                            .Concat(InviteeNotes)
                            .Concat(InviteeQuestions);
                    }

                    await _InterviewInviteeParticipantRepository.DeleteListAsync(InterviewInviteeParticipantEntitiesToDelete);
                    await _InterviewInviteeParticipantRepository.AddRangeAsync(InterviewInviteeParticipantEntitiesToAdd);

                    await _InterviewInviteeNoteAndQuestionRepository.DeleteListAsync(InterviewInviteeNoteAndQuestionEntitiesToDelete);
                    await _InterviewInviteeNoteAndQuestionRepository.AddRangeAsync(InterviewInviteeNoteAndQuestionEntitiesToAdd);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Updated successfully"
                        : "تم تعديل المقابلة بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
        private async Task<string> GetAccessTokenAsync(string tenantId, string clientId, string clientSecret)
        {
            string CreateTokenExternalAPIURL = $"https://login.microsoftonline.com/{tenantId}/oauth2/v2.0/token";
            HttpRequestMessage TokenRequest = new HttpRequestMessage(HttpMethod.Post, CreateTokenExternalAPIURL);

            Dictionary<string, string> FormData = new Dictionary<string, string>
            {
                { "grant_type", "client_credentials" },
                { "client_id", clientId },
                { "client_secret", clientSecret },
                { "scope", "https://graph.microsoft.com/.default" }
            };

            TokenRequest.Content = new FormUrlEncodedContent(FormData);

            HttpResponseMessage Response = await _HttpClient.SendAsync(TokenRequest);
            if (Response.IsSuccessStatusCode)
            {
                var responseBody = await Response.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseBody);
                if (tokenResponse is not null)
                    return tokenResponse.AccessToken;

                else
                {
                    var errorResponse = await Response.Content.ReadAsStringAsync();
                    throw new Exception($"Failed to acquire access token: {errorResponse}");
                }
            }
            else
            {
                var errorResponse = await Response.Content.ReadAsStringAsync();
                throw new Exception($"Failed to acquire access token: {errorResponse}");
            }
        }
    }
}
