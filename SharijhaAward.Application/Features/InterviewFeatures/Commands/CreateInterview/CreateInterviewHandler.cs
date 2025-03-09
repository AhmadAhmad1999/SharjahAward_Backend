using AutoMapper;
using Google.Apis.Auth.OAuth2.Responses;
using MediatR;
using Microsoft.Graph.Models;
using Newtonsoft.Json;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Net.Http.Headers;
using System.Text;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateInterview
{
    public class CreateInterviewHandler : IRequestHandler<CreateInterviewCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        private readonly IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository;
        private readonly IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository;
        private readonly HttpClient _HttpClient;
        public CreateInterviewHandler(IMapper _Mapper,
            IAsyncRepository<Interview> _InterviewRepository,
            IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository,
            IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository,
            IAsyncRepository<InterviewInviteeNoteAndQuestion> _InterviewInviteeNoteAndQuestionRepository,
            HttpClient _HttpClient)
        {
            this._Mapper = _Mapper;
            this._InterviewRepository = _InterviewRepository;
            this._InterviewInviteeRepository = _InterviewInviteeRepository;
            this._InterviewInviteeParticipantRepository = _InterviewInviteeParticipantRepository;
            this._InterviewInviteeNoteAndQuestionRepository = _InterviewInviteeNoteAndQuestionRepository;
            this._HttpClient = _HttpClient;
        }

        public async Task<BaseResponse<object>> Handle(CreateInterviewCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.Type == Domain.Constants.MeetingTypes.OnSite &&
                string.IsNullOrEmpty(Request.Address))
            {
                ResponseMessage = Request.lang == "en"
                    ? "If the interview type is onsite then you have to insert the address"
                    : "إذا كان نوع المقابلة في الموقع، فيجب عليك إدخال العنوان";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
            else if (Request.Type == Domain.Constants.MeetingTypes.Virtual &&
                Request.Invitees.Any(x => string.IsNullOrEmpty(x.InviteeLink)))
            {
                ResponseMessage = Request.lang == "en"
                    ? "If the interview type is virtual then you have to insert the invitee link for all the invitees"
                    : "إذا كان نوع المقابلة افتراضيًا، فيجب عليك إدخال رابط المدعوين لجميع المدعوين";

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
                    Interview NewInterviewEntity = _Mapper.Map<Interview>(Request);

                    await _InterviewRepository.AddAsync(NewInterviewEntity);

                    IEnumerable<InterviewInviteeParticipant> NewInterviewInviteeParticipantEntities = new List<InterviewInviteeParticipant>();
                    IEnumerable<InterviewInviteeNoteAndQuestion> NewInterviewInviteeNoteAndQuestionEntities = new List<InterviewInviteeNoteAndQuestion>();

                    foreach (CreateInterviewInviteeDto Invitee in Request.Invitees)
                    {
                        IEnumerable<string> CheckForDuplicatedEmails = Invitee.ExternalUsersEmails
                            .GroupBy(x => x.ToLower())
                            .Where(x => x.Count() > 1)
                            .Select(x => x.Key);

                        if (CheckForDuplicatedEmails.Any())
                        {
                            ResponseMessage = Request.lang == "en"
                                ? $"in invitee number: {Invitee.OrderId}, the following emails are duplicated: {string.Join(", ", CheckForDuplicatedEmails)}"
                                : $"في الدعوة ذات الرقم: {Invitee.OrderId} البُرُد الإلكترونية التالية مكررة: {string.Join(", ", CheckForDuplicatedEmails)}";

                            return new BaseResponse<object>(ResponseMessage, false, 400);
                        }

                        if (Invitee.SubscribersIds.Any())
                            Invitee.SubscribersIds = Invitee.SubscribersIds.Distinct().ToList();

                        if (Invitee.ArbitratorsIds.Any())
                            Invitee.ArbitratorsIds = Invitee.ArbitratorsIds.Distinct().ToList();

                        var NewOnlineMeeting = new
                        {
                            startDateTime = NewInterviewEntity.StartDate
                                .AddMinutes(NewInterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1)),
                            endDateTime = NewInterviewEntity.StartDate
                                .AddMinutes(NewInterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1))
                                .AddMinutes(NewInterviewEntity.PeriodOfEachInviteeInMinutes),
                            subject = NewInterviewEntity.ArabicName + " - " + NewInterviewEntity.EnglishName
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
                            InterviewId = NewInterviewEntity.Id,
                            StartDate = NewInterviewEntity.StartDate
                                .AddMinutes(NewInterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1)),
                            EndDate = NewInterviewEntity.StartDate
                                .AddMinutes(NewInterviewEntity.PeriodOfEachInviteeInMinutes * (Invitee.OrderId + 1))
                                .AddMinutes(NewInterviewEntity.PeriodOfEachInviteeInMinutes),
                            InviteeLink = Invitee.InviteeLink
                        };

                        await _InterviewInviteeRepository.AddAsync(NewInterviewInviteeEntity);

                        IEnumerable<InterviewInviteeParticipant> InviteeArbitrators = Invitee.ArbitratorsIds
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                ArbitratorId = x,
                                CanImplementTheInterview = true
                            });

                        IEnumerable<InterviewInviteeParticipant> InviteeSubscribers = Invitee.SubscribersIds
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                SubscriberId = x,
                                CanImplementTheInterview = true
                            });

                        IEnumerable<InterviewInviteeParticipant> InviteeExternalUsers = Invitee.ExternalUsersEmails
                            .Select(x => new InterviewInviteeParticipant()
                            {
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                ExternalUserEmail = x,
                                CanImplementTheInterview = true
                            });

                        NewInterviewInviteeParticipantEntities = NewInterviewInviteeParticipantEntities
                            .Concat(InviteeArbitrators)
                            .Concat(InviteeSubscribers)
                            .Concat(InviteeExternalUsers);

                        IEnumerable<InterviewInviteeNoteAndQuestion> InviteeNotes = Invitee.Notes
                            .Select(x => new InterviewInviteeNoteAndQuestion()
                            {
                                ArabicText = x.ArabicText,
                                EnglishText = x.EnglishText,
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                isQuestion = false
                            });

                        IEnumerable<InterviewInviteeNoteAndQuestion> InviteeQuestions = Invitee.Questions
                            .Select(x => new InterviewInviteeNoteAndQuestion()
                            {
                                ArabicText = x.ArabicText,
                                EnglishText = x.EnglishText,
                                InterviewInviteeId = NewInterviewInviteeEntity.Id,
                                isQuestion = true
                            });

                        NewInterviewInviteeNoteAndQuestionEntities = NewInterviewInviteeNoteAndQuestionEntities
                            .Concat(InviteeNotes)
                            .Concat(InviteeQuestions);
                    }

                    await _InterviewInviteeParticipantRepository.AddRangeAsync(NewInterviewInviteeParticipantEntities);
                    await _InterviewInviteeNoteAndQuestionRepository.AddRangeAsync(NewInterviewInviteeNoteAndQuestionEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المقابلة بنجاح";

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