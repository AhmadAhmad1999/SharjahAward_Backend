using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.DeleteGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupByInviteeNumber;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupInviteeById;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee;
using System.Net;


namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupInviteeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public GroupInviteeController(IMediator mediator, IWebHostEnvironment WebHostEnvironment)
        {
            _mediator = mediator;
            _WebHostEnvironment = WebHostEnvironment;
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
                Unit Response = await _mediator.Send(CreateGroupInviteeCommand);
                return Ok(new { data = Response });
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
                                return BadRequest("هذا البريد الإلكتروني مستخدم بالفعل.");

                            else
                                return BadRequest("This email is already in use.");
                        }
                    }
                }

                return BadRequest(Exc.Message);
            }
            catch (DbUpdateException Exc)
            {
                return BadRequest(Exc.Message);
            }
            catch (WebException)
            {
                return BadRequest("Internet connection error, please check your internet connection and try again later.");
            }
            catch (System.Net.Mail.SmtpException)
            {
                return BadRequest("Internet connection error, please check your internet connection and try again later.");
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

            await _mediator.Send(updateGroupInviteeCommand);
            return Ok(new { data = Response });
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
            return Ok(Response);
        }


        [HttpGet("{Id}", Name = "GetGroupInviteeById")]
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

        [HttpGet("GetGroupByInviteeNumber/{Id}", Name = "GetGroupByInviteeNumber")]
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> ConfirmAttendanceGroup([FromBody] ConfirmAttendanceGroupQuery query)
        {
            var respone = await _mediator.Send(new ConfirmAttendanceGroupQuery()
            {
                Id = query.Id,
                NumberOfAttendees=query.NumberOfAttendees
            });

            return Ok(respone);
        }
    }
}
