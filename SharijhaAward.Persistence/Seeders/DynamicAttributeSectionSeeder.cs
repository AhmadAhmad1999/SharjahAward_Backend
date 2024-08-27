using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class DynamicAttributeSectionSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public DynamicAttributeSectionSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.DynamicAttributeSections.Any())
            {
                _context.DynamicAttributeSections.AddRange(
                    new DynamicAttributeSection()
                    {
                        ArabicName = "اختبار اسم 1",
                        EnglishName = "Test Name 1",
                        isDeleted = false,
                        AttributeTableNameId = 1,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        RecordIdOnRelation = 2,
                        Id = 1,
                        OrderId = 1
                    }
                );
                _context.SaveChanges();
            }
        }
    }
}
