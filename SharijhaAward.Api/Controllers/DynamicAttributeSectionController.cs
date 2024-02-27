using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.DeleteDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSections;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicAttributeSectionController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public DynamicAttributeSectionController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("CreateNewDynamicAttributeSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CreateDynamicAttributeSectionCommandResponse>> CreateNewDynamicAttributeSection([FromBody] CreateDynamicAttributeSectionCommand CreateDynamicAttributeSectionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateDynamicAttributeSectionCommandResponse? Response = await _Mediator.Send(CreateDynamicAttributeSectionCommand);

            string ResponseMessage = !string.IsNullOrEmpty(HeaderValue)
                ? (HeaderValue.ToString() == "ar"
                    ? "تم إنشاء العنوان الرئيسي بنجاح"
                    : "Section Added Successfuly")
                : "تم إنشاء العنوان الرئيسي بنجاح";

            return Ok(
                new
                {
                    data = Response,
                    message = ResponseMessage
                });
        }
        [HttpPut("UpdateDynamicAttributeSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateDynamicAttributeSection([FromBody] UpdateDynamicAttributeSectionCommand UpdateDynamicAttributeSectionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            UpdateDynamicAttributeSectionCommand.lang = HeaderValue!;

            Unit Response = await _Mediator.Send(UpdateDynamicAttributeSectionCommand);

            string ResponseMessage = !string.IsNullOrEmpty(HeaderValue)
                ? (HeaderValue.ToString() == "ar"
                    ? "تم تعديل العنوان الرئيسي بنجاح"
                    : "Updated Sucssesfully")
                : "تم تعديل العنوان الرئيسي بنجاح";

            return Ok(new 
            { 
                data = Response,
                message = ResponseMessage
            });
        }
        [HttpDelete("DeleteDynamicAttributeSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteDynamicAttributeSection(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            DeleteDynamicAttributeSectionCommand DeleteDynamicAttributeSectionCommand = new DeleteDynamicAttributeSectionCommand()
            {
                Id = Id,
                lang = HeaderValue!
            };

            Unit Response = await _Mediator.Send(DeleteDynamicAttributeSectionCommand);

            string ResponseMessage = !string.IsNullOrEmpty(HeaderValue)
                ? (HeaderValue.ToString() == "ar"
                    ? "تم حذف العنوان الرئيسي بنجاح"
                    : "Deleted Sucssesfully")
                : "تم حذف العنوان الرئيسي بنجاح";

            return Ok(new 
            { 
                message = ResponseMessage
            });
        }
        [HttpGet("GetAllDynamicAttributeSections")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllDynamicAttributeSections(int Page, int PerPage)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<DynamicAttributeSectionListVM>> Response = await _Mediator.Send(new GetAllDynamicAttributeSectionsQuery()
            {
                lang = HeaderValue!,
                page = Page,
                pageSize = PerPage
            });

            int PageSize = PerPage == 0 ? 10 : PerPage;

            if (Response.statusCode == 404)
            {
                return NotFound(new
                {
                    Response.message,
                    Response.statusCode
                });
            }

            int TotalCount = Response.data!.Count;
            int TotalPage = (int)Math.Ceiling((decimal)TotalCount / PageSize);

            return Ok(new
            {
                data = Response.data,
                Response.message,
                Response.statusCode,
                pagination = new {
                    current_page = Page,
                    last_page = TotalPage,
                    total_row = TotalCount,
                    per_page = PageSize
                }
            });
        }
        [HttpGet("GetDynamicAttributeSectionById/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetDynamicAttributeSectionById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "ar";

            BaseResponse<DynamicAttributeSectionDto> Response = await _Mediator.Send(new DynamicAttributeSectionQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Ok(new 
            { 
                data = Response
            });
        }
    }
}
