using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingModel;
using Microsoft.Graph;
using Azure.Identity;
using Microsoft.Graph.Models;
using Azure.Core;
using FirebaseAdmin.Auth.Multitenancy;
using Google.Apis.Auth.OAuth2;
using Aspose.Pdf.Operators;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using Google.Apis.Auth.OAuth2.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeetingURL
{
    public class CreateMeetingURLHandler : IRequestHandler<CreateMeetingURLCommand, BaseResponse<OnlineMeeting>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly HttpClient _httpClient;
        public CreateMeetingURLHandler(IAsyncRepository<Meeting> MeetingRepository,
            HttpClient _httpClient)
        {
            _MeetingRepository = MeetingRepository;
            this._httpClient = _httpClient;
        }

        public async Task<BaseResponse<OnlineMeeting>> Handle(CreateMeetingURLCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Meeting? MeetingEntity = await _MeetingRepository
                .FirstOrDefaultAsync(x => x.Id == Request.MeetingId);

            if (MeetingEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Meeting is not Found"
                    : "الاجتماع غير موجود";

                return new BaseResponse<OnlineMeeting>(ResponseMessage, false, 404);
            }

            string? AccessToken = await GetAccessTokenAsync(Request.TenantId, Request.ClientId, Request.ClientSecret);
            
            if (string.IsNullOrEmpty(AccessToken))
                return new BaseResponse<OnlineMeeting>("Failed to acquire access token.", false, 500);

            string CreateMeetingExternalAPI = "https://graph.microsoft.com/v1.0/users/b1ea9cf6-8581-47bc-bda8-18f6f5b4c9b2/onlineMeetings";
            
            var NewOnlineMeeting = new
            {
                startDateTime = DateTime.UtcNow,
                endDateTime = DateTime.UtcNow.AddHours(1),
                subject = "Test Subject"
            };

            var content = new StringContent(JsonConvert.SerializeObject(NewOnlineMeeting), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                var response = await _httpClient.PostAsync(CreateMeetingExternalAPI, content, cancellationToken);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var createdMeeting = JsonConvert.DeserializeObject<OnlineMeeting>(responseBody);
                    return new BaseResponse<OnlineMeeting>(createdMeeting.JoinWebUrl, true, 200);
                }
                else
                {
                    var errorResponse = await response.Content.ReadAsStringAsync();
                    return new BaseResponse<OnlineMeeting>($"Error creating meeting: {errorResponse}", false, (int)response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                return new BaseResponse<OnlineMeeting>($"An error occurred: {ex.Message}", false, 500);
            }
        }
        private async Task<string> GetAccessTokenAsync(string tenantId, string clientId, string clientSecret)
        {
            var tokenUrl = $"https://login.microsoftonline.com/{tenantId}/oauth2/v2.0/token";
            var tokenRequest = new HttpRequestMessage(HttpMethod.Post, tokenUrl);

            var formData = new Dictionary<string, string>
        {
            { "grant_type", "client_credentials" },
            { "client_id", clientId },
            { "client_secret", clientSecret },
            { "scope", "https://graph.microsoft.com/.default" }
        };

            tokenRequest.Content = new FormUrlEncodedContent(formData);

            var response = await _httpClient.SendAsync(tokenRequest);
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseBody);
                return tokenResponse.AccessToken;
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Failed to acquire access token: {errorResponse}");
            }
        }
    }
}
