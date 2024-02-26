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
using System.Globalization;
using System.Net;
using System.Resources;

namespace SharijhaAward.Api.Controllers
{
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
        public async Task<ActionResult> DeletePersonalInvitee(Guid id)
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
        public async Task<ActionResult<GetPersonalInviteeByIdQuery>> GetById(Guid id)
        {
            PersonalInviteeVM? Personal = await _mediator
                .Send(new GetPersonalInviteeByIdQuery
                {
                    Id = id
                });
            
            return Json(new {data = Personal });
            
        }

        [HttpGet("GetPersonalByInviteeNumber/{id}", Name = "GetPersonalInviteeByInviteeNumber")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<GetPersonalByInviteeNumberQuery>> GetPersonalInviteeByInviteeNumber(int id)
        {
            PersonalDto? Personal = await _mediator
                .Send(new GetPersonalByInviteeNumberQuery
                {
                    InviteeNumber = id
                });

            return Json(new { data = Personal });

        }

        [HttpGet(Name = "GetAllPersonalInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllPersonalInvitee(int page , int perPage , string? name)
        {
            if (perPage == 0)
                perPage = 10;
            var dto = await _mediator.Send(new GetAllPersonalInviteeQuery()
            {
                page = page,
                pageSize = perPage,
                name = name
            });
           
            var totalCount = dto.Count;
            var totalPage = (int) Math.Ceiling((decimal)totalCount / perPage);
          
                
            return Ok(
                new 
                { 
                    data = dto,
                    message = "Retrieved successfully.",
                    status = true,
                    pagination = 
                    new { 
                        current_page = page ,
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
            var respone = await _mediator.Send(new ConfirmAttendancePersonalQuery()
            { 
                Id = personalQuery.Id,
            });

            return Ok(
                new
                {
                    data = respone,
                    message = "Confirmed Sucsessfuly"
                });
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
