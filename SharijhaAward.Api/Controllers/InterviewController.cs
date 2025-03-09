using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.InterviewFeatures.Commands.CancelInterviewInvitee;
using SharijhaAward.Application.Features.InterviewFeatures.Commands.ChangeEligibilityForInterviewForForm;
using SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateInterview;
using SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateRequestForChangingEligibilityStatus;
using SharijhaAward.Application.Features.InterviewFeatures.Commands.DeleteInterview;
using SharijhaAward.Application.Features.InterviewFeatures.Commands.DeleteInterviewInvitee;
using SharijhaAward.Application.Features.InterviewFeatures.Commands.ImplementInterviewInvitee;
using SharijhaAward.Application.Features.InterviewFeatures.Commands.SendEmailToUsersInInterview;
using SharijhaAward.Application.Features.InterviewFeatures.Commands.UpdateInterview;
using SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllChangeStatusRequestsByProvidedFormId;
using SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllFormsByItsEligibleStatus;
using SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllFormsThatEligibileForInterview;
using SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllInterviewsForInterviewStep;
using SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById;
using SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeetingURL;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly IConfiguration _Configuration;

        public InterviewController(IMediator _Mediator,
            IWebHostEnvironment _WebHostEnvironment,
            IConfiguration _Configuration)
        {
            this._Mediator = _Mediator;
            this._WebHostEnvironment = _WebHostEnvironment;
            this._Configuration = _Configuration;
        }
        [HttpPut("CancelInterviewInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CancelInterview([FromBody] CancelInterviewInviteeCommand CancelInterviewInviteeCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CancelInterviewInviteeCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            CancelInterviewInviteeCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath;

            BaseResponse<object>? Response = await _Mediator.Send(CancelInterviewInviteeCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateInterview")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateInterview([FromBody] CreateInterviewCommand CreateInterviewCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateInterviewCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            CreateInterviewCommand.TenantId = _Configuration["AzureAd:TenantId"];
            CreateInterviewCommand.ClientId = _Configuration["AzureAd:ClientId"];
            CreateInterviewCommand.ClientSecret = _Configuration["AzureAd:ClientSecret"];

            BaseResponse<object>? Response = await _Mediator.Send(CreateInterviewCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteInterview/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteInterview(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteInterviewCommand()
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
        [HttpDelete("DeleteInterviewInvitee/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteInterviewInvitee(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteInterviewInviteeCommand()
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
        [HttpPost("ImplementInterviewInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ImplementInterview([FromForm] ImplementInterviewInviteeMainCommand ImplementInterviewInviteeMainCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            ImplementInterviewInviteeMainCommand.lang = HeaderValue;

            ImplementInterviewInviteeMainCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/InterviewAttachments/";

            BaseResponse<object> Response = await _Mediator.Send(ImplementInterviewInviteeMainCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("SendEmailToUsersInInterview")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SendEmailToUsersInMeeting([FromBody] SendEmailToUsersInInterviewCommand SendEmailToUsersInInterviewCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            SendEmailToUsersInInterviewCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            SendEmailToUsersInInterviewCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath;

            BaseResponse<object>? Response = await _Mediator.Send(SendEmailToUsersInInterviewCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateInterview")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateInterview([FromBody] UpdateInterviewCommand UpdateInterviewCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateInterviewCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            UpdateInterviewCommand.TenantId = _Configuration["AzureAd:TenantId"];
            UpdateInterviewCommand.ClientId = _Configuration["AzureAd:ClientId"];
            UpdateInterviewCommand.ClientSecret = _Configuration["AzureAd:ClientSecret"];

            BaseResponse<object>? Response = await _Mediator.Send(UpdateInterviewCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllInterviewsForInterviewStep")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllInterviewsForInterviewStep([FromQuery] GetAllInterviewsForInterviewStepQuery GetAllInterviewsForInterviewStepQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllInterviewsForInterviewStepListVM>> Response = await _Mediator.Send(GetAllInterviewsForInterviewStepQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetInterviewById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetInterviewById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetInterviewByIdDto> Response = await _Mediator.Send(new GetInterviewByIdQuery()
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
        [HttpPut("ChangeEligibilityForInterviewForForm/{ProvidedFormId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangeEligibilityForInterviewForForm(int ProvidedFormId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object> Response = await _Mediator.Send(new ChangeEligibilityForInterviewForFormCommand()
            {
                ProvidedFormId = ProvidedFormId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllFormsByItsEligibleStatus")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFormsByItsEligibleStatus([FromQuery] GetAllFormsByItsEligibleStatusQuery GetAllFormsByItsEligibleStatusQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllFormsByItsEligibleStatusQuery.lang = HeaderValue;

            BaseResponse<List<GetAllFormsByItsEligibleStatusListVM>> Response = await _Mediator.Send(GetAllFormsByItsEligibleStatusQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("CreateRequestForChangingEligibilityStatus")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> CreateRequestForChangingEligibilityStatus(CreateRequestForChangingEligibilityStatusCommand CreateRequestForChangingEligibilityStatusCommand)
        {
            string? Token = HttpContext.Request.Headers.Authorization;

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            CreateRequestForChangingEligibilityStatusCommand.lang = HeaderValue;
            CreateRequestForChangingEligibilityStatusCommand.Token = Token;

            BaseResponse<object> Response = await _Mediator.Send(CreateRequestForChangingEligibilityStatusCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllChangeStatusRequestsByProvidedFormId/{ProvidedFormId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllChangeStatusRequestsByProvidedFormId(int ProvidedFormId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllChangeStatusRequestsByProvidedFormIdListVM>> Response = await _Mediator.Send(new GetAllChangeStatusRequestsByProvidedFormIdQuery()
            {
                ProvidedFormId = ProvidedFormId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllFormsThatEligibileForInterview")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFormsThatEligibileForInterview([FromQuery] GetAllFormsThatEligibileForInterviewQuery GetAllFormsThatEligibileForInterviewQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllFormsThatEligibileForInterviewQuery.lang = HeaderValue;

            BaseResponse<List<GetAllFormsThatEligibileForInterviewListVM>> Response = await _Mediator.Send(GetAllFormsThatEligibileForInterviewQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
