using MailKit.Search;
using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Crmf;
using SharijhaAward.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class CustomPageSeeder
    {
        private readonly SharijhaAwardDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CustomPageSeeder(SharijhaAwardDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task Seed()
        {
            bool isHttps = _httpContextAccessor.HttpContext!.Request.IsHttps;

            var DomainIp = isHttps
                  ? $"https://{_httpContextAccessor.HttpContext?.Request.Host.Value}"
                  : $"http://{_httpContextAccessor.HttpContext?.Request.Host.Value}";

            if (!_context.PageStructures.Any())
            {
                await _context.PageStructures.AddRangeAsync(
                    new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = true,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/AwardSponsor.svg",
                        EnglishTitle = "Award Sponsor",
                        ArabicTitle = "راعي الجائزة",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "award_sponsor",
                        PageType = PageType.MainPageWithoutSubPage,
                        Deletable = false,
                        orderId = 1,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/AbouttheAward.svg",
                        EnglishTitle = "About Award",
                        ArabicTitle = "عن الجائزة",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "about_award",
                        PageType = PageType.MainPageWithoutSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 2,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/PartnersStrategists.svg",
                        EnglishTitle = "Strategic Partners",
                        ArabicTitle = "الشركاء الاستراتيجيين",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "strategic_partners",
                        PageType = PageType.MainPageWithoutSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 3,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/MediaCenter.svg",
                        EnglishTitle = "Media Center",
                        ArabicTitle = "المركز الإعلامي",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "media_center",
                        PageType = PageType.MainPageWithSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 4,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/ContactDetails.svg",
                        EnglishTitle = "Contact Us",
                        ArabicTitle = "بيانات التواصل",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "contact_us",
                        PageType = PageType.MainPageWithoutSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 5,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/PreviousSessions.svg",
                        EnglishTitle = "Previous Cycle",
                        ArabicTitle = "الدورات السابقة",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "previous_cycle",
                        PageType = PageType.MainPageWithoutSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 6,
                        pageStructure = null!,
                        ParentId = null

                    }, new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = "",
                        EnglishTitle = "Winners on Previous Cycle",
                        ArabicTitle = "الدورات السابقة",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "winners",
                        PageType = PageType.SubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 1,
                        //pageStructure = null!,
                        ParentId = 6

                    }, new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = "",
                        EnglishTitle = "Award Statistics",
                        ArabicTitle = "إحصائيات الجائزة",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "award_statistics",
                        PageType = PageType.SubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 1,
                        //pageStructure = null!,
                        ParentId = 6

                    }, new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = "",
                        EnglishTitle = "Award News",
                        ArabicTitle = "أخبار الجائزة",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "award_news",
                        PageType = PageType.SubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 1,
                        //pageStructure = null!,
                        ParentId = 4

                    }, new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = "",
                        EnglishTitle = "Social Media",
                        ArabicTitle = "التواصل الإجتماعي",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "social_media",
                        PageType = PageType.SubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 2,
                        //pageStructure = null!,
                        ParentId = 4

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = "",
                        EnglishTitle = "Gallery",
                        ArabicTitle = "معرض الصور و الفيديوهات",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "gallery",
                        PageType = PageType.SubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 3,
                        //pageStructure = null!,
                        ParentId = 4

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = "",
                        EnglishTitle = "Award Publications",
                        ArabicTitle = "إصدارات الجائزة",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "award_publications",
                        PageType = PageType.SubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 3,
                        //pageStructure = null!,
                        ParentId = 4

                    },

                    //------------------- Page In Cell -------------------
                    new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = true,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/AwardCategories.svg",
                        EnglishTitle = "Award Categories",
                        ArabicTitle = "فئات الجائزة",
                        //EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        //ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "award_categories",
                        PageType = PageType.MainPageWithoutSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InCells,
                        Deletable = false,
                        orderId = 1,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = true,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/ReferenceSources.svg",
                        EnglishTitle = "Reference Sources",
                        ArabicTitle = "المصادر المرجعية",
                        //EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        //ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "reference_sources",
                        PageType = PageType.MainPageWithoutSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InCells,
                        Deletable = false,
                        orderId = 2,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/FrequentlyAskedQuestions.svg",
                        EnglishTitle = "FAQs",
                        ArabicTitle = "الأسئلة الشائعة",
                        //EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        //ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "faqs",
                        PageType = PageType.MainPageWithoutSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InCells,
                        Deletable = false,
                        orderId = 3,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/Nominationforarbitration.svg",
                        EnglishTitle = "Nomination for Arbitration",
                        ArabicTitle = "الترشح للتحكيم",
                        //EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        //ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "nomination_for_arbitration",
                        PageType = PageType.MainPageWithoutSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InCells,
                        Deletable = false,
                        orderId = 4,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = false,
                        IconUrl = $"{DomainIp}/UploadedFiles/Icons/portalParticipants.svg",
                        EnglishTitle = "Subscribers Portal",
                        ArabicTitle = "بوابة المشتركين",
                        //EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        //ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "subscribers_portal",
                        RefUrl = "https://subscriber.stg.award-shj.ae/",
                        PageType = PageType.MainPageWithoutSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InCells,
                        Deletable = false,
                        orderId = 5,
                        pageStructure = null!,
                        ParentId = null

                    });
               await _context.SaveChangesAsync();
            }
        }
    }
}
