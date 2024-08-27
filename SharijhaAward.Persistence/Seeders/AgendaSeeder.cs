using SharijhaAward.Domain.Entities.AgendaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class AgendaSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public AgendaSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Agendas.Any())
            {
                _context.Agendas.AddRange(
                   new Agenda()
                   {
                       CycleId = 1,
                       // Id =1,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       ArabicTitle = "اختبار عنوان جدول أعمال 1",
                       DateType = Domain.Constants.AgendaConstants.AgendaDateType.Date,
                       EnglishTitle = "Test Agenda Titile 1",
                       Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1) (1).png",
                       StartDate = DateTime.UtcNow.AddDays(5),
                       EndDate = DateTime.UtcNow.AddDays(10),
                       Status = Domain.Constants.AgendaConstants.AgendaStatus.Previous,
                       CurrentDate = DateTime.UtcNow.AddDays(6)
                   }, new Agenda()
                   {
                       CycleId = 1,
                       // Id =2,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       ArabicTitle = "اختبار عنوان جدول أعمال 2",
                       DateType = Domain.Constants.AgendaConstants.AgendaDateType.Full,
                       EndDate = DateTime.UtcNow.AddDays(16),
                       EnglishTitle = "Test Agenda Titile 2",
                       Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1) (2).png",
                       StartDate = DateTime.UtcNow.AddDays(11),
                       Status = Domain.Constants.AgendaConstants.AgendaStatus.Active,
                       CurrentDate = DateTime.UtcNow.AddDays(12)
                   }, new Agenda()
                   {
                       CycleId = 1,
                       // Id =3,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       ArabicTitle = "اختبار عنوان جدول أعمال 3",
                       DateType = Domain.Constants.AgendaConstants.AgendaDateType.YearMonth,
                       EndDate = DateTime.UtcNow.AddDays(22),
                       EnglishTitle = "Test Agenda Titile 3",
                       Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png",
                       StartDate = DateTime.UtcNow.AddDays(17),
                       Status = Domain.Constants.AgendaConstants.AgendaStatus.Later,
                       CurrentDate = DateTime.UtcNow.AddDays(18)
                   }, new Agenda()
                   {
                       CycleId = 1,
                       // Id =4,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       ArabicTitle = "اختبار عنوان جدول أعمال 4",
                       DateType = Domain.Constants.AgendaConstants.AgendaDateType.YearMonth,
                       EndDate = DateTime.UtcNow.AddDays(28),
                       EnglishTitle = "Test Agenda Titile 4",
                       Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png",
                       StartDate = DateTime.UtcNow.AddDays(23),
                       Status = Domain.Constants.AgendaConstants.AgendaStatus.Later,
                       CurrentDate = DateTime.UtcNow.AddDays(24)
                   }, new Agenda()
                   {
                       CycleId = 1,
                       // Id =5,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       ArabicTitle = "اختبار عنوان جدول أعمال 5",
                       DateType = Domain.Constants.AgendaConstants.AgendaDateType.YearMonth,
                       EndDate = DateTime.UtcNow.AddDays(34),
                       EnglishTitle = "Test Agenda Titile 5",
                       Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png",
                       StartDate = DateTime.UtcNow.AddDays(29),
                       Status = Domain.Constants.AgendaConstants.AgendaStatus.Later,
                       CurrentDate = DateTime.UtcNow.AddDays(30)
                   }
                );
                _context.SaveChanges();
            }
        }
    }
}
