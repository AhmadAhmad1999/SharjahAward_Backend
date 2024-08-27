using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class DynamicAttributeSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public DynamicAttributeSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.DynamicAttributes.Any())
            {
                _context.DynamicAttributes.AddRange(
                   new DynamicAttribute()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       // Id = 1,
                       OrderId = 1,
                       ArabicLabel = "اختبار نص 1",
                       ArabicTitle = "اختبار نص 1",
                       ArabicPlaceHolder = "اختبار نص 1",
                       AttributeDataTypeId = 1,
                       DynamicAttributeSectionId = 1,
                       EnglishLabel = "Test Text 1",
                       EnglishTitle = "Test Text 1",
                       EnglishPlaceHolder = "Test Text 1",
                       IsRequired = true,
                       IsUnique = true,
                       MaxSizeInKB = null,
                       Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                       LinkedToAnotherAttribute = false
                   }, new DynamicAttribute()
                   {
                       // Id = 2,
                       OrderId = 2,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicLabel = "اختبار ايميل 1",
                       ArabicTitle = "اختبار ايميل 1",
                       ArabicPlaceHolder = "اختبار ايميل 1",
                       AttributeDataTypeId = 2,
                       DynamicAttributeSectionId = 1,
                       EnglishLabel = "Test Email 1",
                       EnglishTitle = "Test Email 1",
                       EnglishPlaceHolder = "Test Email 1",
                       IsRequired = true,
                       IsUnique = true,
                       MaxSizeInKB = null,
                       Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                       LinkedToAnotherAttribute = false
                   }, new DynamicAttribute()
                   {
                       // Id = 3,
                       OrderId = 3,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicLabel = "اختبار صورة 1",
                       ArabicTitle = "اختبار صورة 1",
                       ArabicPlaceHolder = "اختبار صورة 1",
                       AttributeDataTypeId = 3,
                       DynamicAttributeSectionId = 1,
                       EnglishLabel = "Test Image 1",
                       EnglishTitle = "Test Image 1",
                       EnglishPlaceHolder = "Test Image 1",
                       IsRequired = false,
                       IsUnique = false,
                       MaxSizeInKB = 1028,
                       Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                       LinkedToAnotherAttribute = false
                   }, new DynamicAttribute()
                   {
                       // Id = 4,
                       OrderId = 4,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicTitle = "اختبار ملف 1",
                       ArabicLabel = "اختبار ملف 1",
                       ArabicPlaceHolder = "اختبار ملف 1",
                       AttributeDataTypeId = 4,
                       DynamicAttributeSectionId = 1,
                       EnglishLabel = "Test File 1",
                       EnglishTitle = "Test File 1",
                       EnglishPlaceHolder = "Test File 1",
                       IsRequired = false,
                       IsUnique = false,
                       MaxSizeInKB = 4112,
                       Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                       LinkedToAnotherAttribute = false
                   }, new DynamicAttribute()
                   {
                       // Id = 5,
                       OrderId = 5,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicLabel = "اختبار رقم متحرك 1",
                       ArabicTitle = "اختبار رقم متحرك 1",
                       ArabicPlaceHolder = "اختبار رقم متحرك 1",
                       AttributeDataTypeId = 5,
                       DynamicAttributeSectionId = 1,
                       EnglishLabel = "Test Phone Number 1",
                       EnglishTitle = "Test Phone Number 1",
                       EnglishPlaceHolder = "Test Phone Number 1",
                       IsRequired = false,
                       IsUnique = false,
                       MaxSizeInKB = null,
                       Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                       LinkedToAnotherAttribute = false
                   }, new DynamicAttribute()
                   {
                       // Id = 6,
                       OrderId = 6,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicLabel = "اختبار رقم 1",
                       ArabicTitle = "اختبار رقم 1",
                       ArabicPlaceHolder = "اختبار رقم 1",
                       AttributeDataTypeId = 6,
                       DynamicAttributeSectionId = 1,
                       EnglishLabel = "Test Number 1",
                       EnglishTitle = "Test Number 1",
                       EnglishPlaceHolder = "Test Number 1",
                       IsRequired = false,
                       IsUnique = false,
                       MaxSizeInKB = null,
                       Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                       LinkedToAnotherAttribute = false
                   }, new DynamicAttribute()
                   {
                       // Id = 7,
                       OrderId = 7,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicLabel = "اختبار تاريخ 1",
                       ArabicTitle = "اختبار تاريخ 1",
                       ArabicPlaceHolder = "اختبار تاريخ 1",
                       AttributeDataTypeId = 7,
                       DynamicAttributeSectionId = 1,
                       EnglishLabel = "Test Date 1",
                       EnglishTitle = "Test Date 1",
                       EnglishPlaceHolder = "Test Date 1",
                       IsRequired = false,
                       IsUnique = false,
                       MaxSizeInKB = null,
                       Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                       LinkedToAnotherAttribute = false
                   }, new DynamicAttribute()
                   {
                       // Id = 8,
                       OrderId = 8,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicLabel = "اختبار قائمة 1",
                       ArabicTitle = "اختبار قائمة 1",
                       ArabicPlaceHolder = "اختبار قائمة 1",
                       AttributeDataTypeId = 8,
                       DynamicAttributeSectionId = 1,
                       EnglishTitle = "Test List 1",
                       EnglishLabel = "Test List 1",
                       EnglishPlaceHolder = "Test List 1",
                       IsRequired = false,
                       IsUnique = false,
                       MaxSizeInKB = null,
                       Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                       LinkedToAnotherAttribute = false
                   });
                _context.SaveChanges();
            }
        }
    }
}
