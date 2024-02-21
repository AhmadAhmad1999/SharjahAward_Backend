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
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ExportToExcel;
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
        public async Task<ActionResult<Guid>> AddGroupInvitee([FromBody] CreateGroupInviteeCommand CreateGroupInviteeCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            if (!string.IsNullOrWhiteSpace(HeaderValue))
                CreateGroupInviteeCommand.lang = HeaderValue;

            CreateGroupInviteeCommand.ImagePath = _WebHostEnvironment.WebRootPath;
            try
            {
                var Response = await _mediator.Send(CreateGroupInviteeCommand);
                return Ok(
                     new
                     {
                         data = Response,
                         message = "تم إنشاء الدعوة الجماعية بنجاح"
                     });
            }
            catch (ValidationException Exc)
            {
                return BadRequest(Exc.Message);
            }
            catch (DbUpdateException Exc) when (Exc.InnerException is SqlException SqlEx)
            {
                foreach (SqlError error in SqlEx.Errors)
                {
                    if (error.Number == 2601 || error.Number == 2627)
                    {
                        if (error.Message.Contains("IX_GroupInvitees_Email", StringComparison.OrdinalIgnoreCase))
                        {
                            if (HeaderValue.ToString() == "ar")
                                return BadRequest(
                                    new
                                    {
                                        message = "هذا البريد الإلكتروني مستخدم بالفعل."
                                    });

                            else
                                return BadRequest(
                                    new
                                    {
                                        message = "This email is already in use."
                                    });
                        }
                    }
                }
                return BadRequest(
                    new
                    {
                        message = Exc.Message
                    });
                
            }
            catch (DbUpdateException Exc)
            {
                return BadRequest(
                    new
                    {
                         message = Exc.Message
                    });
            }
            catch (WebException)
            {
                return BadRequest(
                    new
                    {
                        message = "Internet connection error, please check your internet connection and try again later."
                    });
            }
            catch (System.Net.Mail.SmtpException)
            {
                return BadRequest(
                    new
                    {
                        message = "Internet connection error, please check your internet connection and try again later."
                    });
            }
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
        public async Task<ActionResult> DeleteGroupInvitee(Guid id)
        {
            DeleteGroupInviteeCommand deleteGroupInviteeCommand = new DeleteGroupInviteeCommand()
            {
                Id = id
            };
            await _mediator.Send(deleteGroupInviteeCommand);
            return Ok(new { message = Response });
        }


        [HttpGet("{id}", Name = "GetGroupInviteeById")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<GetGroupInviteeByIdQuery>> GetById(Guid id)
        {
            GroupInviteeVM? Group = await _mediator
                .Send(new GetGroupInviteeByIdQuery
                {
                    Id = id
                });
            return Ok(new { data = Group });
        }

        [HttpGet("GetGroupByInviteeNumber/{id}", Name = "GetGroupByInviteeNumber")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<GetGroupByInviteeNumberQuery>> GetGroupByInviteeNumber(int id)
        {
            GroupDto? Group = await _mediator
                .Send(new GetGroupByInviteeNumberQuery
                {
                    InviteeNumber = id
                });
            return Ok(new { data = Group });
        }

        [HttpGet(Name = "GetAllGroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllGroupInvitee(int page , int perPage)
        {
            var dto = await _mediator.Send(new GetAllGroupInviteeQuery());

            if (perPage == 0)
                perPage = 10;
            else if (perPage == -1)
                return Ok(
                new
                {
                    data = dto,
                    message = "Retrieved successfully.",
                    status = true,
                });

          
            var totalCount = dto.Count;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);
            var dataPerPage = dto
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            return Json(
                new
                {
                    data = dataPerPage,
                    message = "Retrieved successfully.",
                    status = true,
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
            List<string> studentNames = query.StudentNames!;
           
                if (query.NumberOfAttendees != studentNames.Count)
                {
                    return BadRequest(
                        new
                        {
                            message = "The NumberOfAttendees is not equal the number of students"
                        });
                }
            var respone = await _mediator.Send(new ConfirmAttendanceGroupQuery()
            {
                Id = query.Id,
                NumberOfAttendees = query.NumberOfAttendees,
                StudentNames = studentNames,
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
            var PersonalList = await _mediator.Send(new ExportGroupToExcelQuery());
            var file = _excelHelper.ExportToExcel(PersonalList);
            return File(file, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "GroupInvitees.xlsx");
        }
    }
}
