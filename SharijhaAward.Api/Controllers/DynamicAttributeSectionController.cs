﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.DeleteDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSections;
using SharijhaAward.Application.Features.Event.Queries.GetEventWithInvitees;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.DeletePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

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
        [HttpDelete(Name = "DeleteDynamicAttributeSection")]
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

            DeleteDynamicAttributeSectionCommand DeleteDynamicAttributeSectionCommand = new DeleteDynamicAttributeSectionCommand()
            {
                Id = Id
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
        [HttpGet(Name = "GetAllDynamicAttributeSections")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllDynamicAttributeSections(int Page, int PerPage)
        {
            return Ok();

            //StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            //List<DynamicAttributeSectionListVM> Response = await _Mediator.Send(new GetAllDynamicAttributeSectionsQuery()
            //{
            //    lang = HeaderValue,
            //    page = Page,
            //    pageSize = PerPage
            //});

            //int PageSize = PerPage == 0 ? 10 : PerPage;

            //if (Response.StatusCode == 404)
            //{
            //    return NotFound(new
            //    {
            //        Response.Message,
            //        Response.StatusCode
            //    });
            //}
            //int totalCount = DTO.Data.Count;
            //var totalPage = (int)Math.Ceiling((decimal)totalCount / PageSize);
            //return Ok(
            //    new
            //    {
            //        data = DTO.Data,
            //        DTO.Message,
            //        DTO.StatusCode,
            //        pagination =
            //        new
            //        {
            //            current_page = page,
            //            last_page = totalPage,
            //            total_row = totalCount,
            //            per_page = PageSize
            //        }

            //    });
        }
    }
}
