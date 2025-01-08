using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Persistence.Seeders
{
    public class UserSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public UserSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Users.Any())
            {
               await _context.Users.AddRangeAsync(
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
                       PhoneNumber = "009710512345678",
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
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
                       PhoneNumber = "009710585469325",
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
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
                       PhoneNumber = "009710598563247",
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
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
                       PhoneNumber = "009710574596825",
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
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
                       PhoneNumber = "009710574596811",
                       EnglishName = "Admin 123",
                       Gender = Gender.Male,
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
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
                       PhoneNumber = "009710574596812",
                       EnglishName = "Admin 123 #",
                       Gender = Gender.Male,
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
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
                       PhoneNumber = "0097105745968213",
                       EnglishName = "Admin 123 ##",
                       Gender = Gender.Male,
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
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
                       PhoneNumber = "009710574596814",
                       EnglishName = "Admin 123 ##@",
                       Gender = Gender.Male,
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
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
                       PhoneNumber = "009710574596815",
                       EnglishName = "Admin 123 ##@@",
                       Gender = Gender.Male,
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
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
                       PhoneNumber = "009710574596816",
                       EnglishName = "Tamer",
                       Gender = Gender.Male,
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
                       // Id = 6,
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       ImageURL = null,
                       SubscriberId = "ABC123"
                   }, new User()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "يمان",
                       Email = "yamansakka5@gmail.com",
                       PhoneNumber = "009710574596817",
                       EnglishName = "yaman",
                       Gender = Gender.Male,
                       Password = "4f1ECSE0NjovtAqjILqi2++8Y6a5qxathsKFbaJcLCY=",
                       // Id = 7,
                       ConfirmationCodeForResetPassword = null,
                       ConfirmationCodeForSignUp = null,
                       isValidAccount = true,
                       ImageURL = null,
                       SubscriberId = "ABC124"
                   });
                 await _context.SaveChangesAsync();
            }
        }
    }
}
