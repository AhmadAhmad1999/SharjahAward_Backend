using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class AttributeTableNameSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public AttributeTableNameSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.AttributeTableNames.Any())
            {
               await _context.AttributeTableNames.AddRangeAsync(
                new AttributeTableName()
                {
                    // Id =1,
                    Name = "ProvidedForm",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new AttributeTableName()
                {
                    // Id =2,
                    Name = "Coordinator",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new AttributeTableName()
                {
                    // Id =3,
                    Name = "Arbitrator",
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
