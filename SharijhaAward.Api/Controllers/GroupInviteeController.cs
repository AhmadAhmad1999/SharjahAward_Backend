using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Features.Event.Queries.ExportToExcel;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.DeleteGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.ExportGroupToExcel;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupByInviteeNumber;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupInviteeById;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ExportToExcel;
using SharijhaAward.Application.Responses;
using System.Net;


namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupInviteeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly IExcelHelper<GroupExportVM> _excelHelper;

        public GroupInviteeController(IExcelHelper<GroupExportVM> excelHelper, IMediator mediator, IWebHostEnvironment WebHostEnvironment)
        {
            _mediator = mediator;
            _WebHostEnvironment = WebHostEnvironment;
            _excelHelper = excelHelper;
        }

        [HttpPost(Name = "AddGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> AddGroupInvitee([FromBody] CreateGroupInviteeCommand CreateGroupInviteeCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (!string.IsNullOrWhiteSpace(HeaderValue))
                CreateGroupInviteeCommand.lang = HeaderValue;

            CreateGroupInviteeCommand.ImagePath = _WebHostEnvironment.WebRootPath;
            
                var Response = await _mediator.Send(CreateGroupInviteeCommand);
                return Ok(
                     new
                     {
                         data = Response,
                         message = "تم إنشاء الدعوة الجماعية بنجاح"
                     });
        }

        [HttpPut(Name = "UpdateGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateGroupInvitee([FromBody] UpdateGroupInviteeCommand updateGroupInviteeCommand)
        {
            List<string> studentNames = updateGroupInviteeCommand.StudentNamesAsString!;

            if (updateGroupInviteeCommand.ExpectedNumberOfAttendees != studentNames.Count)
            {
                return BadRequest(
                    new
                    {
                        message = "The NumberOfAttendees is not equal the number of students"
                    });
            }
            var response = await _mediator.Send(updateGroupInviteeCommand);
            return Ok(new { data = response, message = "Updated Sucssesfully" });
        }


        [HttpDelete(Name = "DeleteGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteGroupInvitee(int id)
        {
            DeleteGroupInviteeCommand deleteGroupInviteeCommand = new DeleteGroupInviteeCommand()
            {
                Id = id
            };
            await _mediator.Send(deleteGroupInviteeCommand);
            return Ok(new { message = "تم حذف الدعوة الجماعية بنجاح" });
        }


        [HttpGet("{id}", Name = "GetGroupInviteeById")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<GetGroupInviteeByIdQuery>> GetById(int id)
        {
            GroupInviteeVM? Group = await _mediator
                .Send(new GetGroupInviteeByIdQuery
                {
                    Id = id
                });
            return Ok(new { data = Group });
        }

        [HttpGet("GetGroupByInviteeNumber/{Id}", Name = "GetGroupByInviteeNumber")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<GetGroupByInviteeNumberQuery>> GetGroupByInviteeNumber(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetGroupByInviteeNumberQuery()
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

        [HttpGet(Name = "GetAllGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllGroupInvitee(int page , int perPage, string? name)
        {
            if (perPage == 0)
                perPage = 10;

            var response = await _mediator.Send(new GetAllGroupInviteeQuery()
            {
                page = page,
                pageSize = perPage,
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

        [HttpPost("ConfirmAttendanceGroup", Name = "ConfirmAttendanceGroup")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> ConfirmAttendanceGroup([FromBody] ConfirmAttendanceGroupQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";
            query.lang = HeaderValue!;
            BaseResponse<object>? Response = await _mediator.Send(query);

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
            var PersonalList = await _mediator.Send(new ExportGroupToExcelQuery());
            var file = _excelHelper.ExportToExcel(PersonalList);
            return File(file, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "GroupInvitees.xlsx");
        }
    }
}
