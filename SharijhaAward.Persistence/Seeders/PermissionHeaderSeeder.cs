using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class PermissionHeaderSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public PermissionHeaderSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.PermissionHeaders.Any())
            {
                _context.PermissionHeaders.AddRange(
                   new PermissionHeader()
                   {
                       // Id = 1,
                       EnglishName = "AboutAward",
                       ArabicName = "حول الجائزة",
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                   },
                new PermissionHeader()
                {
                    // Id = 2,
                    EnglishName = "Album",
                    ArabicName = "الألبوم",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                },
                new PermissionHeader()
                {
                    // Id = 3,
                    EnglishName = "AppVersion",
                    ArabicName = "نسخة التطبيق",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                },
                new PermissionHeader()
                {
                    // Id = 4,
                    EnglishName = "AwardPublication",
                    ArabicName = "إصدارات الجائزة",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                },
                new PermissionHeader()
                {
                    // Id = 5,
                    EnglishName = "AwardSponsor",
                    ArabicName = "راعي الجائزة",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                },
                new PermissionHeader()
                {
                    // Id = 6,
                    EnglishName = "Circular",
                    ArabicName = "التعاميم",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                },
                new PermissionHeader()
                {
                    // Id = 7,
                    EnglishName = "Class",
                    ArabicName = "الصفوف",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                },
                new PermissionHeader()
                {
                    // Id = 8,
                    EnglishName = "ClassArbitrator",
                    ArabicName = "صفوف المحكمين",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                },
                new PermissionHeader()
                {
                    // Id = 9,
                    EnglishName = "Cycle",
                    ArabicName = "الدورات",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 10,
                    EnglishName = "Agenda",
                    ArabicName = "الاجندة",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 11,
                    EnglishName = "Category",
                    ArabicName = "الفئات",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 12,
                    EnglishName = "GeneralCondition",
                    ArabicName = "حول الجائزة",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 13,
                    EnglishName = "EducationalEntity",
                    ArabicName = "الجهات التعليمية",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 14,
                    EnglishName = "SystemFiles",
                    ArabicName = "ملفات النظام",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 15,
                    EnglishName = "GeneralWorkshop",
                    ArabicName = "الدورات التدريبية العامة",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 16,
                    EnglishName = "Instruction",
                    ArabicName = "التعليمات",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 17,
                    EnglishName = "Meeting",
                    ArabicName = "الإجتماعات",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 18,
                    EnglishName = "News",
                    ArabicName = "الأخبار",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 19,
                    EnglishName = "Notification",
                    ArabicName = "الإشعارات",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 20,
                    EnglishName = "NotificationTemplate",
                    ArabicName = "قالب الإشعارات",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 21,
                    EnglishName = "Role",
                    ArabicName = "الدور",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 22,
                    EnglishName = "User",
                    ArabicName = "المستخدمين",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 23,
                    EnglishName = "Coordinator",
                    ArabicName = "المنسقين",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 24,
                    EnglishName = "Arbitrator",
                    ArabicName = "المحكمين",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 25,
                    EnglishName = "Committee",
                    ArabicName = "اللجان",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 26,
                    EnglishName = "SubscriberAccount",
                    ArabicName = "حسابات المشتركين",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 27,
                    EnglishName = "SubscriberProfile",
                    ArabicName = "الملف الشخصي للمشتركين",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 28,
                    EnglishName = "SubscriberForm",
                    ArabicName = "نموذج الإشتراك",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 29,
                    EnglishName = "Event",
                    ArabicName = "الفعاليات",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 30,
                    EnglishName = "ContactUs",
                    ArabicName = "تواصل معنا",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 31,
                    EnglishName = "ExplanatoryMessage",
                    ArabicName = "الرسائل التوضيحية",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 32,
                    EnglishName = "Responsibility",
                    ArabicName = "المسؤوليات",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 33,
                    EnglishName = "GeneralFAQ",
                    ArabicName = "الأسالة الشائعة العامة",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 34,
                    EnglishName = "FAQCategory",
                    ArabicName = "الأسالة الشائعة الخاصة بالفئة",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 35,
                    EnglishName = "AwardStatistic",
                    ArabicName = "إحصائيات الجائزة",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 36,
                    EnglishName = "Slider",
                    ArabicName = "شرائح",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 37,
                    EnglishName = "StrategicPartner",
                    ArabicName = "شريك استراتيجي",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 38,
                    EnglishName = "CustomPages",
                    ArabicName = "الصفحات المخصصة",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 39,
                    EnglishName = "ArbitrationSorting",
                    ArabicName = "فرز التحكيم",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 40,
                    EnglishName = "ArbitrationAssign",
                    ArabicName = "إسناد التحكيم",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 41,
                    EnglishName = "ArbitrationFirst",
                    ArabicName = "التحكيم الأولي",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 42,
                    EnglishName = "ArbitrationAudit",
                    ArabicName = "تدقيق التحكيم",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,

                }, new PermissionHeader()
                {
                    // Id = 43,
                    EnglishName = "Interview",
                    ArabicName = "مقابلات التحكيم",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 44,
                    EnglishName = "ArbitrationFinal",
                    ArabicName = "التحكيم النهائي",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 45,
                    EnglishName = "ResultsArbitration",
                    ArabicName = "نتائج التحكيم",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 46,
                    EnglishName = "ArbitrationWinners",
                    ArabicName = "الفائزين",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                }, new PermissionHeader()
                {
                    // Id = 47,
                    EnglishName = "Interview",
                    ArabicName = "المقابلات",
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                });
                _context.SaveChanges();
            }
        }
    }
}
