using MailKit.Search;
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

        public CustomPageSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }
        public async Task Seed()
        {
            if (!_context.PageStructures.Any())
            {
                await _context.PageStructures.AddRangeAsync(
                    new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = true,
                        IconUrl = "",
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
                        IconUrl = "",
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
                        IconUrl = "",
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
                        IconUrl = "",
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
                        IconUrl = "",
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
                        IconUrl = "",
                        EnglishTitle = "Previous Cycle",
                        ArabicTitle = "الدورات السابقة",
                        EnglishSubTitle = "Sharjah Award for Educational Excellence",
                        ArabicSubTitle = "جائزة الشارقة للتفوق و التميز التربوي",
                        IsHide = false,
                        Slug = "previous_cycle",
                        PageType = PageType.MainPageWithSubPage,
                        PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu,
                        Deletable = false,
                        orderId = 6,
                        pageStructure = null!,
                        ParentId = null

                    },new Domain.Entities.PageStructureModel.PageStructure()
                    {
                        hasHelography = true,
                        IconUrl = "",
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
                        IconUrl = "",
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
                        IconUrl = "",
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

                    });
               await _context.SaveChangesAsync();
            }
        }
    }
}
