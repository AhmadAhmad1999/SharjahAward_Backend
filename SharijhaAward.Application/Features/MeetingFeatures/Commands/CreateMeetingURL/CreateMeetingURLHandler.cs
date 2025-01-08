using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingModel;
using Microsoft.Graph;
using Azure.Identity;
using Microsoft.Graph.Models;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeetingURL
{
    public class CreateMeetingURLHandler : IRequestHandler<CreateMeetingURLCommand, BaseResponse<OnlineMeeting>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private static GraphServiceClient _GraphClient;

        public CreateMeetingURLHandler(IAsyncRepository<Meeting> MeetingRepository)
        {
            _MeetingRepository = MeetingRepository;
        }

        public async Task<BaseResponse<OnlineMeeting>> Handle(CreateMeetingURLCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            //Meeting? MeetingEntity = await _MeetingRepository
            //    .FirstOrDefaultAsync(x => x.Id == Request.MeetingId);

            //if (MeetingEntity is null)
            //{
            //    ResponseMessage = Request.lang == "en"
            //        ? "Meeting is not Found"
            //        : "الاجتماع غير موجود";

            //    return new BaseResponse<OnlineMeeting>(ResponseMessage, false, 404);
            //}

            //ClientSecretCredential ClientSecretCredential = new ClientSecretCredential(Request.TenantId, 
            //    Request.ClientId, Request.ClientSecret);

            //_GraphClient = new GraphServiceClient(ClientSecretCredential);

            //// Create OnlineMeeting object
            //OnlineMeeting OnlineMeeting = new OnlineMeeting
            //{
            //    StartDateTime = MeetingEntity.Date,
            //    EndDateTime = DateTime.UtcNow.AddHours(1),
            //    Subject = "Test Subject"
            //};

            var scopes = new[] { "https://graph.microsoft.com/.default" };
            var tenantId = "tenant_Id";
            var clientId = "client_Id";
            var clientSecret = "client_Secret";
            var options = new TokenCredentialOptions
            {
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
            };
            var clientSecretCredential = new ClientSecretCredential(Request.TenantId, Request.ClientId, Request.ClientSecret, options);
            var graphClient = new GraphServiceClient(clientSecretCredential, scopes);

            try
            {
                var xx = await graphClient.Users["award.portal@spea.ae"].GetAsync();

                var message = await graphClient.Users["award.portal@spea.ae"]
                    .MailFolders["inbox"]
                    .Messages["message_ID"]
                    .GetAsync();

                var mimeContentStream = await graphClient.Users["User_ID"]
                    .Messages[message.Id]
                    .Content
                    .GetAsync();

                using (var fileStream = File.Create("C:\\Users\\Dell\\Desktop\\Newfolder\\lastemail.eml"))
                {
                    mimeContentStream.Seek(0, SeekOrigin.Begin);
                    await mimeContentStream.CopyToAsync(fileStream);
                }

                Console.WriteLine("Email message downloaded successfully.");
            }
            catch (ServiceException ex)
            {
                Console.WriteLine($"Error accessing the Graph API: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


            return new BaseResponse<OnlineMeeting>(ResponseMessage, true, 200, null);
        }
    }
}
