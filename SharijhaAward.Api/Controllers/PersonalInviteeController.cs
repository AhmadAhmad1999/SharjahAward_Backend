using Aspose.Pdf;
using Aspose.Pdf.Operators;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.DeleteDynamicAttribute;
using SharijhaAward.Application.Features.Event.Queries.ExportToExcel;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.DeletePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ExportToExcel;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalByInviteeNumber;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById;
using SharijhaAward.Application.Responses;
using System.Globalization;
using System.Net;
using System.Resources;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInviteeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly IExcelHelper<PersonalExportVM> _excelHelper;

        public PersonalInviteeController(IMediator mediator,
            IWebHostEnvironment WebHostEnvironment,
            IExcelHelper<PersonalExportVM> excelHelper)
        {
            _mediator = mediator;
            _WebHostEnvironment = WebHostEnvironment;
            _excelHelper = excelHelper;
        }

        [HttpPost(Name = "AddPersonalInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<string>> AddPersonalInvitee([FromBody] CreatePersonalInviteeCommand CreatePersonalInviteeCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (!string.IsNullOrWhiteSpace(HeaderValue))
                CreatePersonalInviteeCommand.lang = HeaderValue;

            CreatePersonalInviteeCommand.ImagePath = _WebHostEnvironment.WebRootPath;

           
                var Response = await _mediator.Send(CreatePersonalInviteeCommand);
                return Ok(
                     new
                     {
                         data = Response ,
                         message = "تم إنشاء الدعوة الفردية بنجاح"
                     });
        }

        [HttpPut(Name = "UpdatePersonalInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdatePersonalInvitee([FromBody] UpdatePersonalInviteeCommand updatePersonalInviteeCommand)
        {

            var response = await _mediator.Send(updatePersonalInviteeCommand);
            return Ok(new { data = response, message = "Updated Sucssesfully" });
        }

        [HttpDelete(Name = "DeletePersonalInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeletePersonalInvitee(int id)
        {
            DeletePersonalInviteeCommand deletePersonalInviteeCommand = new DeletePersonalInviteeCommand()
            {
                Id = id
            };
            var response = await _mediator.Send(deletePersonalInviteeCommand);
            return Ok(new { message = "تم حذف الدعوة الفردية بنجاح" });
        }

        [HttpGet("{id}", Name = "GetPersonalInviteeById")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<GetPersonalInviteeByIdQuery>> GetById(int id)
        {
            PersonalInviteeVM? Personal = await _mediator
                .Send(new GetPersonalInviteeByIdQuery
                {
                    Id = id
                });
            
            return Json(new {data = Personal });
            
        }

        [HttpGet("GetPersonalByInviteeNumber/{Id}", Name = "GetPersonalInviteeByInviteeNumber")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<GetPersonalByInviteeNumberQuery>> GetPersonalInviteeByInviteeNumber(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetPersonalByInviteeNumberQuery()
            {
                lang = language!,
                InviteeNumber = Id
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }

        [HttpGet(Name = "GetAllPersonalInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllPersonalInvitee(int page , int perPage , string? name, int? EventId)
        {
            if (perPage == 0)
                perPage = 10;
            var response = await _mediator.Send(new GetAllPersonalInviteeQuery()
            {
                EventId = EventId,
                page = page,
                perPage = perPage,
                name = name
            });
           
            var totalCount = response.totalItem;
            var totalPage = (int) Math.Ceiling((decimal)totalCount / perPage);
          
                
            return Ok(
                new 
                { 
                   response.data,
                   response.statusCode,
                    pagination = 
                    new { 
                        current_page = page ,
                        last_page = totalPage,
                        total_row = totalCount,
                        per_page = perPage
                    } 
                });
        }
        [HttpGet("WebsiteGetAllPersonalInvitee", Name = "WebsiteGetAllPersonalInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> WebsiteGetAllPersonalInvitee(int page, int perPage, string? name, int? EventId)
        {
            if (perPage == 0)
                perPage = 10;
            var response = await _mediator.Send(new GetAllPersonalInviteeQuery()
            {
                EventId = EventId,
                page = page,
                perPage = perPage,
                name = name
            });

            var totalCount = response.totalItem;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);


            return Ok(
                new
                {
                    response.data,
                    response.statusCode,
                    pagination =
                    new
                    {
                        current_page = page,
                        last_page = totalPage,
                        total_row = totalCount,
                        per_page = perPage
                    }
                });
        }
        [HttpPost("ConfirmAttendancePersonal", Name = "ConfirmAttendancePersonal")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> ConfirmAttendancePersonal([FromBody] ConfirmAttendancePersonalQuery personalQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _mediator.Send(new ConfirmAttendancePersonalQuery()
            {
                Id = personalQuery.Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("ExportToExcel")]
        public async Task<FileResult> ExportToExcel()
        {
            var PersonalList = await _mediator.Send(new PersonalExportQuery());
            var file = _excelHelper.ExportToExcel(PersonalList);
            return File(file, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "PersonalInvitees.xlsx");
        }
    }
}
