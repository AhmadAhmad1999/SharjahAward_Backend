using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.CreateVirtualTableFroSection
{
    public class CreateVirtualTableForSectionHandler : IRequestHandler<CreateVirtualTableFroSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;

        public CreateVirtualTableForSectionHandler(IAsyncRepository<VirtualTableForSection> VirtualTableForSectionRepository)
        {
            _VirtualTableForSectionRepository = VirtualTableForSectionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateVirtualTableFroSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;
            
            VirtualTableForSection NewVirtualTableForSectionEntity = new VirtualTableForSection()
            {
                ArabicTitle = Request.ArabicTitle,
                EnglishTitle = Request.EnglishTitle,
                PrivateHashKey = string.Empty
            };

            await _VirtualTableForSectionRepository.AddAsync(NewVirtualTableForSectionEntity);
            
            byte[] salt = new byte[16] { 52, 123, 55, 148, 64, 30, 175, 37, 25, 240, 115, 57, 13, 255, 41, 74 };

            string PrivateHashKey = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: NewVirtualTableForSectionEntity.Id.ToString(),
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8)).Replace("/", "s1qa");

            NewVirtualTableForSectionEntity.PrivateHashKey = PrivateHashKey;

            await _VirtualTableForSectionRepository.UpdateAsync(NewVirtualTableForSectionEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء القسم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200, NewVirtualTableForSectionEntity.Id);
        }
    }
}
