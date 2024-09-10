﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPageWebSite;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendaByCycleId;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Features.Albums.Galleries.Queries.GetAllGalleries;
using SharijhaAward.Application.Features.Albums.Queries.GetAllAlbums;
using SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetAllLastVersionsForAllTypes;
using SharijhaAward.Application.Features.AwardPublications.Queries.GetAllAwardPublications;
using SharijhaAward.Application.Features.AwardPublications.Queries.GetAwardPublicationById;
using SharijhaAward.Application.Features.AwardSponsorsPage.Queries.GetAwardSponsor;
using SharijhaAward.Application.Features.AwardStatistics.Queries.GetAllAwardStatistics;
using SharijhaAward.Application.Features.Categories.Queries.GetAllCategories;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoryById;
using SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;
using SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory;
using SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetAllHomePageSliderItems;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee;
using SharijhaAward.Application.Features.MessageTypes.Queries.GetAllMsgType;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Features.News.Queries.GetNewsByCycleId;
using SharijhaAward.Application.Features.News.Queries.GetNewsById;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPagesWithSubPages;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageBySlug;
using SharijhaAward.Application.Features.ReferenceSources.Queries.GetReferenceSourcePage;
using SharijhaAward.Application.Features.Settings.Queries.GetPrivacyPolicy;
using SharijhaAward.Application.Features.Settings.Queries.GetTermsOfUse;
using SharijhaAward.Application.Features.SocialMediaPage.Queries.GetAllSocialMediaItems;
using SharijhaAward.Application.Features.StrategicPartners.Queries.GetAllStrategicPartners;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersForWebsite;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public WebsiteController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpGet("AboutPage/GetAboutPageWebSite")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> WebsiteGetAboutPageWebSite()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<AboutPageDto> Response = await _Mediator.Send(new GetAboutPageWebSiteQuery()
            {
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Agenda/GetAgendasByCycleId")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> WebsiteGetAgendasByCycleId(int? Id, int page = 1, int perPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<AgendaListVm>> Response = await _Mediator.Send(new GetAgendaByCycleIdQuery()
            {
                page = page,
                perPage = perPage,
                CycleId = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Winners/GetAllWinnersForWebsite")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> WebsiteGetAllWinnersForWebsite([FromQuery] GetAllWinnersForWebsiteQuery GetAllWinnersForWebsiteQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllWinnersForWebsiteQuery.lang = HeaderValue;

            BaseResponse<List<GetAllWinnersForWebsiteMainResponse>> Response = await _Mediator.Send(GetAllWinnersForWebsiteQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("StrategicPartner")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllStrategicPartners([FromQuery] GetAllStrategicPartnersQuery query)
        {
            BaseResponse<List<StrategicPartnerListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("SocialMediaItem")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllSocialMediaItem(int page = 1, int perPage = 10)
        {
            BaseResponse<List<SocialMediaItemListVM>> Response = await _Mediator.Send(new GetAllSocialMediaItemsQuery()
            {
                page = page,
                perPage = perPage
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Settings/GetTermsOfUse")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetTermsOfUse(string Slug)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetTermsOfUseDto> Response = await _Mediator.Send(new GetTermsOfUseQuery()
            {
                Slug = Slug,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Settings/GetPrivacyPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetPrivacyPolicy(string Slug)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetPrivacyPolicyDto> Response = await _Mediator.Send(new GetPrivacyPolicyQuery()
            {
                Slug = Slug,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("ReferenceSourcePage")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetReferenceSourcePage()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<ReferenceSourceDto> Response = await _Mediator.Send(new GetReferenceSourcePageQuery
            {
                lang = HeaderValue!,
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("PersonalInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllPersonalInvitee(int page, int perPage, string? name, int? EventId)
        {
            if (perPage == 0)
                perPage = 10;

            BaseResponse<List<PersonalInviteeListVM>> Response = await _Mediator.Send(new GetAllPersonalInviteeQuery()
            {
                EventId = EventId,
                page = page,
                perPage = perPage,
                name = name
            });

            var totalCount = Response.totalItem;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);

            return Ok(
                new
                {
                    Response.data,
                    Response.statusCode,
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
        [HttpGet("Page/GetPageBySlug/{Slug}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetPageBySlug(string Slug)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<PageDto> Response = await _Mediator.Send(new GetPageBySlugQuery()
            {
                lang = HeaderValue!,
                Slug = Slug
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("News/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetNewsById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<NewsDto> Response = await _Mediator.Send(new GetNewsByIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("News/GetNewsForWebsite")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetNewsForWebsite(string? query, int page = 1, int perPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<NewsListVM>> Response = await _Mediator.Send(new GetNewsForWebsiteQuery()
            {
                lang = HeaderValue!,
                page = page,
                perPage = perPage,
                query = query
            });
            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("MessageType")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllMessageType()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<MessageTypeListVM>> Response = await _Mediator.Send(new GetAllMsgQuery()
            {
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response),
            };
        }
        [HttpGet("HomePageSlider")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllHomeSliderItems([FromQuery] GetAllHomePageSliderItemsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<SliderItemsListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllGroupInvitee(int page, int perPage, string? name, int? EventId)
        {
            if (perPage == 0)
                perPage = 10;

            BaseResponse<List<GroupInviteeListVM>> Response = await _Mediator.Send(new GetAllGroupInviteeQuery()
            {
                EventId = EventId,
                page = page,
                perPage = perPage,
                name = name
            });

            var totalCount = Response.totalItem;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);

            return Ok(
                new
                {
                    Response.data,
                    Response.statusCode,
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
        [HttpGet("GeneralFAQCategory/GetAllGeneralFAQCategories")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllGeneralFAQCategories([FromQuery] GetAllGeneralFAQCategoryQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<GetAllGeneralFAQCategoryListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Event/{Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> WebsiteGetEventById(int id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            EventDto Response = await _Mediator.Send(new GetEventByIdQuery()
            {
                Id = id,
                lang = HeaderValue
            });

            return Ok(new { data = Response });
        }
        [HttpGet("Cycle")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllCycle([FromQuery] GetAllCyclesQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<CycleListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("ContactUs")]
        public async Task<IActionResult> SendMessage([FromForm] CreateMessageCommand command)
        {
            var token = HttpContext.Request.Headers.Authorization;
            var language = HttpContext.Request.Headers["lang"];

            command.token = token!;
            command.lang = language!;

            var response = await _Mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                401 => Unauthorized(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("ContactUs")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllMessages(string? query, int? filter, int page = 1, int perPage = 10)
        {
            StringValues Token = HttpContext.Request.Headers.Authorization;

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<EmailMessageListVM>> Response = await _Mediator.Send(new GetAllEmailMessageQuery()
            {
                filter = filter,
                page = page,
                perPage = perPage,
                query = query,
                lang = HeaderValue!,
                token = Token!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                401 => Unauthorized(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Category/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetCategoryById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<CategoryDto> Response = await _Mediator.Send(new GetCategoryByIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Category")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllCategories(int? CycleId, int page = 1, int perPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<CategoryListVM>> Response = await _Mediator.Send(new GetAllCategoryQuery
            {
                lang = HeaderValue!,
                page = page,
                perPage = perPage,
                CycleId = CycleId
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("AwardStatistic")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAwardStatistics([FromQuery] GetAllAwardStatisticsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<AwardStatisticListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("AwardSponsor")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAwardSponser()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<AwardSponsorListVM> Response = await _Mediator.Send(new GetAwardSponsorQuery()
            {
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("AwardPublication")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAwardPublications([FromQuery] GetAllAwardPublicationsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<AwardPublicationListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("AwardPublication/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAwardPublicationById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<AwardPublicationDto> Response = await _Mediator.Send(new GetAwardPublicationByIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Album/GetAllGalleries/{AlbumId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllGalleries(int AlbumId, int page = 1, int perPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GalleryListVm>> Response = await _Mediator.Send(new GetAllGalleriesQuery()
            {
                AlbumId = AlbumId,
                lang = HeaderValue!,
                page = page,
                perPage = perPage
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Album")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAlbums([FromQuery] GetAllAlbumsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<AlbumListVm>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Page/GetMainPagesWithSubPages")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMainPagesWithSubPages([FromQuery] GetMainPagesWithSubPagesQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<MainPageWithSubPageListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("AppsVersions/GetAllLastVersionsForAllTypes")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllLastVersionsForAllTypes()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllLastVersionsForAllTypesListVM>> Response = await _Mediator.Send(new GetAllLastVersionsForAllTypesQuery()
            {
                lang = HeaderValue!
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
