using SharijhaAward.Domain.Entities.InstructionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class InstructionSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public InstructionSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Instructions.Any())
            {
               await _context.Instructions.AddRangeAsync(
                    new Instruction()
                    {
                        // Id = 1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "events_index",
                        Title = "جدول الفعاليات"
                    }, new Instruction()
                    {
                        // Id = 2,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "event_attendees_index",
                        Title = "جدول حضور الفعاليات"
                    }, new Instruction()
                    {
                        // Id = 3,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "arbitrators_index",
                        Title = "جدول المًحكّمين"
                    }, new Instruction()
                    {
                        // Id = 4,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "coordinators_index",
                        Title = "جدول المًنسقين"
                    }, new Instruction()
                    {
                        // Id = 5,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "arbitrator_form",
                        Title = "إضافة أو تعديل معلومات مًحكّم"
                    }, new Instruction()
                    {
                        // Id = 6,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "coordinator_form",
                        Title = "إضافة أو تعديل معلومات مًنسق"
                    }, new Instruction()
                    {
                        // Id = 7,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "class_arbitrators_index",
                        Title = "جدول مًحكّمين الصف"
                    }, new Instruction()
                    {
                        // Id = 8,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "class_form",
                        Title = "إضافة أو تعديل معلومات صف"
                    }, new Instruction()
                    {
                        // Id = 9,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "classes_index",
                        Title = "جدول الصفوف"
                    }, new Instruction()
                    {
                        // Id = 10,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "cycle_form",
                        Title = "إضافة أو تعديل معلومات دورة"
                    }, new Instruction()
                    {
                        // Id = 11,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "cycles_index",
                        Title = "جدول الدورات"
                    }, new Instruction()
                    {
                        // Id = 12,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "Agendas_index",
                        Title = "جدول الأجندة"
                    }, new Instruction()
                    {
                        // Id = 13,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "categories_index",
                        Title = "جدول الفئات الرئيسية مع الفئات الفرعية التابعة له"
                    }, new Instruction()
                    {
                        // Id = 14,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "subcategory_form",
                        Title = "إضافة أو تعديل معلومات فئة فرعية"
                    }, new Instruction()
                    {
                        // Id = 15,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "cycle_specifications_form",
                        Title = "إضافة أو تعديل محددات الدورة"
                    }, new Instruction()
                    {
                        // Id = 16,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "explanatory_guide",
                        Title = "عرض الدليل التفسيري مع الإجراءات الممكنة"
                    }, new Instruction()
                    {
                        // Id = 17,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "faq_index",
                        Title = "جدول الأسئلة الشائعة"
                    }, new Instruction()
                    {
                        // Id = 18,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "cycle_conditions_index",
                        Title = "جدول الشروط العامة للدورة"
                    }, new Instruction()
                    {
                        // Id = 19,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "data_import",
                        Title = "صفحة استيراد المعلومات"
                    }, new Instruction()
                    {
                        // Id = 20,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "subcategory_conditions_index",
                        Title = "جدول شروط الفئة الفرعية"
                    }, new Instruction()
                    {
                        // Id = 21,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "subcategory_fields_index",
                        Title = "جدول حقول الفئة الفرعية"
                    }, new Instruction()
                    {
                        // Id = 22,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "subcategory_workshops_index",
                        Title = "جدول الورشات التدريبية للفئة الفرعية"
                    }, new Instruction()
                    {
                        // Id = 23,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "educational_entities_index",
                        Title = "جدول الجهات التعليمية"
                    }, new Instruction()
                    {
                        // Id = 24,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "educational_entities_form",
                        Title = "إضافة أو تعديل جهة تعليمية مع عرض المؤسسات التابعة في حال التعديل"
                    }, new Instruction()
                    {
                        // Id = 25,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "educational_institution_form",
                        Title = "إضافة أو تعديل مؤسسة تعليمية"
                    }, new Instruction()
                    {
                        // Id = 26,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "home",
                        Title = "الصفحة الرئيسية"
                    }, new Instruction()
                    {
                        // Id = 27,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "instructions_index",
                        Title = "جدول الإرشادات"
                    }, new Instruction()
                    {
                        // Id = 28,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "instruction_form",
                        Title = "صفحة تعديل إرشاد"
                    }, new Instruction()
                    {
                        // Id = 29,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "notifications_index",
                        Title = "جدول الإشعارات"
                    }, new Instruction()
                    {
                        // Id = 30,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "notifications_form",
                        Title = "إضافة إشعار"
                    }, new Instruction()
                    {
                        // Id = 31,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "roles_index",
                        Title = "جدول الأدوار"
                    }, new Instruction()
                    {
                        // Id = 32,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "role_form",
                        Title = "إضافة أو تعديل دور"
                    }, new Instruction()
                    {
                        // Id = 33,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "subscribers_accounts_index",
                        Title = "جدول حسابات المشتركين"
                    }, new Instruction()
                    {
                        // Id = 34,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "users_index",
                        Title = "جدول المستخدمين"
                    }, new Instruction()
                    {
                        // Id = 35,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "user_form",
                        Title = "إضافة أو تعديل معلومات مستخدم"
                    }, new Instruction()
                    {
                        // Id = 36,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "notifications_templates_index",
                        Title = "جدول نماذج الإشعارات"
                    }, new Instruction()
                    {
                        // Id = 37,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "notification_template_form",
                        Title = "إضافة أو تعديل نموذج إشعارات"
                    }, new Instruction()
                    {
                        // Id = 38,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "contact_us_index",
                        Title = "جدول طلبات التواصل"
                    }, new Instruction()
                    {
                        // Id = 39,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "contact_us_details",
                        Title = "تفاصيل طلب تواصل"
                    }, new Instruction()
                    {
                        // Id = 40,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "committees_index",
                        Title = "جدول اللجان"
                    }, new Instruction()
                    {
                        // Id = 41,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "committee_form",
                        Title = "إضافة أو تعديل لجنة"
                    }, new Instruction()
                    {
                        // Id = 42,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "meetings_index",
                        Title = "جدول الاجتماعات"
                    }, new Instruction()
                    {
                        // Id = 43,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "meeting_form",
                        Title = "إضافة اجتماع"
                    }, new Instruction()
                    {
                        // Id = 44,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "circulars_index",
                        Title = "جدول التعاميم"
                    }, new Instruction()
                    {
                        // Id = 45,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "circular_form",
                        Title = "إضافة أو تعديل تعميم"
                    }, new Instruction()
                    {
                        // Id = 46,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "general_workshops_index",
                        Title = "جدول الورشات التدريبية العامة"
                    }, new Instruction()
                    {
                        // Id = 47,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "general_workshops_form",
                        Title = "إضافة أو تعديل ورشة تدريبية عامة"
                    }, new Instruction()
                    {
                        // Id = 48,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "app_versions_index",
                        Title = "جدول نسخ التطبيق"
                    }, new Instruction()
                    {
                        // Id = 49,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "app_version_form",
                        Title = "إضافة نسخة تطبيق"
                    }, new Instruction()
                    {
                        // Id = 50,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "subscribers_profiles_index",
                        Title = "جدول برفايلات المستخدمين"
                    }, new Instruction()
                    {
                        // Id = 51,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        Content = null,
                        Slug = "subscriber_profile",
                        Title = "بروفايل مستخدم"
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
