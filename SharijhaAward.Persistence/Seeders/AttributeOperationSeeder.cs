using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class AttributeOperationSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public AttributeOperationSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.AttributeOperations.Any())
            {
                _context.AttributeOperations.AddRange(
                   new AttributeOperation()
                   {
                       // Id =1,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       OperationAsString = ">"
                   }, new AttributeOperation()
                   {
                       // Id =2,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       OperationAsString = ">="
                   }, new AttributeOperation()
                   {
                       // Id =3,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       OperationAsString = "<"
                   }, new AttributeOperation()
                   {
                       // Id =4,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       OperationAsString = "<="
                   }, new AttributeOperation()
                   {
                       // Id =5,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       OperationAsString = "="
                   }, new AttributeOperation()
                   {
                       // Id =6,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       OperationAsString = "!="
                   }, new AttributeOperation()
                   {
                       // Id =7,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       OperationAsString = "is Empty"
                   }, new AttributeOperation()
                   {
                       // Id =8,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       isDeleted = false,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       OperationAsString = "is not Empty"
                   }
                );
                _context.SaveChanges();
            }
        }
    }
}
