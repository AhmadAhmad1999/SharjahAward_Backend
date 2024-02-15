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
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.DeletePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal;
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

        public PersonalInviteeController(IMediator mediator,
            IWebHostEnvironment WebHostEnvironment)
        {
            _mediator = mediator;
            _WebHostEnvironment = WebHostEnvironment;
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

            try
            {
                var Response = await _mediator.Send(CreatePersonalInviteeCommand);
                return Ok(
                     new
                     {
                         data = Response ,
                         message = "تم إنشاء الدعوة الفردية بنجاح"
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
                        if (error.Message.Contains("IX_PersonaLnvitees_Email", StringComparison.OrdinalIgnoreCase))
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

                return BadRequest(Exc.Message);
            }
            catch (DbUpdateException Exc)
            {
                return BadRequest(Exc.Message);
            }
            catch (WebException)
            {
                return BadRequest(
                    new 
                    {
                        message = "Internet connection error, please check your internet connection and try again later." 
                    });
            }
            catch(System.Net.Mail.SmtpException)
            {
                return BadRequest(
                    new
                    {
                        message = "Internet connection error, please check your internet connection and try again later."
                    });
            }
            catch(Exception Ex)
            {
                return BadRequest(
                    new
                    {
                        message = Ex.Message + "//////" + Ex.InnerException
                    });
            }
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
            await _mediator.Send(deletePersonalInviteeCommand);
            return Ok(new { message = Response });
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
        public async Task<ActionResult> GetAllPersonalInvitee(int page , int perPage)
        {
            var dto = await _mediator.Send(new GetAllPersonalInviteeQuery());
            if (perPage == 0)
                perPage = 10;
            if(perPage == -1)
                 return Ok(
                  new
                  {
                      data = dto,
                      message = "Retrieved successfully.",
                      status = true,
                  });
            
            var totalCount=dto.Count;
            var totalPage = (int) Math.Ceiling((decimal)totalCount / perPage);
            var dataPerPage = dto
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();
                
            return Json(
                new 
                { 
                    data = dataPerPage ,
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
    }
}
