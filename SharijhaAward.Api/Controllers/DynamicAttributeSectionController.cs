using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee;

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
        public async Task<ActionResult<CreateDynamicAttributeCommandResponse>> CreateNewDynamicAttributeSection([FromBody] CreateDynamicAttributeSectionCommand CreateDynamicAttributeSectionCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            try
            {
                string ResponseMessage = !string.IsNullOrEmpty(HeaderValue)
                    ? (HeaderValue.ToString() == "ar"
                        ? "تم إنشاء العنوان الرئيسي بنجاح"
                        : "Section Added Successfuly")
                    : "تم إنشاء العنوان الرئيسي بنجاح";

                CreateDynamicAttributeSectionCommandResponse? Response = await _Mediator.Send(CreateDynamicAttributeSectionCommand);
                return Ok(
                    new
                    {
                        data = Response,
                        message = ResponseMessage
                    });
            }
            catch (Exception)
            {
                string ResponseMessage = !string.IsNullOrEmpty(HeaderValue)
                    ? (HeaderValue.ToString() == "ar"
                        ? "حدث خطأ, يرجى إعادة المحاولة لاحقاً"
                        : "An error occurred, Please try again later")
                    : "حدث خطأ, يرجى إعادة المحاولة لاحقاً";

                return BadRequest(
                    new
                    {
                        message = ResponseMessage
                    });
            }
        }
        [HttpPost("UpdateDynamicAttributeSection")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CreateDynamicAttributeCommandResponse>> UpdateDynamicAttributeSection([FromBody] UpdateDynamicAttributeSectionCommand UpdateDynamicAttributeSectionCommand)
        {
            try
            {
                Unit Response = await _Mediator.Send(UpdateDynamicAttributeSectionCommand);
                return Ok(new 
                { 
                    data = Response,
                    message = "Updated Sucssesfully" 
                });
            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.Message +
                    Ex.InnerException != null
                        ? " / " + Ex.InnerException.Message
                        : string.Empty);
            }
            
        }
    }
}
