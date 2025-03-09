using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.SavedCertificateModel;

namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetCertificationByFormId
{
    public class GetCertificationByFormIdHandler : IRequestHandler<GetCertificationByFormIdQuery, BaseResponse<GetCertificationByFormIdDto>>
    {
        private readonly IAsyncRepository<SavedCertificate> _SavedCertificateRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public GetCertificationByFormIdHandler(IAsyncRepository<SavedCertificate> SavedCertificateRepository,
            IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            _SavedCertificateRepository = SavedCertificateRepository;
            this._ArbitrationResultRepository = _ArbitrationResultRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }
        public async Task<BaseResponse<GetCertificationByFormIdDto>> Handle(GetCertificationByFormIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<SavedCertificate> SavedCertificateEntity = await _SavedCertificateRepository
                .Where(x => x.ProvidedFormId == Request.FormId)
                .ToListAsync();

            ArbitrationResult? ArbitrationResultEntity = await _ArbitrationResultRepository
                .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);

            GetCertificationByFormIdDto Response = new GetCertificationByFormIdDto();

            SavedCertificate? Certificate = SavedCertificateEntity
                .FirstOrDefault(x => x.TemplateType == Domain.Entities.TemplateModel.TemplateTypes.CertificateOfParticipation);

            if (Certificate is not null)
            {
                Response.CertificateDigitalSignatureId = Certificate.Id;
                Response.CertificateTemplateVersion = Certificate.Template!.TemplateVersion;
                Response.CertificateTemplateId = Certificate.TemplateId;
                Response.CertificateDigitalSignatureUserName = Certificate.DigitalSignature!.UserName;
                Response.DateOfObtainingTheCertificate = ArbitrationResultEntity!.DateOfObtainingTheCertificate;

                if (Certificate.FilePath.Contains("wwwroot"))
                {
                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    string WWWRootFilePath = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                    Response.CertificateFilePath = (WWWRootFilePath + Certificate.FilePath.Split("wwwroot")[1]).Replace("\\", "/");
                }

                else
                    Response.CertificateFilePath = Certificate.FilePath;
            }

            SavedCertificate? Statment1 = SavedCertificateEntity
                .FirstOrDefault(x => x.TemplateType == Domain.Entities.TemplateModel.TemplateTypes.Testimonial_Version_1);

            if (Statment1 is not null)
            {
                Response.Statment1DigitalSignatureId = Statment1.Id;
                Response.Statment1TemplateVersion = Statment1.Template!.TemplateVersion;
                Response.Statment1TemplateId = Statment1.TemplateId;
                Response.Statment1DigitalSignatureUserName = Statment1.DigitalSignature!.UserName;
                Response.DateOfObtainingTheStatement1 = ArbitrationResultEntity!.DateOfObtainingTheStatement1;

                if (Statment1.FilePath.Contains("wwwroot"))
                {
                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    string WWWRootFilePath = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                    Response.Statment1FilePath = (WWWRootFilePath + Statment1.FilePath.Split("wwwroot")[1]).Replace("\\", "/");
                }

                else
                    Response.Statment1FilePath = Statment1.FilePath;
            }

            SavedCertificate? Statment2 = SavedCertificateEntity
                .FirstOrDefault(x => x.TemplateType == Domain.Entities.TemplateModel.TemplateTypes.Testimonial_Version_2);

            if (Statment2 is not null)
            {
                Response.Statment2DigitalSignatureId = Statment2.Id;
                Response.Statment2TemplateVersion = Statment2.Template!.TemplateVersion;
                Response.Statment2TemplateId = Statment2.TemplateId;
                Response.Statment2DigitalSignatureUserName = Statment2.DigitalSignature!.UserName;
                Response.DateOfObtainingTheStatement2 = ArbitrationResultEntity!.DateOfObtainingTheStatement2;

                if (Statment2.FilePath.Contains("wwwroot"))
                {
                    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    string WWWRootFilePath = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                    Response.Statment2FilePath = (WWWRootFilePath + Statment2.FilePath.Split("wwwroot")[1]).Replace("\\", "/");
                }
                else
                    Response.Statment2FilePath = Statment2.FilePath;
            }

            return new BaseResponse<GetCertificationByFormIdDto>(ResponseMessage, true, 200, Response);
        }
    }
}
