using FirebaseAdmin.Messaging;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using NPOI.XWPF.UserModel;
using SharijhaAward.Api.Helpers2;
using SharijhaAward.Application.Features.Classes.Commands.DeleteClass;
using SharijhaAward.Application.Features.NotificationFeatures.Commands.CreateNotification;
using SharijhaAward.Application.Features.NotificationFeatures.Commands.DeleteNotification;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public NotificationsController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("SendMessageAsync")]
        public async Task<IActionResult> SendMessageAsync([FromBody] MessageRequest request)
        {
            var message = new MulticastMessage()
            {
                Notification = new Notification
                {
                    Title = "Ttitle 2",
                    Body = "tek[e 2"
                },
                Tokens = new List<string> { "f6N6pRwGT-WpkeuXOt9gH5:APA91bFFE5J-VVBE3Z8rafdOXuDxIf57c9TJGUDjFQ6oewsrqYATeqPh8eoWH_wkjeZUAp8WTGPhLtno7iBAhIsC0uWaTW9LOCIDt0kQO4v4fLhyhPY_g-9MQB9pk3Me8iKScVCWX6g5" }
            };

            //var messaging = FirebaseMessaging.DefaultInstance;
            //var result = await messaging.SendAsync(message);
            await FirebaseMessaging.DefaultInstance.SendMulticastAsync(message);
            return Ok("Message sent successfully!");
        }
        [HttpPost("CreateNotification")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateNotification([FromBody] CreateNotificationCommand CreateNotificationCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateNotificationCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(CreateNotificationCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteNotification/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteNotification(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteNotificationCommand()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
