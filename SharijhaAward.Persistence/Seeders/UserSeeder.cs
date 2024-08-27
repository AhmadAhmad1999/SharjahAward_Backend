using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class UserSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public UserSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Users.Any())
            {
                _context.Users.AddRange(
                   new User()
                   {
                       isDeleted = false,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       // Id = 10,
                       Email = "Coordinator@Coordinator.com",
                       PhoneNumber = "0993521579",
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       EnglishName = "Coordinator 1",
                       ArabicName = "منسق 1",
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       Gender = Gender.Male,
                       ImageURL = null
                   }, new User()
                   {
                       isDeleted = false,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       // Id = 11,
                       Email = "Coordinator2@Coordinator2.com",
                       PhoneNumber = "0993521579",
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       EnglishName = "Coordinator 2",
                       ArabicName = "منسق 2",
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       Gender = Gender.Male,
                       ImageURL = null
                   }, new User()
                   {
                       isDeleted = false,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       // Id = 12,
                       Email = "Coordinator3@Coordinator3.com",
                       PhoneNumber = "0993521579",
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       EnglishName = "Coordinator 3",
                       ArabicName = "منسق 3",
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       Gender = Gender.Male,
                       ImageURL = null
                   }, new User()
                   {
                       isDeleted = false,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       // Id = 13,
                       Email = "Coordinator4@Coordinator4.com",
                       PhoneNumber = "0993521579",
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       EnglishName = "Coordinator 4",
                       ArabicName = "منسق 4",
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       Gender = Gender.Male,
                       ImageURL = null
                   }, new User()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "ادمن 123",
                       Email = "admin@gmail.com",
                       PhoneNumber = "0993521579",
                       EnglishName = "Admin 123",
                       Gender = Gender.Male,
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       // Id = 1,
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       ImageURL = null
                   }, new User()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "ادمن 123 #",
                       Email = "Ahmad@Ahmad.com",
                       PhoneNumber = "0993521579",
                       EnglishName = "Admin 123 #",
                       Gender = Gender.Male,
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       // Id = 2,
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       ImageURL = null
                   }, new User()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "ادمن 123 ##",
                       Email = "Ahmad2@Ahmad2.com",
                       PhoneNumber = "0993521579",
                       EnglishName = "Admin 123 ##",
                       Gender = Gender.Male,
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       // Id = 3,
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       ImageURL = null
                   }, new User()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "ادمن 123 ##@",
                       Email = "Ahmad3@Ahmad3.com",
                       PhoneNumber = "0993521579",
                       EnglishName = "Admin 123 ##@",
                       Gender = Gender.Male,
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       // Id = 4,
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       ImageURL = null
                   }, new User()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "ادمن 123 ##@@",
                       Email = "Ahmad4@Ahmad4.com",
                       PhoneNumber = "0993521579",
                       EnglishName = "Admin 123 ##@@",
                       Gender = Gender.Male,
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       // Id = 5,
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       ImageURL = null
                   }, new User()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "تامر",
                       Email = "tamer@gmail.com",
                       PhoneNumber = "0993521579",
                       EnglishName = "Tamer",
                       Gender = Gender.Male,
                       Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                       // Id = 6,
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       ImageURL = null,
                       SubscriberId = "ABC123"
                   });
                _context.SaveChanges();
            }
        }
    }
}
