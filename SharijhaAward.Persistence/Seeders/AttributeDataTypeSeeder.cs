﻿using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class AttributeDataTypeSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public AttributeDataTypeSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.AttributeDataTypes.Any())
            {
               await _context.AttributeDataTypes.AddRangeAsync(
                   new AttributeDataType()
                     {
                    // Id =1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Text",
                    ArabicName = "نص"
                }, new AttributeDataType()
                {
                    // Id =2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Email",
                    ArabicName = "بريد إلكتروني"
                }, new AttributeDataType()
                {
                    // Id =3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Image",
                    ArabicName = "صورة"
                }, new AttributeDataType()
                {
                    // Id =4,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "File",
                    ArabicName = "ملف"
                }, new AttributeDataType()
                {
                    // Id =5,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Phone Number",
                    ArabicName = "رقم هاتف متحرك"
                }, new AttributeDataType()
                {
                    // Id =6,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Number",
                    ArabicName = "رقم"
                }, new AttributeDataType()
                {
                    // Id =7,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Date",
                    ArabicName = "تاريخ"
                }, new AttributeDataType()
                {
                    // Id =8,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "List",
                    ArabicName = "قائمة منسدلة"
                }, new AttributeDataType()
                {
                    // Id =9,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Location",
                    ArabicName = "موقع"
                }, new AttributeDataType()
                {
                    // Id =10,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Emirates ID number",
                    ArabicName = "رقم هوية إماراتية"
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
