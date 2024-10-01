using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class PermissionSeeder
    {
        private readonly SharijhaAwardDbContext _context;
        public PermissionSeeder(SharijhaAwardDbContext context) 
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Permissions.Any())
            {
               await _context.Permissions.AddRangeAsync(
                //-------------AboutAward---------
                new Permission()
                {
                    // Id = 1,
                    Name = "تعديل حول الجائزة",
                    Action = "update",
                    PermissionHeaderId = 1,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                },
                //---------Album-------------
                new Permission()
                {
                    // Id = 2,
                    Name = "إضافة معرض الصور",
                    Action = "create",
                    PermissionHeaderId = 2,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 3,
                    Name = "عرض معرض الصور",
                    Action = "read",
                    PermissionHeaderId = 2,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 4,
                    Name = "تعديل معرض الصور",
                    Action = "update",
                    PermissionHeaderId = 2,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 5,
                    Name = "حذف معرض الصور",
                    Action = "delete",
                    PermissionHeaderId = 2,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                new Permission()
                {
                    // Id = 6,
                    Name = "تصدير معرض الصور",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 2,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //-------------AppVersion---------------
                new Permission()
                {
                    // Id = 7,
                    Name = "إضافة نسخة التطبيق",
                    Action = "create",
                    PermissionHeaderId = 3,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 8,
                    Name = "عرض نسخة التطبيق",
                    Action = "read",
                    PermissionHeaderId = 3,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                },
                new Permission()
                {
                    // Id = 9,
                    Name = "تصدير نسخة التطبيق",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 3,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //----------AwardPublication------------
                new Permission()
                {
                    // Id = 10,
                    Name = "إضافة إصدارات الجائزة",
                    Action = "create",
                    PermissionHeaderId = 4,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 11,
                    Name = "عرض إصدارات الجائزة",
                    Action = "read",
                    PermissionHeaderId = 4,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                 new Permission()
                 {
                     // Id = 12,
                     Name = "تعديل إصدارات الجائزة",
                     Action = "update",
                     PermissionHeaderId = 4,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 }, new Permission()
                 {
                     // Id = 13,
                     Name = "حذف إصدارات الجائزة",
                     Action = "delete",
                     PermissionHeaderId = 4,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 14,
                     Name = "تصدير إصدارات الجائزة",
                     Action = "xlsx-exportable",
                     PermissionHeaderId = 4,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },

                //------AwardSponsor----------
                new Permission()
                {
                    // Id = 15,
                    Name = "تعديل راعي الجائزة",
                    Action = "update",
                    PermissionHeaderId = 5,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //---------Circilar-----------
                new Permission()
                {
                    // Id = 16,
                    Name = "إضافة التعاميم",
                    Action = "create",
                    PermissionHeaderId = 6,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 17,
                    Name = "عرض التعاميم",
                    Action = "read",
                    PermissionHeaderId = 6,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                 new Permission()
                 {
                     // Id = 18,
                     Name = "تعديل التعاميم",
                     Action = "update",
                     PermissionHeaderId = 6,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 }, new Permission()
                 {
                     // Id = 19,
                     Name = "حذف التعاميم",
                     Action = "delete",
                     PermissionHeaderId = 6,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 20,
                     Name = "تصدير التعاميم",
                     Action = "xlsx-exportable",
                     PermissionHeaderId = 6,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                //---------Class-----------
                new Permission()
                {
                    // Id = 21,
                    Name = "إضافة الصفوف",
                    Action = "create",
                    PermissionHeaderId = 7,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 22,
                    Name = "عرض الصفوف",
                    Action = "read",
                    PermissionHeaderId = 7,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                 new Permission()
                 {
                     // Id = 23,
                     Name = "تعديل الصفوف",
                     Action = "update",
                     PermissionHeaderId = 7,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 }, new Permission()
                 {
                     // Id = 24,
                     Name = "حذف الصفوف",
                     Action = "delete",
                     PermissionHeaderId = 7,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 25,
                     Name = "تصدير الصفوف",
                     Action = "xlsx-exportable",
                     PermissionHeaderId = 7,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 //-------------ClassArbitrator-----------------
                 new Permission()
                 {
                     // Id = 26,
                     Name = "إضافة محكم صف",
                     Action = "create",
                     PermissionHeaderId = 8,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 }, new Permission()
                 {
                     // Id = 27,
                     Name = "عرض محكم صف",
                     Action = "read",
                     PermissionHeaderId = 8,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 new Permission()
                 {
                     // Id = 28,
                     Name = "حذف محكم صف",
                     Action = "delete",
                     PermissionHeaderId = 8,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 29,
                     Name = "تصدير محكم صف",
                     Action = "xlsx-exportable",
                     PermissionHeaderId = 8,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                //-----------Cycle------------
                new Permission()
                {
                    // Id = 30,
                    Name = "عرض الدورات",
                    Action = "read",
                    PermissionHeaderId = 9,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 31,
                    Name = "إضافة دورة",
                    Action = "create",
                    PermissionHeaderId = 9,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 32,
                    Name = "عرض معلومات دورة",
                    Action = "read",
                    PermissionHeaderId = 9,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 33,
                    Name = "تعديل دورة",
                    Action = "update",
                    PermissionHeaderId = 9,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 34,
                    Name = "حذف دورة",
                    Action = "delete",
                    PermissionHeaderId = 9,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 35,
                    Name = "تصدير دورة",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 9,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------Agenda----------------
                new Permission()
                {
                    // Id = 36,
                    Name = "إضافة أجندة",
                    Action = "create",
                    PermissionHeaderId = 10,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 37,
                    Name = "عرض أجندة",
                    Action = "read",
                    PermissionHeaderId = 10,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 38,
                    Name = "تعديل أجندة",
                    Action = "update",
                    PermissionHeaderId = 10,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 39,
                    Name = "حذف أجندة",
                    Action = "delete",
                    PermissionHeaderId = 10,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 40,
                    Name = "تصدير أجندة",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 10,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------Category----------------
                new Permission()
                {
                    // Id = 41,
                    Name = "إضافة فئات",
                    Action = "create",
                    PermissionHeaderId = 11,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 42,
                    Name = "عرض فئات",
                    Action = "read",
                    PermissionHeaderId = 11,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 43,
                    Name = "تعديل فئات",
                    Action = "update",
                    PermissionHeaderId = 11,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 44,
                    Name = "حذف فئات",
                    Action = "delete",
                    PermissionHeaderId = 11,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 45,
                    Name = "تصدير فئات",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 11,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------GeneralCondition----------------
                new Permission()
                {
                    // Id = 46,
                    Name = "إضافة شروط عامة",
                    Action = "create",
                    PermissionHeaderId = 12,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 47,
                    Name = "عرض شروط عامة",
                    Action = "read",
                    PermissionHeaderId = 12,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 48,
                    Name = "تعديل شروط عامة",
                    Action = "update",
                    PermissionHeaderId = 12,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 49,
                    Name = "حذف شروط عامة",
                    Action = "delete",
                    PermissionHeaderId = 12,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 50,
                    Name = "تصدير شروط عامة",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 12,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------EducationalEntity----------------
                new Permission()
                {
                    // Id = 51,
                    Name = "إضافة جهات تعليمية",
                    Action = "create",
                    PermissionHeaderId = 13,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 52,
                    Name = "عرض جهات تعليمية",
                    Action = "read",
                    PermissionHeaderId = 13,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 53,
                    Name = "تعديل جهات تعليمية",
                    Action = "update",
                    PermissionHeaderId = 13,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 54,
                    Name = "حذف جهات تعليمية",
                    Action = "delete",
                    PermissionHeaderId = 13,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 55,
                    Name = "تصدير معرض الصور",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 13,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------SystemFiles----------------
                new Permission()
                {
                    // Id = 56,
                    Name = "عرض ملفات النظام",
                    Action = "read",
                    PermissionHeaderId = 14,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 57,
                    Name = "تحميل ملفات النظام",
                    Action = "download",
                    PermissionHeaderId = 14,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------GeneralWorkshop----------------
                new Permission()
                {
                    // Id = 58,
                    Name = "إضافة ورش تدريبية عامة",
                    Action = "create",
                    PermissionHeaderId = 15,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 59,
                    Name = "عرض ورش تدريبية عامة",
                    Action = "read",
                    PermissionHeaderId = 15,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 60,
                    Name = "تعديل ورش تدريبية عامة",
                    Action = "update",
                    PermissionHeaderId = 15,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 61,
                    Name = "حذف ورش تدريبية عامة",
                    Action = "delete",
                    PermissionHeaderId = 15,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 62,
                    Name = "تصدير معرض الصور",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 15,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------Instruction----------------
                new Permission()
                {
                    // Id = 63,
                    Name = "عرض التعليمات",
                    Action = "read",
                    PermissionHeaderId = 16,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 64,
                    Name = "تعديل التعليمات",
                    Action = "update",
                    PermissionHeaderId = 16,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 65,
                    Name = "تصدير التعليمات",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 16,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------Meeting----------------
                new Permission()
                {
                    // Id = 66,
                    Name = "إضافة الإجتماعات",
                    Action = "create",
                    PermissionHeaderId = 17,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 67,
                    Name = "عرض الإجتماعات",
                    Action = "read",
                    PermissionHeaderId = 17,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 68,
                    Name = "تعديل الإجتماعات",
                    Action = "update",
                    PermissionHeaderId = 17,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 69,
                    Name = "حذف الإجتماعات",
                    Action = "delete",
                    PermissionHeaderId = 17,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 70,
                    Name = "تصدير الإجتماعات",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 17,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 71,
                    Name = "إرسال بريد إلكتروني للإجتماعات",
                    Action = "send_emails",
                    PermissionHeaderId = 17,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 72,
                    Name = "إلغاء الإجتماعات",
                    Action = "cancel",
                    PermissionHeaderId = 17,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------News----------------
                new Permission()
                {
                    // Id = 73,
                    Name = "إضافة الأخبار",
                    Action = "create",
                    PermissionHeaderId = 18,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 74,
                    Name = "عرض الأخبار",
                    Action = "read",
                    PermissionHeaderId = 18,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 75,
                    Name = "تعديل الأخبار",
                    Action = "update",
                    PermissionHeaderId = 18,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 76,
                    Name = "حذف الأخبار",
                    Action = "delete",
                    PermissionHeaderId = 18,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 77,
                    Name = "تصدير الأخبار",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 18,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------Notification----------------
                new Permission()
                {
                    // Id = 78,
                    Name = "إضافة الإشعارات",
                    Action = "create",
                    PermissionHeaderId = 19,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 79,
                    Name = "عرض الإشعارات",
                    Action = "read",
                    PermissionHeaderId = 19,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 80,
                    Name = "تعديل الإشعارات",
                    Action = "update",
                    PermissionHeaderId = 19,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 81,
                    Name = "حذف الإشعارات",
                    Action = "delete",
                    PermissionHeaderId = 19,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 82,
                    Name = "تصدير الإشعارات",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 19,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------NotificationTemplate----------------
                new Permission()
                {
                    // Id = 83,
                    Name = "إضافة قالب الإشعارات",
                    Action = "create",
                    PermissionHeaderId = 20,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 84,
                    Name = "عرض قالب الإشعارات",
                    Action = "read",
                    PermissionHeaderId = 20,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 85,
                    Name = "تعديل قالب الإشعارات",
                    Action = "update",
                    PermissionHeaderId = 20,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 86,
                    Name = "حذف قالب الإشعارات",
                    Action = "delete",
                    PermissionHeaderId = 20,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 87,
                    Name = "تصدير قالب الإشعارات",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 20,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------Role----------------
                new Permission()
                {
                    // Id = 88,
                    Name = "إضافة دور",
                    Action = "create",
                    PermissionHeaderId = 21,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 89,
                    Name = "عرض دور",
                    Action = "read",
                    PermissionHeaderId = 21,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 90,
                    Name = "تعديل دور",
                    Action = "update",
                    PermissionHeaderId = 21,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 91,
                    Name = "حذف دور",
                    Action = "delete",
                    PermissionHeaderId = 21,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 92,
                    Name = "تصدير دور",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 21,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------User----------------
                new Permission()
                {
                    // Id = 93,
                    Name = "إضافة مستخدم",
                    Action = "create",
                    PermissionHeaderId = 22,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 94,
                    Name = "عرض مستخدم",
                    Action = "read",
                    PermissionHeaderId = 22,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 95,
                    Name = "تعديل مستخدم",
                    Action = "update",
                    PermissionHeaderId = 22,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 96,
                    Name = "حذف مستخدم",
                    Action = "delete",
                    PermissionHeaderId = 22,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 97,
                    Name = "تصدير مستخدم",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 22,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 98,
                    Name = "تغيير كلمة سر المستخدم",
                    Action = "user_change_password",
                    PermissionHeaderId = 22,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },

                //------------Coordinator----------------
                new Permission()
                {
                    // Id = 99,
                    Name = "إضافة منسق",
                    Action = "create",
                    PermissionHeaderId = 23,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 100,
                    Name = "عرض منسق",
                    Action = "read",
                    PermissionHeaderId = 23,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 101,
                    Name = "تعديل منسق",
                    Action = "update",
                    PermissionHeaderId = 23,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 102,
                    Name = "حذف منسق",
                    Action = "delete",
                    PermissionHeaderId = 23,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 103,
                    Name = "تصدير منسق",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 23,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 104,
                    Name = "حقول ديناميكية للمنسقين",
                    Action = "coordinator_dynamic_fields",
                    PermissionHeaderId = 23,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------Arbitrator----------------
                new Permission()
                {
                    // Id = 105,
                    Name = "إضافة محكم",
                    Action = "create",
                    PermissionHeaderId = 24,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 106,
                    Name = "عرض محكم",
                    Action = "read",
                    PermissionHeaderId = 24,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 107,
                    Name = "تعديل محكم",
                    Action = "update",
                    PermissionHeaderId = 24,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 108,
                    Name = "حذف محكم",
                    Action = "delete",
                    PermissionHeaderId = 24,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 109,
                    Name = "تصدير محكم",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 24,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 110,
                    Name = "حقول ديناميكية للمحكمين",
                    Action = "arbitrator_dynamic_fields",
                    PermissionHeaderId = 24,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------Committee----------------
                new Permission()
                {
                    // Id = 111,
                    Name = "إضافة لجنة",
                    Action = "create",
                    PermissionHeaderId = 25,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 112,
                    Name = "عرض لجنة",
                    Action = "read",
                    PermissionHeaderId = 25,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 113,
                    Name = "تعديل لجنة",
                    Action = "update",
                    PermissionHeaderId = 25,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 114,
                    Name = "حذف لجنة",
                    Action = "delete",
                    PermissionHeaderId = 25,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 115,
                    Name = "تصدير لجنة",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 25,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------SubscriberAccount----------------
                new Permission()
                {
                    // Id = 116,
                    Name = "إضافة حساب المشترك",
                    Action = "create",
                    PermissionHeaderId = 26,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 117,
                    Name = "عرض حساب المشترك",
                    Action = "read",
                    PermissionHeaderId = 26,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 118,
                    Name = "تعديل حساب المشترك",
                    Action = "update",
                    PermissionHeaderId = 26,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 119,
                    Name = "حذف حساب المشترك",
                    Action = "delete",
                    PermissionHeaderId = 26,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 120,
                    Name = "تصدير حساب المشترك",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 26,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 121,
                    Name = "تغيير كلمة سر المشترك",
                    Action = "subscriber_change_password",
                    PermissionHeaderId = 26,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 122,
                    Name = "تأكيد الحساب",
                    Action = "verify_account",
                    PermissionHeaderId = 26,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------SubscriberProfile----------------
                new Permission()
                {
                    // Id = 123,
                    Name = "عرض ملف المشترك",
                    Action = "read",
                    PermissionHeaderId = 27,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 124,
                    Name = "تصدير ملف المشترك",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 27,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 125,
                    Name = "قراءة كمشترك",
                    Action = "read_as_subscriber",
                    PermissionHeaderId = 27,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                 //------------SubscriberForm----------------
                 new Permission()
                 {
                     // Id = 126,
                     Name = "عرض إستمارة المشترك",
                     Action = "read",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 }, new Permission()
                 {
                     // Id = 127,
                     Name = "حذف إستمارة المشترك",
                     Action = "delete",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 }, new Permission()
                 {
                     // Id = 128,
                     Name = "تصدير إستمارة المشترك",
                     Action = "xlsx-exportable",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 129,
                     Name = "رفض إستمارة",
                     Action = "reject",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 130,
                     Name = "قبول إستمارة",
                     Action = "accept",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 131,
                     Name = "معلومات الإستمارة",
                     Action = "information",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 132,
                     Name = "شروط الإستمارة",
                     Action = "conditions",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 133,
                     Name = "شروط الإستمارة",
                     Action = "attachments",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 134,
                     Name = "معايير الإستمارة",
                     Action = "criteria",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 135,
                     Name = "فريق الجائزة الإستمارة",
                     Action = "award_team",
                     PermissionHeaderId = 28,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                //------------Event----------------
                new Permission()
                {
                    // Id = 136,
                    Name = "إضافة فعالية",
                    Action = "create",
                    PermissionHeaderId = 29,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 137,
                    Name = "عرض فعالية",
                    Action = "read",
                    PermissionHeaderId = 29,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 138,
                    Name = "تعديل فعالية",
                    Action = "update",
                    PermissionHeaderId = 29,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 139,
                    Name = "حذف فعالية",
                    Action = "delete",
                    PermissionHeaderId = 29,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 140,
                    Name = "تصدير فعالية",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 29,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                 //------------ContactUs----------------
                 new Permission()
                 {
                     // Id = 141,
                     Name = "عرض رسالة تواصل",
                     Action = "read",
                     PermissionHeaderId = 30,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 }, new Permission()
                 {
                     // Id = 142,
                     Name = "حذف رسالة تواصل",
                     Action = "delete",
                     PermissionHeaderId = 30,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 }, new Permission()
                 {
                     // Id = 143,
                     Name = "تصدير رسالة تواصل",
                     Action = "xlsx-exportable",
                     PermissionHeaderId = 30,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 144,
                     Name = "تحويل الرسالة",
                     Action = "forward_message",
                     PermissionHeaderId = 30,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 145,
                     Name = "إغلاق الرسالة",
                     Action = "close_message",
                     PermissionHeaderId = 30,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 146,
                     Name = "الرد على الرسالة",
                     Action = "replay",
                     PermissionHeaderId = 30,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 147,
                     Name = "قراءة الرد",
                     Action = "read_replies",
                     PermissionHeaderId = 30,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 //------------ExplanatoryMessage----------------
                 new Permission()
                 {
                     // Id = 148,
                     Name = "عرض رسالة توضيحية",
                     Action = "read",
                     PermissionHeaderId = 31,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 }, new Permission()
                 {
                     // Id = 149,
                     Name = "تعديل رسالة توضيحية",
                     Action = "update",
                     PermissionHeaderId = 31,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null
                 },
                //------------Responsibility----------------
                new Permission()
                {
                    // Id = 150,
                    Name = "إضافة مسؤولية",
                    Action = "create",
                    PermissionHeaderId = 32,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 151,
                    Name = "عرض مسؤولية",
                    Action = "read",
                    PermissionHeaderId = 32,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 152,
                    Name = "تعديل مسؤولية",
                    Action = "update",
                    PermissionHeaderId = 32,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 153,
                    Name = "حذف مسؤولية",
                    Action = "delete",
                    PermissionHeaderId = 32,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                },
                //------------GeneralFAQ----------------
                new Permission()
                {
                    // Id = 154,
                    Name = "إضافة الأسئلة الشائعة العامة",
                    Action = "create",
                    PermissionHeaderId = 33,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 155,
                    Name = "عرض الأسئلة الشائعة العامة",
                    Action = "read",
                    PermissionHeaderId = 33,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 156,
                    Name = "تعديل الأسئلة الشائعة العامة",
                    Action = "update",
                    PermissionHeaderId = 33,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 157,
                    Name = "حذف الأسئلة الشائعة العامة",
                    Action = "delete",
                    PermissionHeaderId = 33,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                },
                //------------FAQCategory----------------
                new Permission()
                {
                    // Id = 158,
                    Name = "إضافة فئة الأسئلة الشائعة",
                    Action = "create",
                    PermissionHeaderId = 34,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 159,
                    Name = "عرض فئة الأسئلة الشائعة",
                    Action = "read",
                    PermissionHeaderId = 34,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 160,
                    Name = "تعديل فئة الأسئلة الشائعة",
                    Action = "update",
                    PermissionHeaderId = 34,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 161,
                    Name = "حذف فئة الأسئلة الشائعة",
                    Action = "delete",
                    PermissionHeaderId = 34,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                },
                //------------AwardStatistic----------------
                new Permission()
                {
                    // Id = 162,
                    Name = "إضافة إحصائيات الجائزة",
                    Action = "create",
                    PermissionHeaderId = 35,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 163,
                    Name = "عرض إحصائيات الجائزة",
                    Action = "read",
                    PermissionHeaderId = 35,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 164,
                    Name = "تعديل إحصائيات الجائزة",
                    Action = "update",
                    PermissionHeaderId = 35,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 165,
                    Name = "حذف إحصائيات الجائزة",
                    Action = "delete",
                    PermissionHeaderId = 35,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                },
                //------------Slider----------------
                new Permission()
                {
                    // Id = 166,
                    Name = "إضافة شرائح",
                    Action = "create",
                    PermissionHeaderId = 36,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 167,
                    Name = "عرض شرائح",
                    Action = "read",
                    PermissionHeaderId = 36,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 168,
                    Name = "تعديل شرائح",
                    Action = "update",
                    PermissionHeaderId = 36,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 169,
                    Name = "حذف شرائح",
                    Action = "delete",
                    PermissionHeaderId = 36,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                },
                //------------StrategicPartner----------------
                new Permission()
                {
                    // Id = 170,
                    Name = "تعديل شريك إستراتيجي",
                    Action = "update",
                    PermissionHeaderId = 37,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------CustomPages----------------
                new Permission()
                {
                    // Id = 171,
                    Name = "إضافة صفحة",
                    Action = "create",
                    PermissionHeaderId = 38,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 172,
                    Name = "عرض صفحة",
                    Action = "read",
                    PermissionHeaderId = 38,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 173,
                    Name = "تعديل صفحة",
                    Action = "update",
                    PermissionHeaderId = 38,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 174,
                    Name = "حذف صفحة",
                    Action = "delete",
                    PermissionHeaderId = 38,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                },
                 //------------ArbitrationSorting----------------
                 new Permission()
                 {
                     // Id = 175,
                     Name = "عرض فرز التحكيم",
                     Action = "read",
                     PermissionHeaderId = 39,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 176,
                     Name = "تعديل فرز التحكيم",
                     Action = "update",
                     PermissionHeaderId = 39,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 //------------ArbitrationAssign----------------
                 new Permission()
                 {
                     // Id = 177,
                     Name = "عرض إسناد التحكيم",
                     Action = "read",
                     PermissionHeaderId = 40,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 178,
                     Name = "تعديل إسناد التحكيم",
                     Action = "update",
                     PermissionHeaderId = 40,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 //------------ArbitrationFirst----------------
                 new Permission()
                 {
                     // Id = 179,
                     Name = "عرض التحكيم الأولي",
                     Action = "read",
                     PermissionHeaderId = 41,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 180,
                     Name = "تعديل التحكيم الأولي",
                     Action = "update",
                     PermissionHeaderId = 41,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 //------------ArbitrationAudit----------------
                 new Permission()
                 {
                     // Id = 181,
                     Name = "عرض تدقيق التحكيم",
                     Action = "read",
                     PermissionHeaderId = 42,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 182,
                     Name = "تعديل تدقيق التحكيم",
                     Action = "update",
                     PermissionHeaderId = 42,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 //------------Interview----------------
                 new Permission()
                 {
                     // Id = 183,
                     Name = "عرض مقابلات التحكيم",
                     Action = "read",
                     PermissionHeaderId = 43,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 184,
                     Name = "إضافة مقابلة",
                     Action = "create",
                     PermissionHeaderId = 43,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 185,
                     Name = "تعديل مقابلات التحكيم",
                     Action = "update",
                     PermissionHeaderId = 43,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 186,
                     Name = "إلغاء مقابلات التحكيم",
                     Action = "cancel",
                     PermissionHeaderId = 43,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 187,
                     Name = "إرسال البريد الإلكتروني",
                     Action = "send_emails",
                     PermissionHeaderId = 43,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 //------------ArbitrationFinal----------------
                 new Permission()
                 {
                     // Id = 188,
                     Name = "عرض التحكيم النهائي",
                     Action = "read",
                     PermissionHeaderId = 44,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 189,
                     Name = "تعديل التحكيم النهائي",
                     Action = "update",
                     PermissionHeaderId = 44,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 //------------ResultsArbitration----------------
                 new Permission()
                 {
                     // Id = 190,
                     Name = "عرض نتائج التحكيم",
                     Action = "read",
                     PermissionHeaderId = 45,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 191,
                     Name = "تعديل نتائج التحكيم",
                     Action = "update",
                     PermissionHeaderId = 45,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                 //------------ArbitrationWinners----------------
                 new Permission()
                 {
                     // Id = 192,
                     Name = "عرض تحكيم الفائزين",
                     Action = "read",
                     PermissionHeaderId = 46,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 }, new Permission()
                 {
                     // Id = 193,
                     Name = "تعديل تحكيم الفائزين",
                     Action = "update",
                     PermissionHeaderId = 46,
                     isDeleted = false,
                     CreatedAt = DateTime.UtcNow,
                     CreatedBy = null,
                     DeletedAt = null,
                     LastModifiedAt = null,
                     LastModifiedBy = null

                 },
                //---------------MessageType---------------
                new Permission()
                {
                    // Id = 192,
                    Name = "عرض أنواع رسائل التواصل",
                    Action = "read",
                    PermissionHeaderId = 48,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 193,
                    Name = "تعديل تحكيم الفائزين",
                    Action = "update",
                    PermissionHeaderId = 48,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 184,
                    Name = "إضافة أنواع رسائل لتواصل",
                    Action = "create",
                    PermissionHeaderId = 48,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 184,
                    Name = "حذف أنواع رسائل لتواصل",
                    Action = "delete",
                    PermissionHeaderId = 48,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 184,
                    Name = "إسناد الى دور",
                    Action = "asignToRole",
                    PermissionHeaderId = 48,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 184,
                    Name = "عرض ادارة التحكيم",
                    Action = "read",
                    PermissionHeaderId = 49,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                }, new Permission()
                {
                    // Id = 184,
                    Name = "تصدير ادارة التحكيم",
                    Action = "xlsx-exportable",
                    PermissionHeaderId = 49,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                },
                //------------StrategicPartner----------------
                new Permission()
                {
                    // Id = 185,
                    Name = "إضافة شريك إستراتيجي",
                    Action = "create",
                    PermissionHeaderId = 37,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 186,
                    Name = "حذف شريك إستراتيجي",
                    Action = "delete",
                    PermissionHeaderId = 37,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 187,
                    Name = "عرض الشركاء الاستراتيجيين",
                    Action = "read",
                    PermissionHeaderId = 37,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    // Id = 188,
                    Name = "عرض تفاصيل التعميم",
                    Action = "show-details",
                    PermissionHeaderId = 6,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null

                });
               await _context.SaveChangesAsync();
            }
        }

    }
}
