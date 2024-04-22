using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Api.Helpers2;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        [HttpPost("SendMessageAsync")]
        public async Task<IActionResult> SendMessageAsync([FromBody] MessageRequest request)
        {
            var message = new Message()
            {
                Notification = new Notification
                {
                    Title = request.Title,
                    Body = request.Body,
                },
                Token = "f6N6pRwGT-WpkeuXOt9gH5:APA91bFFE5J-VVBE3Z8rafdOXuDxIf57c9TJGUDjFQ6oewsrqYATeqPh8eoWH_wkjeZUAp8WTGPhLtno7iBAhIsC0uWaTW9LOCIDt0kQO4v4fLhyhPY_g-9MQB9pk3Me8iKScVCWX6g5"
            };

            var messaging = FirebaseMessaging.DefaultInstance;
            var result = await messaging.SendAsync(message);

            if (!string.IsNullOrEmpty(result))
            {
                // Message was sent successfully
                return Ok("Message sent successfully!");
            }
            else
            {
                // There was an error sending the message
                throw new Exception("Error sending the message.");
            }
        }
    }
}
