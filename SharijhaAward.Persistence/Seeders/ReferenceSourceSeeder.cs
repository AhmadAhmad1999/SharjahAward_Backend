using SharijhaAward.Domain.Entities.ReferenceSourcesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class ReferenceSourceSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public ReferenceSourceSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.ReferenceSources.Any())
            {
                _context.ReferenceSources.AddRange(
                   new ReferenceSource()
                   {
                       Id = 1,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicTitle = "الدليل التفسيري لجائزة جوهرة اللغة العربية",
                       EnglishTitle = "Interpretive guide for the Jewel of the Arabic Language Award",
                       ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                   }, new ReferenceSource()
                   {
                       Id = 2,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicTitle = "الأدلة التفسيرية لفئة الأفراد المتميزين",
                       ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                   }, new ReferenceSource()
                   {
                       Id = 3,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicTitle = "الأدلة التفسيرية لفئة المؤسسات المتميزة",
                       ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                   }, new ReferenceSource()
                   {
                       Id = 4,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicTitle = "الأدلة التفسيرية لفئة فرق العمل  المتميزة",
                       ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                   }, new ReferenceSource()
                   {
                       Id = 5,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicTitle = "المصادر التوضيحية لجميع الفئات",
                       ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                       ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                   });
                _context.SaveChanges();
            }
        }
    }
}
