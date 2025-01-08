using SharijhaAward.Domain.Entities.AboutAwardPageModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class AboutAwardPageSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public AboutAwardPageSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.AboutAwardPage.Any())
            {
               await _context.AboutAwardPage.AddRangeAsync(
                    new AboutAwardPage()
                    {
                        // Id =1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicAboutTitle = "نبذة عن الجائزة",
                        EnglishAboutTitle = "About the award",
                        ArabicAboutDescription = "تأسست جائزة الشارقة للتفوق والتميز التربوي عام 1994-1995 برعاية كريمة من صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الاعلى حاكم إمارة الشارقة حفظه الله ورعاه... وتعتبر أول جائزة تربوية على مستوى الدولة",
                        EnglishAboutDescription = "The Sharjah Award for Educational Excellence and Excellence was established in 1994-1995 under the generous patronage of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of the Emirate of Sharjah, may God protect and preserve him... It is considered the first educational award at the state level.",
                        AboutImage = "https://award-shj.ae/media/fuebwvg4/17.jpg?center=0.15180018758166036,0.48777667777111344&mode=crop&width=796&height=329&rnd=133312190453500000",
                        ArabicOurVisionTitle = "رؤيتنا",
                        EnglishOurVisionTitle = "Our vision",
                        ArabicOurVisionDescription = "تعلـــيم متــميز",
                        EnglishOurVisionDescription = "Distinguished education",
                        OurVisionImage = "https://award-shj.ae/media/fuebwvg4/17.jpg?center=0.15180018758166036,0.48777667777111344&mode=crop&width=796&height=329&rnd=133312190453500000"
                    });
                 await _context.SaveChangesAsync();
            }
        }
    }
}
