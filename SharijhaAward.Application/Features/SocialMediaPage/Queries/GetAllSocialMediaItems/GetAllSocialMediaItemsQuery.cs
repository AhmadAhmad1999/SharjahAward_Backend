using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.SocialMediaPage.Queries.GetAllSocialMediaItems
{
    public class GetAllSocialMediaItemsQuery : IRequest<BaseResponse<List<SocialMediaItemListVM>>>
    {
        public int page {  get; set; }
        public int perPage { get; set;}
    }
}
