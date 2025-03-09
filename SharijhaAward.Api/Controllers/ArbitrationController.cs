using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.ArbitrationFeatures.Commands.AddUserNoteOnForm;
using SharijhaAward.Application.Features.ArbitrationFeatures.Commands.AssignFormsToArbitrator;
using SharijhaAward.Application.Features.ArbitrationFeatures.Commands.AssignMultipleFormsToMultipleArbitrators;
using SharijhaAward.Application.Features.ArbitrationFeatures.Commands.ChangeStatusForAssignedForm;
using SharijhaAward.Application.Features.ArbitrationFeatures.Commands.DeleteUserNoteOnForm;
using SharijhaAward.Application.Features.ArbitrationFeatures.Commands.SwitchArbitrationFeature;
using SharijhaAward.Application.Features.ArbitrationFeatures.Commands.UpdateAssignedFormsToArbitrator;
using SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllArbitratorsForArbitration;
using SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllFormsForSortingProcess;
using SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId;
using SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetRemainingFormsWithFilters;
using SharijhaAward.Application.Features.Classes.Commands.DeleteClass;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetFormStatusById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ArbitrationController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public ArbitrationController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpPost("AssignFormsToArbitrator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> AssignFormsToArbitrator([FromBody] AssignFormsToArbitratorCommand AssignFormsToArbitratorCommand)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            AssignFormsToArbitratorCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            AssignFormsToArbitratorCommand.Token = Token;

            BaseResponse<object>? Response = await _Mediator.Send(AssignFormsToArbitratorCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("AssignMultipleFormsToMultipleArbitrators")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> AssignMultipleFormsToMultipleArbitrators([FromBody] AssignMultipleFormsToMultipleArbitratorsCommand AssignMultipleFormsToMultipleArbitratorsCommand)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            AssignMultipleFormsToMultipleArbitratorsCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            AssignMultipleFormsToMultipleArbitratorsCommand.Token = Token;

            BaseResponse<object>? Response = await _Mediator.Send(AssignMultipleFormsToMultipleArbitratorsCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("UpdateAssignedFormsToArbitrator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateAssignedFormsToArbitrator([FromBody] UpdateAssignedFormsToArbitratorCommand UpdateAssignedFormsToArbitratorCommand)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateAssignedFormsToArbitratorCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            UpdateAssignedFormsToArbitratorCommand.Token = Token;

            BaseResponse<object>? Response = await _Mediator.Send(UpdateAssignedFormsToArbitratorCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllArbitratorsForArbitration")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllArbitratorsForArbitration([FromQuery] GetAllArbitratorsForArbitrationQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            var Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetArbitratrionDataByArbitratorId/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetArbitratrionDataByArbitratorId(int? ProvidedFormId, int? CategoryId,
            bool? isAccepted, string? ProvidedFormLanguage, string? SubscriberName, int Id, bool GetRemainigForms,
            int page = 1, int perPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetArbitratrionDataByArbitratorIdDto> Response = await _Mediator.Send(new GetArbitratrionDataByArbitratorIdQuery()
            {
                Id = Id,
                lang = HeaderValue!,
                GetRemainigForms = GetRemainigForms,
                page = page,
                perPage = perPage,
                ProvidedFormId = ProvidedFormId,
                CategoryId = CategoryId,
                isAccepted = isAccepted,
                ProvidedFormLanguage = ProvidedFormLanguage,
                SubscriberName = SubscriberName
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("GetRemainingFormsWithFilters")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetRemainingFormsWithFilters(GetRemainingFormsWithFiltersQuery GetRemainingFormsWithFiltersQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<FormsListVMForArbitrationDto>> Response = await _Mediator.Send(GetRemainingFormsWithFiltersQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllFormsForSortingProcess")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFormsForSortingProcess([FromQuery] GetAllFormsForSortingProcessFilter? filter,
            [FromQuery] int Page = 1, [FromQuery] int PerPage = 10)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllFormsForSortingProcessListVM>> Response = await _Mediator.Send(new GetAllFormsForSortingProcessQuery()
            {
                token = Token,
                filter = filter,
                lang = HeaderValue!,
                page = Page,
                perPage = PerPage,
                AsChairman = filter != null ? filter.AsChairman : null,
                AsFullAccess = filter != null ? filter.AsFullAccess : false
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                401 => Unauthorized(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("ChangeStatusForAssignedForm")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangeStatusForAssignedForm(ChangeStatusForAssignedFormCommand ChangeStatusForAssignedFormCommand)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            ChangeStatusForAssignedFormCommand.token = Token;

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            ChangeStatusForAssignedFormCommand.lang = HeaderValue;

            BaseResponse<object>? Response = await _Mediator.Send(ChangeStatusForAssignedFormCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetFormStatusById")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetFormStatusById(int ArbitrationId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetFormStatusByIdDto> Response = await _Mediator.Send(new GetFormStatusByIdQuery()
            {
                ArbitrationId = ArbitrationId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("SwitchArbitration")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SwitchArbitration([FromBody] SwitchArbitrationCommand SwitchArbitrationCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            SwitchArbitrationCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(SwitchArbitrationCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("AddUserNoteOnForm")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> AddUserNoteOnForm([FromBody] AddUserNoteOnFormCommand AddUserNoteOnFormCommand)
        {
            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            AddUserNoteOnFormCommand.Token = Token;

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            AddUserNoteOnFormCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(AddUserNoteOnFormCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteUserNoteOnForm/{UserNoteOnFormForArbitrationId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteUserNoteOnForm(int UserNoteOnFormForArbitrationId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteUserNoteOnFormCommand()
            {
                UserNoteOnFormForArbitrationId = UserNoteOnFormForArbitrationId,
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
