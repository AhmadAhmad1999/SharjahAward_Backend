using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Features.EducationalEntities.Command.DeleteEducationalEntity;
using SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution;
using SharijhaAward.Application.Features.EducationalInstitutions.Commands.DeleteEducationalInstitutions;
using SharijhaAward.Application.Features.EducationalInstitutions.Commands.UpdateEducationalInstitutions;
using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions;
using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutionsWithPagination;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationalInstitutionController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public EducationalInstitutionController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }

        [HttpPost(Name= "CreateEducationalInstitution")]
        public async Task<IActionResult> CreateEducationalInstitution(CreateEducationalInstitutionCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            command.lang = Language!;
            
            var response = await _Mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet(Name= "GetAllEducationalInstitution")]
        public async Task<IActionResult> GetAllEducationalInstitution(int? EducationalEntityId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
           
            var response = await _Mediator.Send(new GetAllEducationalInstitutionsQuery()
            {
                lang = Language!,
                EducationalEntityId = EducationalEntityId
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPut("UpdateEducationalInstitutions")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UpdateEducationalInstitutions([FromBody] UpdateEducationalInstitutionsCommand UpdateEducationalInstitutionsCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            UpdateEducationalInstitutionsCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<object>? Response = await _Mediator.Send(UpdateEducationalInstitutionsCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpDelete("DeleteEducationalInstitutions/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> DeleteEducationalInstitutions(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _Mediator.Send(new DeleteEducationalInstitutionsCommand()
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
        [HttpGet("GetAllEducationalInstitutionsWithPagination")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllEducationalInstitutionsWithPagination(int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<EducationalInstitutionListVM>> Response = await _Mediator.Send
                (new GetAllEducationalInstitutionsWithPaginationQuery()
                {
                    lang = HeaderValue!,
                    page = Page,
                    pageSize = PerPage
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
