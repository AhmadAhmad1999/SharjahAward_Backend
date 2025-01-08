namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetCertificationByFormId
{
    public class GetCertificationByFormIdDto
    {
        public string CertificateFilePath { get; set; } = null!;
        public int CertificateTemplateId { get; set; }
        public string CertificateTemplateVersion { get; set; } = null!;
        public int CertificateDigitalSignatureId { get; set; }
        public string CertificateDigitalSignatureUserName { get; set; } = null!;
        public DateTime? DateOfObtainingTheCertificate { get; set; }
        
        public string Statment1FilePath { get; set; } = null!;
        public int Statment1TemplateId { get; set; }
        public string Statment1TemplateVersion { get; set; } = null!;
        public int Statment1DigitalSignatureId { get; set; }
        public string Statment1DigitalSignatureUserName { get; set; } = null!;
        public DateTime? DateOfObtainingTheStatement1 { get; set; }

        public string Statment2FilePath { get; set; } = null!;
        public int Statment2TemplateId { get; set; }
        public string Statment2TemplateVersion { get; set; } = null!;
        public int Statment2DigitalSignatureId { get; set; }
        public string Statment2DigitalSignatureUserName { get; set; } = null!;
        public DateTime? DateOfObtainingTheStatement2 { get; set; }
    }
}
