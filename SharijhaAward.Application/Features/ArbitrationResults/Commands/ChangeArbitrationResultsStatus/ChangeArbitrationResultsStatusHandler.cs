using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Helpers.RecipientsWithViewsHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using SharijhaAward.Domain.Entities.SavedCertificateModel;
using SharijhaAward.Domain.Entities.TemplateModel;
using System.Globalization;
using System.Net.Http;
using System.Net.Mail;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationResults.Commands.ChangeArbitrationResultsStatus
{
    public class ChangeArbitrationResultsStatusHandler 
        : IRequestHandler<ChangeArbitrationResultsStatusCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<Template> _TemplateRepository;
        private readonly IAsyncRepository<DigitalSignature> _DigitalSignatureRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<FinalArbitrationScore> _FinalArbitrationScoreRepository;
        private readonly IAsyncRepository<SavedCertificate> _SavedCertificateRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IEmailSender _EmailSender;

        public ChangeArbitrationResultsStatusHandler(IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository,
            IAsyncRepository<Template> _TemplateRepository,
            IAsyncRepository<DigitalSignature> _DigitalSignatureRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<Criterion> _CriterionRepository,
            IAsyncRepository<CriterionItem> _CriterionItemRepository,
            IAsyncRepository<FinalArbitrationScore> _FinalArbitrationScoreRepository,
            IAsyncRepository<SavedCertificate> _SavedCertificateRepository,
            IHttpContextAccessor _HttpContextAccessor,
            IEmailSender _EmailSender)
        {
            this._ArbitrationResultRepository = _ArbitrationResultRepository;
            this._TemplateRepository = _TemplateRepository;
            this._DigitalSignatureRepository = _DigitalSignatureRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._CriterionRepository = _CriterionRepository;
            this._CriterionItemRepository = _CriterionItemRepository;
            this._FinalArbitrationScoreRepository = _FinalArbitrationScoreRepository;
            this._SavedCertificateRepository = _SavedCertificateRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._EmailSender = _EmailSender;
        }

        public async Task<BaseResponse<object>> 
            Handle(ChangeArbitrationResultsStatusCommand Request, CancellationToken cancellationToken)
        {
            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    string ResponseMessage = string.Empty;

                    if (!Request.JustSendEmail)
                    {
                        DigitalSignature? DigitalSignatureEntity = await _DigitalSignatureRepository
                            .FirstOrDefaultAsync(x => x.Id == Request.DigitalSignatureId);

                        if (DigitalSignatureEntity is null)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? "Digital signature is not found"
                                : "التوقيع الرقمي غير موجود";

                            return new BaseResponse<object>(ResponseMessage, true, 400);
                        }
                        else
                        {
                            byte[] salt = new byte[16] { 52, 123, 55, 148, 64, 30, 175, 37, 25, 240, 115, 57, 13, 255, 41, 74 };

                            Request.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                password: Request.Password!,
                                salt: salt,
                                prf: KeyDerivationPrf.HMACSHA256,
                                iterationCount: 100000,
                                numBytesRequested: 256 / 8));

                            if (DigitalSignatureEntity.UserName.ToLower() != Request.UserName!.ToLower() ||
                                DigitalSignatureEntity.Password != Request.Password)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Invalid user name or password"
                                    : "خطأ في اسم المستخدم أو كلمة المرور";

                                return new BaseResponse<object>(ResponseMessage, true, 400);
                            }
                        }

                        byte[] NotAuthenticatedHeaderImageBytes = await File.ReadAllBytesAsync(Request.ImagePath + "/CertificatesMainTemplates/logo_dark_ar.png");
                        string NotAuthenticatedHeaderImagebase64String = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes);

                        List<ArbitrationResult> ArbitrationResultEntitiesToUpdate = await _ArbitrationResultRepository
                            .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                            .ToListAsync();

                        if (Request.isCerticate == CertificationActionTypes.True)
                        {
                            ArbitrationResult? ArbitrationResultEntity = ArbitrationResultEntitiesToUpdate
                                .FirstOrDefault(x => x.ProvidedForm!.Category!.MinimumRequirementToObtainACertificate == null ||
                                    x.ProvidedForm!.Category!.MaximumRequirementToObtainACertificate == null);

                            if (ArbitrationResultEntity is not null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"This category: {ArbitrationResultEntity.ProvidedForm!.Category!.EnglishName} doesn't contain a certificate"
                                    : $"هذه الفئة {ArbitrationResultEntity.ProvidedForm!.Category!.ArabicName} لا تحتوي على شهادة";

                                return new BaseResponse<object>(ResponseMessage, true, 400);
                            }

                            if (Request.isCerticate == CertificationActionTypes.True)
                            {
                                Template? TemplateEntity = null;

                                if (Request.CerticateTemplateId is null)
                                    TemplateEntity = await _TemplateRepository
                                        .FirstOrDefaultAsync(x => x.TemplateType == TemplateTypes.CertificateOfParticipation &&
                                            x.isActive);
                                else
                                    TemplateEntity = await _TemplateRepository
                                        .FirstOrDefaultAsync(x => x.Id == Request.CerticateTemplateId);

                                if (TemplateEntity is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? "You must select a template for the certificates first"
                                        : "يجب عليك تحديد قالب للشهادات أولاً";

                                    return new BaseResponse<object>(ResponseMessage, true, 400);
                                }

                                List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                                    .Where(x => ArbitrationResultEntitiesToUpdate
                                        .Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                        x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                                        x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                                    .ToListAsync();

                                List<Domain.Entities.ProvidedFormModel.ProvidedForm> ArabicProvidedFormEntities = ArbitrationResultEntitiesToUpdate
                                    .Where(x => x.ProvidedForm!.Formlanguage == "ar")
                                    .Select(x => x.ProvidedForm!)
                                    .OrderByDescending(x => x.Id)
                                    .ToList();

                                List<string> ArabicHTMLContentForEachForm = new List<string>();
                                List<string> ArabicHTMLContentEvaluationFormForEachForm = new List<string>();
                                List<FilePathAndProvidedFormIdDto> ArabicDownloadedHTMLFilePaths = new List<FilePathAndProvidedFormIdDto>();
                                List<FilePathAndProvidedFormIdDto> ArabicEvaluationFormDownloadedHTMLFilePaths = new List<FilePathAndProvidedFormIdDto>();

                                string ArabicHtmlBody = Request.ImagePath + "/CertificatesMainTemplates/certificate-ar.html";
                                string ArabicEvaluationFormHtmlBody = Request.ImagePath + "/CertificatesMainTemplates/EvaluationForm-ar.html";

                                if (ArabicProvidedFormEntities.Any())
                                {
                                    string ArabicHTMLContent = await File.ReadAllTextAsync(ArabicHtmlBody);

                                    string ArabicEvaluationFormHTMLContent = await File.ReadAllTextAsync(ArabicEvaluationFormHtmlBody);

                                    // Generate DownloadedHTMLFileName as a List<string>
                                    List<string> ArabicDownloadedHTMLFileNames = ArabicProvidedFormEntities
                                        .Select(entity => "CertificateforFormId" + entity.Id + ".html")
                                        .ToList();
                                    List<string> ArabicEvaluationFormDownloadedHTMLFileNames = ArabicProvidedFormEntities
                                        .Select(entity => "EvaluationFormforFormId" + entity.Id + ".html")
                                        .ToList();

                                    // Generate DownloadedHTMLFilePath as a List<string>
                                    ArabicDownloadedHTMLFilePaths = ArabicProvidedFormEntities
                                        .Select(Entity => new FilePathAndProvidedFormIdDto()
                                        {
                                            FilePath = Request.ImagePath + "/SavedCertificates/ParticipationCertificates/CertificateforFormId" + Entity.Id + ".html",
                                            ProvidedFormId = Entity.Id,
                                            TemplateType = TemplateTypes.CertificateOfParticipation
                                        }).ToList();
                                    ArabicEvaluationFormDownloadedHTMLFilePaths = ArabicProvidedFormEntities
                                        .Select(Entity => new FilePathAndProvidedFormIdDto()
                                        {
                                            FilePath = Request.ImagePath + "/SavedCertificates/EvaluationFormCertificates/EvaluationFormforFormId" + Entity.Id + ".html",
                                            ProvidedFormId = Entity.Id,
                                            TemplateType = TemplateTypes.Evaluation_Form
                                        })
                                        .ToList();

                                    if (TemplateEntity.BackgroundImageColor is not null)
                                    {
                                        string[] HTMLContentCopy = ArabicHTMLContent.Split("<!-- Start Image -->");
                                        string[] HTMLContentEvaluationFormCopy = ArabicEvaluationFormHTMLContent.Split("<!-- Start Image -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[2]
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor);
                                        string HTMLContentEvaluationFormCopyForColor = HTMLContentEvaluationFormCopy[2]
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor);

                                        ArabicHTMLContent = HTMLContentCopy[0] + HTMLContentCopyForColor;
                                        ArabicEvaluationFormHTMLContent = HTMLContentEvaluationFormCopy[0] + HTMLContentEvaluationFormCopyForColor;
                                    }
                                    else if (TemplateEntity.BackgroundImageUrl is not null)
                                    {
                                        string[] HTMLContentCopy = ArabicHTMLContent.Split("<!-- Start Color -->");
                                        string[] HTMLContentEvaluationFormCopy = ArabicEvaluationFormHTMLContent.Split("<!-- Start Color -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[0]
                                            .Replace("###Color###", TemplateEntity.FontColor);
                                        string HTMLContentEvaluationFormCopyForColor = HTMLContentEvaluationFormCopy[0]
                                            .Replace("###Color###", TemplateEntity.FontColor);

                                        string FileNameForBackGroundImage = Path.GetFileName(TemplateEntity.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                        byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                        string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);
                                        
                                        ArabicHTMLContent = HTMLContentCopyForColor + HTMLContentCopy[2];
                                        ArabicEvaluationFormHTMLContent = HTMLContentEvaluationFormCopyForColor + HTMLContentEvaluationFormCopy[2];

                                        ArabicHTMLContent = ArabicHTMLContent
                                            .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                        ArabicEvaluationFormHTMLContent = ArabicEvaluationFormHTMLContent
                                            .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                    }
                                    else
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? "You must either select a background image or color first for the certificate's arabic template"
                                            : "يجب عليك تحديد صورة الخلفية أو اللون للنموذج باللغة العربية أولاً";

                                        return new BaseResponse<object>(ResponseMessage, true, 400);
                                    }

                                    string FileNameForDigitalSignature = Path.GetFileName(DigitalSignatureEntity!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                    byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                    string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                    ArabicHTMLContent = ArabicHTMLContent
                                        .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                        .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");
                                    
                                    ArabicEvaluationFormHTMLContent = ArabicEvaluationFormHTMLContent
                                        .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'");

                                    IEnumerable<DynamicAttributeValue> ArabicDynamicAttributeValueEntities = DynamicAttributeValueEntities
                                        .Where(x => ArabicProvidedFormEntities.Select(y => y.Id).Any(y => y == x.RecordId));

                                    CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                                    ArabicHTMLContentForEachForm = ArabicProvidedFormEntities
                                        .OrderByDescending(x => x.Id)
                                        .Select(Entity => ArabicHTMLContent
                                            .Replace("###SubscriberFullName###", ArabicDynamicAttributeValueEntities
                                                .FirstOrDefault(x => x.RecordId == Entity.Id)?.Value ?? null)
                                            .Replace("###SubCategoryName###", Entity.Category!.ArabicName)
                                            .Replace("###CycleNumber###", Entity.Category!.Cycle!.CycleNumber.ToString())
                                            .Replace("###CycleYear###", Entity.Category!.Cycle!.Year.ToString())
                                            .Replace("###FullName###", DigitalSignatureEntity.ArabicFullName)
                                            .Replace("###Occupation###", DigitalSignatureEntity.ArabicOccupation)
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor)
                                            .Replace("###Color###", TemplateEntity.FontColor)
                                            .Replace("###DateOfObtaining###", Request.DateOfObtainingTheCertificate != null
                                                ? Request.DateOfObtainingTheCertificate.Value.ToString("d/M/yyyy", ArabicCulture)
                                                : DateTime.UtcNow.ToString("d/M/yyyy", ArabicCulture))) // Event Date..
                                        .ToList();

                                    List<Criterion> AllCriterionsEntities = await _CriterionRepository
                                        .Where(x => ArabicProvidedFormEntities.Select(y => y.categoryId).Contains(x.CategoryId))
                                        .ToListAsync();

                                    List<Criterion> MainCriterionEntities = AllCriterionsEntities
                                        .Where(x => x.ParentId == null)
                                        .ToList();

                                    List<Criterion> SubCriterionEntities = AllCriterionsEntities
                                        .Where(x => x.ParentId != null)
                                        .ToList();

                                    List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                                        .Where(x => SubCriterionEntities.Select(y => y.Id).Contains(x.CriterionId))
                                        .ToListAsync();

                                    List<FinalArbitrationScore> AllFinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                                        .Where(x => SubCriterionEntities.Select(y => y.Id).Any(y => y == x.CriterionId) ||
                                            CriterionItemEntities.Select(y => y.Id).Any(y => y == x.CriterionItemId))
                                        .ToListAsync();

                                    string MainCriterionHTMLCode = ArabicEvaluationFormHTMLContent.Split("<!-- Start Main Criterion -->")[1];
                                    string SubCriterionHTMLCode = ArabicEvaluationFormHTMLContent.Split("<!-- Start Sub Criterion -->")[1];

                                    ArabicHTMLContentEvaluationFormForEachForm = ArabicProvidedFormEntities
                                        .OrderByDescending(x => x.Id)
                                        .Select(Entity => ArabicEvaluationFormHTMLContent
                                            .Replace("###SubscriberFullName###", ArabicDynamicAttributeValueEntities
                                                .FirstOrDefault(x => x.RecordId == Entity.Id)?.Value ?? null)
                                            .Replace("###SubCategoryName###", Entity.Category!.ArabicName)
                                            .Replace("###CycleNumber###", Entity.Category!.Cycle!.CycleNumber.ToString())
                                            .Replace("###CycleYear###", Entity.Category!.Cycle!.Year.ToString())
                                            .Replace("###FullName###", DigitalSignatureEntity.ArabicFullName)
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor)
                                            .Replace("###Occupation###", DigitalSignatureEntity.ArabicOccupation)
                                            .Replace("###Color###", TemplateEntity.FontColor)
                                            .Replace("###DateOfObtaining###", Request.DateOfObtainingTheCertificate != null
                                                ? Request.DateOfObtainingTheCertificate.Value.ToString("d/M/yyyy", ArabicCulture)
                                                : DateTime.UtcNow.ToString("d/M/yyyy", ArabicCulture)))
                                        .Select(ArabicEvaluationFormHTMLContentForEachFormCopy =>
                                        {
                                            string NewMainCriterions = string.Empty;

                                            List<Criterion> MainCriterionEntitiesForEachForm = MainCriterionEntities
                                                .Where(x => x.CategoryId == x.CategoryId)
                                                .ToList();

                                            foreach (Criterion MainCriterionEntityForEachForm in MainCriterionEntitiesForEachForm)
                                            {
                                                string CopyOfMainCriterionHTMLCode = MainCriterionHTMLCode;

                                                CopyOfMainCriterionHTMLCode = CopyOfMainCriterionHTMLCode
                                                    .Replace("###MainCriterionOrderId###", (MainCriterionEntitiesForEachForm.IndexOf(MainCriterionEntityForEachForm) + 1).ToString())
                                                    .Replace("###MainCriterionName###", MainCriterionEntityForEachForm.ArabicTitle);

                                                List<Criterion> SubCriterionEntitiesForEachForm = SubCriterionEntities
                                                    .Where(x => x.ParentId == MainCriterionEntityForEachForm.Id)
                                                    .ToList();

                                                string NewSubCriterions = string.Empty;

                                                foreach (Criterion SubCriterionEntityForEachForm in SubCriterionEntitiesForEachForm)
                                                {
                                                    string CopyOfSubCriterionHTMLCode = SubCriterionHTMLCode;

                                                    List<FinalArbitrationScore> FinalArbitrationScoreEntitiesForThisSubCriterion = AllFinalArbitrationScoreEntities
                                                        .Where(x => (x.CriterionId != null
                                                            ? SubCriterionEntityForEachForm.Id == x.CriterionId
                                                            : SubCriterionEntityForEachForm.Id == x.CriterionItem!.CriterionId))
                                                        .ToList();

                                                    CopyOfSubCriterionHTMLCode = CopyOfSubCriterionHTMLCode
                                                        .Replace("###MainCriterionOrderId###", (MainCriterionEntitiesForEachForm.IndexOf(MainCriterionEntityForEachForm) + 1).ToString())
                                                        .Replace("###SubCriterionOrderId###", (SubCriterionEntitiesForEachForm.IndexOf(SubCriterionEntityForEachForm) + 1).ToString())
                                                        .Replace("###SubCriterionName###", SubCriterionEntityForEachForm.ArabicTitle)
                                                        .Replace("###AreasOfStrength###", string.Join("<br/>", FinalArbitrationScoreEntitiesForThisSubCriterion
                                                            .Select(x => x.StrengthPoint)))
                                                        .Replace("###AreasOfImprovement###", string.Join("<br/>", FinalArbitrationScoreEntitiesForThisSubCriterion
                                                            .Select(x => x.ImprovementAreas)));

                                                    NewSubCriterions = NewSubCriterions + CopyOfSubCriterionHTMLCode;
                                                }

                                                string[] SpliterOfCopyOfMainCriterionHTMLCode = CopyOfMainCriterionHTMLCode
                                                    .Split("<!-- Start Sub Criterion -->");

                                                CopyOfMainCriterionHTMLCode = SpliterOfCopyOfMainCriterionHTMLCode[0] + NewSubCriterions + SpliterOfCopyOfMainCriterionHTMLCode[2];

                                                NewMainCriterions = NewMainCriterions + CopyOfMainCriterionHTMLCode;
                                            }

                                            string[] SpliterOfArabicEvaluationFormHTMLContentForEachFormCopy = ArabicEvaluationFormHTMLContentForEachFormCopy
                                                .Split("<!-- Start Main Criterion -->");

                                            ArabicEvaluationFormHTMLContentForEachFormCopy = SpliterOfArabicEvaluationFormHTMLContentForEachFormCopy[0] +
                                                NewMainCriterions +
                                                SpliterOfArabicEvaluationFormHTMLContentForEachFormCopy[2];

                                            return ArabicEvaluationFormHTMLContentForEachFormCopy;
                                        }).ToList();

                                    string NewDigitalSignatureEntityImageURL = DigitalSignatureEntity.ImageUrl
                                        .Split("\\").LastOrDefault()!.Split("/").LastOrDefault()!;
                                }

                                List<Domain.Entities.ProvidedFormModel.ProvidedForm> EnglishProvidedFormEntities = ArbitrationResultEntitiesToUpdate
                                    .Where(x => x.ProvidedForm!.Formlanguage == "en")
                                    .Select(x => x.ProvidedForm!)
                                    .OrderByDescending(x => x.Id)
                                    .ToList();

                                List<string> EnglishHTMLContentForEachForm = new List<string>();
                                List<string> EnglishEvaluationFormHTMLContentForEachForm = new List<string>();
                                List<FilePathAndProvidedFormIdDto> EnglishDownloadedHTMLFilePaths = new List<FilePathAndProvidedFormIdDto>();
                                List<FilePathAndProvidedFormIdDto> EnglishEvaluationFormDownloadedHTMLFilePaths = new List<FilePathAndProvidedFormIdDto>();
                                
                                string EnglishHtmlBody = Request.ImagePath + "/CertificatesMainTemplates/certificate-en.html";
                                string EnglishEvaluationFormHtmlBody = Request.ImagePath + "/CertificatesMainTemplates/EvaluationForm-en.html";

                                if (EnglishProvidedFormEntities.Any())
                                {
                                    string EnglishHTMLContent = await File.ReadAllTextAsync(EnglishHtmlBody);

                                    string EnglishEvaluationFormHTMLContent = await File.ReadAllTextAsync(EnglishEvaluationFormHtmlBody);

                                    // Generate DownloadedHTMLFileName as a List<string>
                                    List<string> EnglishDownloadedHTMLFileNames = EnglishProvidedFormEntities
                                        .Select(entity => "CertificateforFormId" + entity.Id + ".html")
                                        .ToList();
                                    List<string> EnglishEvaluationFormDownloadedHTMLFileNames = EnglishProvidedFormEntities
                                        .Select(entity => "EvaluationFormforFormId" + entity.Id + ".html")
                                        .ToList();

                                    // Generate DownloadedHTMLFilePath as a List<string>
                                    EnglishDownloadedHTMLFilePaths = EnglishProvidedFormEntities
                                        .Select(Entity => new FilePathAndProvidedFormIdDto()
                                        {
                                            FilePath = Request.ImagePath + "/SavedCertificates/ParticipationCertificates/CertificateforFormId" + Entity.Id + ".html",
                                            ProvidedFormId = Entity.Id,
                                            TemplateType = TemplateTypes.CertificateOfParticipation
                                        }).ToList();
                                    EnglishEvaluationFormDownloadedHTMLFilePaths = EnglishProvidedFormEntities
                                        .Select(Entity => new FilePathAndProvidedFormIdDto()
                                        {
                                            FilePath = Request.ImagePath + "/SavedCertificates/EvaluationFormCertificates/EvaluationFormforFormId" + Entity.Id + ".html",
                                            ProvidedFormId = Entity.Id,
                                            TemplateType = TemplateTypes.Evaluation_Form
                                        }).ToList();

                                    if (TemplateEntity.BackgroundImageColor is not null)
                                    {
                                        string[] HTMLContentCopy = EnglishHTMLContent.Split("<!-- Start Image -->");
                                        string[] HTMLEvaluationFormContentCopy = EnglishEvaluationFormHTMLContent.Split("<!-- Start Image -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[2]
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor);
                                        string HTMLEvaluationFormContentCopyForColor = HTMLEvaluationFormContentCopy[2]
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor);

                                        EnglishHTMLContent = HTMLContentCopy[0] + HTMLContentCopyForColor;
                                        EnglishEvaluationFormHTMLContent = HTMLEvaluationFormContentCopy[0] + HTMLEvaluationFormContentCopyForColor;
                                    }
                                    else if (TemplateEntity.BackgroundImageUrl is not null)
                                    {
                                        string[] HTMLContentCopy = EnglishHTMLContent.Split("<!-- Start Color -->");
                                        string[] HTMLEvaluationFormContentCopy = EnglishEvaluationFormHTMLContent.Split("<!-- Start Color -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[0]
                                            .Replace("###Color###", TemplateEntity.FontColor);
                                        string HTMLEvaluationFormContentCopyForColor = HTMLEvaluationFormContentCopy[0]
                                            .Replace("###Color###", TemplateEntity.FontColor);

                                        string FileNameForBackGroundImage = Path.GetFileName(TemplateEntity.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                        byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                        string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);
                                        
                                        EnglishHTMLContent = HTMLContentCopyForColor + HTMLContentCopy[2];
                                        EnglishEvaluationFormHTMLContent = HTMLEvaluationFormContentCopyForColor + HTMLEvaluationFormContentCopy[2];

                                        EnglishHTMLContent = EnglishHTMLContent
                                            .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                        EnglishEvaluationFormHTMLContent = EnglishEvaluationFormHTMLContent
                                            .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                    }
                                    else
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? "You must either select a background image or color first for the certificate's english template"
                                            : "يجب عليك تحديد صورة الخلفية أو اللون للنموذج باللغة الإنكليزية أولاً";

                                        return new BaseResponse<object>(ResponseMessage, true, 400);
                                    }

                                    string FileNameForDigitalSignature = Path.GetFileName(DigitalSignatureEntity!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                    byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                    string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                    EnglishHTMLContent = EnglishHTMLContent
                                        .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                        .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                    EnglishEvaluationFormHTMLContent = EnglishEvaluationFormHTMLContent
                                        .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'");

                                    IEnumerable<DynamicAttributeValue> EnglishDynamicAttributeValueEntities = DynamicAttributeValueEntities
                                        .Where(x => EnglishProvidedFormEntities.Select(y => y.Id).Any(y => y == x.RecordId));

                                    CultureInfo EnglishCulture = new CultureInfo("en-US");

                                    EnglishHTMLContentForEachForm = EnglishProvidedFormEntities
                                        .OrderByDescending(x => x.Id)
                                        .Select(Entity => EnglishHTMLContent
                                            .Replace("###SubscriberFullName###", EnglishDynamicAttributeValueEntities
                                                .FirstOrDefault(x => x.RecordId == Entity.Id)?.Value ?? null)
                                            .Replace("###SubCategoryName###", Entity.Category!.EnglishName)
                                            .Replace("###CycleNumber###", Entity.Category!.Cycle!.CycleNumber.ToString())
                                            .Replace("###CycleYear###", Entity.Category!.Cycle!.Year.ToString())
                                            .Replace("###FullName###", DigitalSignatureEntity.EnglishFullName)
                                            .Replace("###Occupation###", DigitalSignatureEntity.EnglishOccupation)
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor)
                                            .Replace("###Color###", TemplateEntity.FontColor)
                                            .Replace("###DateOfObtaining###", Request.DateOfObtainingTheCertificate != null
                                                ? Request.DateOfObtainingTheCertificate.Value.ToString("d/M/yyyy", EnglishCulture)
                                                : DateTime.UtcNow.ToString("d/M/yyyy", EnglishCulture))) // Event Date..
                                        .ToList();

                                    List<Criterion> AllCriterionsEntities = await _CriterionRepository
                                        .Where(x => EnglishProvidedFormEntities.Select(y => y.categoryId).Contains(x.CategoryId))
                                        .ToListAsync();

                                    List<Criterion> MainCriterionEntities = AllCriterionsEntities
                                        .Where(x => x.ParentId == null)
                                        .ToList();

                                    List<Criterion> SubCriterionEntities = AllCriterionsEntities
                                        .Where(x => x.ParentId != null)
                                        .ToList();

                                    List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                                        .Where(x => SubCriterionEntities.Select(y => y.Id).Contains(x.CriterionId))
                                        .ToListAsync();

                                    List<FinalArbitrationScore> AllFinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                                        .Where(x => SubCriterionEntities.Select(y => y.Id).Any(y => y == x.CriterionId) ||
                                            CriterionItemEntities.Select(y => y.Id).Any(y => y == x.CriterionItemId))
                                        .ToListAsync();

                                    string MainCriterionHTMLCode = EnglishEvaluationFormHTMLContent.Split("<!-- Start Main Criterion -->")[1];
                                    string SubCriterionHTMLCode = EnglishEvaluationFormHTMLContent.Split("<!-- Start Sub Criterion -->")[1];

                                    EnglishEvaluationFormHTMLContentForEachForm = EnglishProvidedFormEntities
                                        .OrderByDescending(x => x.Id)
                                        .Select(Entity => EnglishEvaluationFormHTMLContent
                                            .Replace("###SubscriberFullName###", EnglishDynamicAttributeValueEntities
                                                .FirstOrDefault(x => x.RecordId == Entity.Id)?.Value ?? null)
                                            .Replace("###SubCategoryName###", Entity.Category!.EnglishName)
                                            .Replace("###CycleNumber###", Entity.Category!.Cycle!.CycleNumber.ToString())
                                            .Replace("###CycleYear###", Entity.Category!.Cycle!.Year.ToString())
                                            .Replace("###FullName###", DigitalSignatureEntity.EnglishFullName)
                                            .Replace("###Occupation###", DigitalSignatureEntity.EnglishOccupation)
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor)
                                            .Replace("###Color###", TemplateEntity.FontColor)
                                            .Replace("###DateOfObtaining###", Request.DateOfObtainingTheCertificate != null
                                                ? Request.DateOfObtainingTheCertificate.Value.ToString("d/M/yyyy", EnglishCulture)
                                                : DateTime.UtcNow.ToString("d/M/yyyy", EnglishCulture)))
                                        .Select(EnglishEvaluationFormHTMLContentForEachFormCopy =>
                                        {
                                            string NewMainCriterions = string.Empty;

                                            List<Criterion> MainCriterionEntitiesForEachForm = MainCriterionEntities
                                                .Where(x => x.CategoryId == x.CategoryId)
                                                .ToList();

                                            foreach (Criterion MainCriterionEntityForEachForm in MainCriterionEntitiesForEachForm)
                                            {
                                                string CopyOfMainCriterionHTMLCode = MainCriterionHTMLCode;

                                                CopyOfMainCriterionHTMLCode = CopyOfMainCriterionHTMLCode
                                                    .Replace("###MainCriterionOrderId###", (MainCriterionEntitiesForEachForm.IndexOf(MainCriterionEntityForEachForm) + 1).ToString())
                                                    .Replace("###MainCriterionName###", MainCriterionEntityForEachForm.EnglishTitle);

                                                List<Criterion> SubCriterionEntitiesForEachForm = SubCriterionEntities
                                                    .Where(x => x.ParentId == MainCriterionEntityForEachForm.Id)
                                                    .ToList();

                                                string NewSubCriterions = string.Empty;

                                                foreach (Criterion SubCriterionEntityForEachForm in SubCriterionEntitiesForEachForm)
                                                {
                                                    string CopyOfSubCriterionHTMLCode = SubCriterionHTMLCode;

                                                    List<FinalArbitrationScore> FinalArbitrationScoreEntitiesForThisSubCriterion = AllFinalArbitrationScoreEntities
                                                        .Where(x => (x.CriterionId != null
                                                            ? SubCriterionEntityForEachForm.Id == x.CriterionId
                                                            : SubCriterionEntityForEachForm.Id == x.CriterionItem!.CriterionId))
                                                        .ToList();

                                                    CopyOfSubCriterionHTMLCode = CopyOfSubCriterionHTMLCode
                                                        .Replace("###MainCriterionOrderId###", (MainCriterionEntitiesForEachForm.IndexOf(MainCriterionEntityForEachForm) + 1).ToString())
                                                        .Replace("###SubCriterionOrderId###", (SubCriterionEntitiesForEachForm.IndexOf(SubCriterionEntityForEachForm) + 1).ToString())
                                                        .Replace("###SubCriterionName###", SubCriterionEntityForEachForm.EnglishTitle)
                                                        .Replace("###AreasOfStrength###", string.Join("<br/>", FinalArbitrationScoreEntitiesForThisSubCriterion
                                                            .Select(x => x.StrengthPoint)))
                                                        .Replace("###AreasOfImprovement###", string.Join("<br/>", FinalArbitrationScoreEntitiesForThisSubCriterion
                                                            .Select(x => x.ImprovementAreas)));

                                                    NewSubCriterions = NewSubCriterions + CopyOfSubCriterionHTMLCode;
                                                }

                                                string[] SpliterOfCopyOfMainCriterionHTMLCode = CopyOfMainCriterionHTMLCode
                                                    .Split("<!-- Start Sub Criterion -->");

                                                CopyOfMainCriterionHTMLCode = SpliterOfCopyOfMainCriterionHTMLCode[0] + NewSubCriterions + SpliterOfCopyOfMainCriterionHTMLCode[2];

                                                NewMainCriterions = NewMainCriterions + CopyOfMainCriterionHTMLCode;
                                            }

                                            string[] SpliterOfEnglishEvaluationFormHTMLContentForEachFormCopy = EnglishEvaluationFormHTMLContentForEachFormCopy
                                                .Split("<!-- Start Main Criterion -->");

                                            EnglishEvaluationFormHTMLContentForEachFormCopy = SpliterOfEnglishEvaluationFormHTMLContentForEachFormCopy[0] +
                                                NewMainCriterions +
                                                SpliterOfEnglishEvaluationFormHTMLContentForEachFormCopy[2];

                                            return EnglishEvaluationFormHTMLContentForEachFormCopy;
                                        }).ToList();

                                    string NewDigitalSignatureEntityImageURL = DigitalSignatureEntity.ImageUrl
                                        .Split("\\").LastOrDefault()!.Split("/").LastOrDefault()!;
                                }

                                await _ArbitrationResultRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.GotCertification, true)
                                        .SetProperty(x => x.DateOfObtainingTheCertificate, Request.DateOfObtainingTheCertificate != null
                                            ? Request.DateOfObtainingTheCertificate.Value
                                            : DateTime.UtcNow));

                                IEnumerable<FilePathAndProvidedFormIdDto> DownloadedHTMLFilePaths = ArabicDownloadedHTMLFilePaths
                                    .Concat(ArabicEvaluationFormDownloadedHTMLFilePaths)
                                    .Concat(EnglishDownloadedHTMLFilePaths)
                                    .Concat(EnglishEvaluationFormDownloadedHTMLFilePaths);

                                List<int> AlreadyExistSavedCertificateEntities = new List<int>();

                                if (DownloadedHTMLFilePaths.Any())
                                {
                                    List<int> ProvidedFormIdsInDownloadedHTMLFilePaths = DownloadedHTMLFilePaths
                                        .Select(x => x.ProvidedFormId).ToList();

                                    AlreadyExistSavedCertificateEntities = await _SavedCertificateRepository
                                        .Where(x => ProvidedFormIdsInDownloadedHTMLFilePaths.Contains(x.ProvidedFormId) &&
                                            (x.TemplateType == TemplateTypes.CertificateOfParticipation ||
                                            x.TemplateType == TemplateTypes.Evaluation_Form))
                                        .Select(x => x.ProvidedFormId)
                                        .ToListAsync();

                                    IEnumerable<SavedCertificate> NewSavedCertificateEntities = DownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => new SavedCertificate()
                                        {
                                            FilePath = x.FilePath,
                                            TemplateType = x.TemplateType,
                                            ProvidedFormId = x.ProvidedFormId,
                                            TemplateId = TemplateEntity.Id,
                                            DigitalSignatureId = Request.DigitalSignatureId!.Value
                                        });

                                    await _SavedCertificateRepository.AddRangeAsync(NewSavedCertificateEntities);
                                }

                                if (ArabicDownloadedHTMLFilePaths.Any())
                                {
                                    List<string> CopyArabicDownloadedHTMLFilePaths = ArabicDownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => x.FilePath)
                                        .ToList();

                                    foreach (string DownloadedHTMLFilePath in CopyArabicDownloadedHTMLFilePaths)
                                    {
                                        string ContentToSave = ArabicHTMLContentForEachForm[CopyArabicDownloadedHTMLFilePaths.IndexOf(DownloadedHTMLFilePath)];

                                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ContentToSave, System.Text.Encoding.UTF8);
                                    }
                                }

                                if (ArabicEvaluationFormDownloadedHTMLFilePaths.Any())
                                {
                                    List<string> CopyArabicEvaluationFormDownloadedHTMLFilePaths = ArabicEvaluationFormDownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => x.FilePath)
                                        .ToList();

                                    foreach (string DownloadedHTMLFilePath in CopyArabicEvaluationFormDownloadedHTMLFilePaths)
                                    {
                                        string ContentToSave = ArabicHTMLContentEvaluationFormForEachForm[CopyArabicEvaluationFormDownloadedHTMLFilePaths.IndexOf(DownloadedHTMLFilePath)];

                                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ContentToSave, System.Text.Encoding.UTF8);
                                    }
                                }

                                if (EnglishDownloadedHTMLFilePaths.Any())
                                {
                                    List<string> CopyEnglishDownloadedHTMLFilePaths = EnglishDownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => x.FilePath)
                                        .ToList();

                                    foreach (string DownloadedHTMLFilePath in CopyEnglishDownloadedHTMLFilePaths)
                                    {
                                        string ContentToSave = EnglishHTMLContentForEachForm[CopyEnglishDownloadedHTMLFilePaths.IndexOf(DownloadedHTMLFilePath)];
                                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ContentToSave, System.Text.Encoding.UTF8);
                                    }
                                }

                                if (EnglishEvaluationFormDownloadedHTMLFilePaths.Any())
                                {
                                    List<string> CopyEnglishEvaluationFormDownloadedHTMLFilePaths = EnglishEvaluationFormDownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => x.FilePath)
                                        .ToList();

                                    foreach (string DownloadedHTMLFilePath in CopyEnglishEvaluationFormDownloadedHTMLFilePaths)
                                    {
                                        string ContentToSave = EnglishEvaluationFormHTMLContentForEachForm[CopyEnglishEvaluationFormDownloadedHTMLFilePaths.IndexOf(DownloadedHTMLFilePath)];
                                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ContentToSave, System.Text.Encoding.UTF8);
                                    }
                                }
                            }
                            else if (Request.isCerticate == CertificationActionTypes.False)
                            {
                                await _ArbitrationResultRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.GotCertification, false)
                                        .SetProperty(y => y.DateOfObtainingTheCertificate, y => null));

                                List<SavedCertificate> SavedCertificatesEntitiesToDelete = await _SavedCertificateRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                                        (x.TemplateType == TemplateTypes.CertificateOfParticipation ||
                                        x.TemplateType == TemplateTypes.Evaluation_Form))
                                    .ToListAsync();

                                foreach (SavedCertificate SavedCertificateToDelete in SavedCertificatesEntitiesToDelete)
                                {
                                    File.Delete(SavedCertificateToDelete.FilePath);
                                }

                                await _SavedCertificateRepository.DeleteListAsync(SavedCertificatesEntitiesToDelete);
                            }
                        }

                        if (Request.isStatment1 == CertificationActionTypes.True)
                        {
                            TemplateTypes TemplateType = TemplateTypes.Testimonial_Version_1;

                            ArbitrationResult? ArbitrationResultEntity = ArbitrationResultEntitiesToUpdate
                                .FirstOrDefault(x => !x.ProvidedForm!.Category!.ContainStatment1);

                            if (ArbitrationResultEntity is not null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"This category: {ArbitrationResultEntity.ProvidedForm!.Category!.EnglishName} doesn't contain a statment"
                                    : $"هذه الفئة {ArbitrationResultEntity.ProvidedForm!.Category!.ArabicName} لا تحتوي على إفادة";

                                return new BaseResponse<object>(ResponseMessage, true, 400);
                            }

                            if (Request.isStatment1 == CertificationActionTypes.True)
                            {
                                Template? TemplateEntity = null;

                                if (Request.Statment1TemplateId is null)
                                    TemplateEntity = await _TemplateRepository
                                        .FirstOrDefaultAsync(x => x.TemplateType == TemplateTypes.Testimonial_Version_1 &&
                                            x.isActive);

                                else
                                    TemplateEntity = await _TemplateRepository
                                        .FirstOrDefaultAsync(x => x.Id == Request.Statment1TemplateId);

                                if (TemplateEntity is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? "You must select a template for the statments first"
                                        : "يجب عليك تحديد قالب للإفادات 1 أولاً";

                                    return new BaseResponse<object>(ResponseMessage, true, 400);
                                }

                                List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                                    .Where(x => ArbitrationResultEntitiesToUpdate
                                        .Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                        x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                                        x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                                    .ToListAsync();

                                List<Domain.Entities.ProvidedFormModel.ProvidedForm> ArabicProvidedFormEntities = ArbitrationResultEntitiesToUpdate
                                    .Where(x => x.ProvidedForm!.Formlanguage == "ar")
                                    .Select(x => x.ProvidedForm!)
                                    .OrderByDescending(x => x.Id)
                                    .ToList();

                                List<string> ArabicHTMLContentForEachForm = new List<string>();
                                List<FilePathAndProvidedFormIdDto> ArabicDownloadedHTMLFilePaths = new List<FilePathAndProvidedFormIdDto>();

                                string ArabicHtmlBody = Request.ImagePath + "/CertificatesMainTemplates/Statement-ar-1.html";

                                if (ArabicProvidedFormEntities.Any())
                                {
                                    string ArabicHTMLContent = await File.ReadAllTextAsync(ArabicHtmlBody);

                                    // Generate DownloadedHTMLFileName as a List<string>
                                    List<string> ArabicDownloadedHTMLFileNames = ArabicProvidedFormEntities
                                        .Select(entity => "Statment1forFormId" + entity.Id + ".html")
                                        .ToList();

                                    // Generate DownloadedHTMLFilePath as a List<string>
                                    ArabicDownloadedHTMLFilePaths = ArabicProvidedFormEntities
                                        .Select(Entity => new FilePathAndProvidedFormIdDto()
                                        {
                                            FilePath = Request.ImagePath + "/SavedCertificates/Statment1Certificates/Statment1forFormId" + Entity.Id + ".html",
                                            ProvidedFormId = Entity.Id
                                        })
                                        .ToList();

                                    if (TemplateEntity.BackgroundImageColor is not null)
                                    {
                                        string[] HTMLContentCopy = ArabicHTMLContent.Split("<!-- Start Image -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[2]
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor);

                                        ArabicHTMLContent = HTMLContentCopy[0] + HTMLContentCopyForColor;
                                    }
                                    else if (TemplateEntity.BackgroundImageUrl is not null)
                                    {
                                        string[] HTMLContentCopy = ArabicHTMLContent.Split("<!-- Start Color -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[0]
                                            .Replace("###Color###", TemplateEntity.FontColor);

                                        string FileNameForBackGroundImage = Path.GetFileName(TemplateEntity.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                        byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                        string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);

                                        ArabicHTMLContent = HTMLContentCopyForColor + HTMLContentCopy[2];

                                        ArabicHTMLContent = ArabicHTMLContent
                                            .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                    }
                                    else
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? "You must either select a background image or color first for the certificate's arabic template"
                                            : "يجب عليك تحديد صورة الخلفية أو اللون للنموذج باللغة العربية أولاً";

                                        return new BaseResponse<object>(ResponseMessage, true, 400);
                                    }

                                    string FileNameForDigitalSignature = Path.GetFileName(DigitalSignatureEntity!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                    byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                    string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                    ArabicHTMLContent = ArabicHTMLContent
                                        .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                        .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                    IEnumerable<DynamicAttributeValue> ArabicDynamicAttributeValueEntities = DynamicAttributeValueEntities
                                        .Where(x => ArabicProvidedFormEntities.Select(y => y.Id).Any(y => y == x.RecordId));

                                    CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                                    ArabicHTMLContentForEachForm = ArabicProvidedFormEntities
                                        .OrderByDescending(x => x.Id)
                                        .Select(Entity => ArabicHTMLContent
                                            .Replace("###FullName###", DigitalSignatureEntity.ArabicFullName)
                                            .Replace("###Occupation###", DigitalSignatureEntity.ArabicOccupation)
                                            .Replace("###SubscriberFullName###", ArabicDynamicAttributeValueEntities
                                                .FirstOrDefault(x => x.RecordId == Entity.Id)?.Value ?? null)
                                            .Replace("###CycleNumber###", Entity.Category!.Cycle!.CycleNumber.ToString())
                                            .Replace("###CycleYear###", Entity.Category!.Cycle!.Year.ToString())
                                            .Replace("###SubCategoryName###", Entity.Category!.ArabicName)
                                            .Replace("###Color###", TemplateEntity.FontColor)
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor)
                                            .Replace("###DateOfObtaining###", Request.DateOfObtainingTheCertificate != null
                                                ? Request.DateOfObtainingTheCertificate.Value.ToString("d/M/yyyy", ArabicCulture)
                                                : DateTime.UtcNow.ToString("d/M/yyyy", ArabicCulture)))
                                        .ToList();

                                    string NewDigitalSignatureEntityImageURL = DigitalSignatureEntity.ImageUrl
                                        .Split("\\").LastOrDefault()!.Split("/").LastOrDefault()!;
                                }

                                List<Domain.Entities.ProvidedFormModel.ProvidedForm> EnglishProvidedFormEntities = ArbitrationResultEntitiesToUpdate
                                    .Where(x => x.ProvidedForm!.Formlanguage == "en")
                                    .Select(x => x.ProvidedForm!)
                                    .OrderByDescending(x => x.Id)
                                    .ToList();

                                List<string> EnglishHTMLContentForEachForm = new List<string>();
                                List<FilePathAndProvidedFormIdDto> EnglishDownloadedHTMLFilePaths = new List<FilePathAndProvidedFormIdDto>();

                                if (EnglishProvidedFormEntities.Any())
                                {
                                    string EnglishHtmlBody = Request.ImagePath + "/CertificatesMainTemplates/Statement-en-1.html";

                                    string EnglishHTMLContent = await File.ReadAllTextAsync(EnglishHtmlBody);

                                    // Generate DownloadedHTMLFileName as a List<string>
                                    List<string> EnglishDownloadedHTMLFileNames = EnglishProvidedFormEntities
                                        .Select(entity => "Statment1forFormId" + entity.Id + ".html")
                                        .ToList();

                                    // Generate DownloadedHTMLFilePath as a List<string>
                                    EnglishDownloadedHTMLFilePaths = EnglishProvidedFormEntities
                                        .Select(Entity => new FilePathAndProvidedFormIdDto()
                                        {
                                            FilePath = Request.ImagePath + "/SavedCertificates/Statment1Certificates/Statment1forFormId" + Entity.Id + ".html",
                                            ProvidedFormId = Entity.Id
                                        }).ToList();

                                    if (TemplateEntity.BackgroundImageColor is not null)
                                    {
                                        string[] HTMLContentCopy = EnglishHTMLContent.Split("<!-- Start Image -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[2]
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor);

                                        EnglishHTMLContent = HTMLContentCopy[0] + HTMLContentCopyForColor;
                                    }
                                    else if (TemplateEntity.BackgroundImageUrl is not null)
                                    {
                                        string[] HTMLContentCopy = EnglishHTMLContent.Split("<!-- Start Color -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[0]
                                            .Replace("###Color###", TemplateEntity.FontColor);

                                        string FileNameForBackGroundImage = Path.GetFileName(TemplateEntity.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                        byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                        string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);
                                        
                                        EnglishHTMLContent = HTMLContentCopyForColor + HTMLContentCopy[2];

                                        EnglishHTMLContent = EnglishHTMLContent
                                            .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                    }
                                    else
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? "You must either select a background image or color first for the certificate's english template"
                                            : "يجب عليك تحديد صورة الخلفية أو اللون للنموذج باللغة الإنكليزية أولاً";

                                        return new BaseResponse<object>(ResponseMessage, true, 400);
                                    }

                                    string FileNameForDigitalSignature = Path.GetFileName(DigitalSignatureEntity!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                    byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                    string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                    EnglishHTMLContent = EnglishHTMLContent
                                        .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                        .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                    IEnumerable<DynamicAttributeValue> EnglishDynamicAttributeValueEntities = DynamicAttributeValueEntities
                                        .Where(x => EnglishProvidedFormEntities.Select(y => y.Id).Any(y => y == x.RecordId));

                                    CultureInfo EnglishCulture = new CultureInfo("en-US");

                                    EnglishHTMLContentForEachForm = EnglishProvidedFormEntities
                                        .OrderByDescending(x => x.Id)
                                        .Select(Entity => EnglishHTMLContent
                                            .Replace("###FullName###", DigitalSignatureEntity.EnglishFullName)
                                            .Replace("###Occupation###", DigitalSignatureEntity.EnglishOccupation)
                                            .Replace("###SubscriberFullName###", EnglishDynamicAttributeValueEntities
                                                .FirstOrDefault(x => x.RecordId == Entity.Id)?.Value ?? null)
                                            .Replace("###CycleNumber###", Entity.Category!.Cycle!.CycleNumber.ToString())
                                            .Replace("###CycleYear###", Entity.Category!.Cycle!.Year.ToString())
                                            .Replace("###SubCategoryName###", Entity.Category!.EnglishName)
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor)
                                            .Replace("###Color###", TemplateEntity.FontColor)
                                            .Replace("###DateOfObtaining###", Request.DateOfObtainingTheCertificate != null
                                                ? Request.DateOfObtainingTheCertificate.Value.ToString("d/M/yyyy", EnglishCulture)
                                                : DateTime.UtcNow.ToString("d/M/yyyy", EnglishCulture)))
                                        .ToList();
                                }

                                await _ArbitrationResultRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.GotStatement1, true)
                                        .SetProperty(x => x.DateOfObtainingTheStatement1, Request.DateOfObtainingTheStatement1 != null
                                            ? Request.DateOfObtainingTheStatement1.Value
                                            : DateTime.UtcNow));

                                IEnumerable<FilePathAndProvidedFormIdDto> DownloadedHTMLFilePaths = ArabicDownloadedHTMLFilePaths
                                    .Concat(EnglishDownloadedHTMLFilePaths);

                                List<int> AlreadyExistSavedCertificateEntities = new List<int>();

                                if (DownloadedHTMLFilePaths.Any())
                                {
                                    List<int> ProvidedFormIdsInDownloadedHTMLFilePaths = DownloadedHTMLFilePaths
                                        .Select(x => x.ProvidedFormId).ToList();

                                    AlreadyExistSavedCertificateEntities = await _SavedCertificateRepository
                                        .Where(x => ProvidedFormIdsInDownloadedHTMLFilePaths.Contains(x.ProvidedFormId) &&
                                            x.TemplateType == TemplateTypes.Testimonial_Version_1)
                                        .Select(x => x.ProvidedFormId)
                                        .ToListAsync();

                                    IEnumerable<SavedCertificate> NewSavedCertificateEntities = DownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => new SavedCertificate()
                                        {
                                            FilePath = x.FilePath,
                                            TemplateType = TemplateType,
                                            ProvidedFormId = x.ProvidedFormId,
                                            TemplateId = TemplateEntity.Id,
                                            DigitalSignatureId = Request.DigitalSignatureId!.Value
                                        });

                                    await _SavedCertificateRepository.AddRangeAsync(NewSavedCertificateEntities);
                                }

                                if (ArabicDownloadedHTMLFilePaths.Any())
                                {
                                    List<string> CopyArabicDownloadedHTMLFilePaths = ArabicDownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => x.FilePath)
                                        .ToList();

                                    foreach (string DownloadedHTMLFilePath in CopyArabicDownloadedHTMLFilePaths)
                                    {
                                        string ContentToSave = ArabicHTMLContentForEachForm[CopyArabicDownloadedHTMLFilePaths.IndexOf(DownloadedHTMLFilePath)];
                                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ContentToSave, System.Text.Encoding.UTF8);
                                    }
                                }

                                if (EnglishDownloadedHTMLFilePaths.Any())
                                {
                                    List<string> CopyEnglishDownloadedHTMLFilePaths = EnglishDownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => x.FilePath)
                                        .ToList();

                                    foreach (string DownloadedHTMLFilePath in CopyEnglishDownloadedHTMLFilePaths)
                                    {
                                        string ContentToSave = EnglishHTMLContentForEachForm[CopyEnglishDownloadedHTMLFilePaths.IndexOf(DownloadedHTMLFilePath)];
                                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ContentToSave, System.Text.Encoding.UTF8);
                                    }
                                }
                            }
                            else
                            {
                                await _ArbitrationResultRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.GotStatement1, false)
                                        .SetProperty(y => y.DateOfObtainingTheStatement1, y => null));

                                List<SavedCertificate> SavedCertificatesEntitiesToDelete = await _SavedCertificateRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                                        x.TemplateType == TemplateTypes.Testimonial_Version_1)
                                    .ToListAsync();

                                foreach (SavedCertificate SavedCertificateToDelete in SavedCertificatesEntitiesToDelete)
                                {
                                    File.Delete(SavedCertificateToDelete.FilePath);
                                }

                                await _SavedCertificateRepository.DeleteListAsync(SavedCertificatesEntitiesToDelete);
                            }
                        }

                        if (Request.isStatment2 == CertificationActionTypes.True)
                        {
                            TemplateTypes TemplateType = TemplateTypes.Testimonial_Version_2;

                            ArbitrationResult? ArbitrationResultEntity = ArbitrationResultEntitiesToUpdate
                                .FirstOrDefault(x => x.ProvidedForm!.Category!.MinimumAmountToObtainAStatement2 == null ||
                                    x.ProvidedForm!.Category!.MaximumAmountToObtainAStatement2 == null);

                            if (ArbitrationResultEntity is not null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"This category: {ArbitrationResultEntity.ProvidedForm!.Category!.EnglishName} doesn't contain a statment"
                                    : $"هذه الفئة {ArbitrationResultEntity.ProvidedForm!.Category!.ArabicName} لا تحتوي على إفادة";

                                return new BaseResponse<object>(ResponseMessage, true, 400);
                            }

                            if (Request.isStatment2 == CertificationActionTypes.True)
                            {
                                Template? TemplateEntity = null;

                                if (Request.Statment2TemplateId is null)
                                    TemplateEntity = await _TemplateRepository
                                        .FirstOrDefaultAsync(x => x.TemplateType == TemplateTypes.Testimonial_Version_2 &&
                                            x.isActive);

                                else
                                    TemplateEntity = await _TemplateRepository
                                        .FirstOrDefaultAsync(x => x.Id == Request.Statment2TemplateId);

                                if (TemplateEntity is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? "You must select a template for the statments first"
                                        : "يجب عليك تحديد قالب للإفادات 2 أولاً";

                                    return new BaseResponse<object>(ResponseMessage, true, 400);
                                }

                                List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                                    .Where(x => ArbitrationResultEntitiesToUpdate
                                        .Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                        x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                                        x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                                    .ToListAsync();

                                List<Domain.Entities.ProvidedFormModel.ProvidedForm> ArabicProvidedFormEntities = ArbitrationResultEntitiesToUpdate
                                    .Where(x => x.ProvidedForm!.Formlanguage == "ar")
                                    .Select(x => x.ProvidedForm!)
                                    .OrderByDescending(x => x.Id)
                                    .ToList();

                                List<string> ArabicHTMLContentForEachForm = new List<string>();
                                List<FilePathAndProvidedFormIdDto> ArabicDownloadedHTMLFilePaths = new List<FilePathAndProvidedFormIdDto>();

                                if (ArabicProvidedFormEntities.Any())
                                {
                                    string ArabicHtmlBody = Request.ImagePath + "/CertificatesMainTemplates/Statement-ar-2.html";

                                    string ArabicHTMLContent = await File.ReadAllTextAsync(ArabicHtmlBody);

                                    // Generate DownloadedHTMLFileName as a List<string>
                                    List<string> ArabicDownloadedHTMLFileNames = ArabicProvidedFormEntities
                                        .Select(entity => "Statment2forFormId" + entity.Id + ".html")
                                        .ToList();

                                    // Generate DownloadedHTMLFilePath as a List<string>
                                    ArabicDownloadedHTMLFilePaths = ArabicProvidedFormEntities
                                        .Select(Entity => new FilePathAndProvidedFormIdDto()
                                        {
                                            FilePath = Request.ImagePath + "/SavedCertificates/Statment2Certificates/Statment2forFormId" + Entity.Id + ".html",
                                            ProvidedFormId = Entity.Id
                                        }).ToList();

                                    if (TemplateEntity.BackgroundImageColor is not null)
                                    {
                                        string[] HTMLContentCopy = ArabicHTMLContent.Split("<!-- Start Image -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[2]
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor);

                                        ArabicHTMLContent = HTMLContentCopy[0] + HTMLContentCopyForColor;
                                    }
                                    else if (TemplateEntity.BackgroundImageUrl is not null)
                                    {
                                        string[] HTMLContentCopy = ArabicHTMLContent.Split("<!-- Start Color -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[0]
                                            .Replace("###Color###", TemplateEntity.FontColor);

                                        string FileNameForBackGroundImage = Path.GetFileName(TemplateEntity.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                        byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                        string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);
                                        
                                        ArabicHTMLContent = HTMLContentCopyForColor + HTMLContentCopy[2];

                                        ArabicHTMLContent = ArabicHTMLContent
                                            .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                    }
                                    else
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? "You must either select a background image or color first for the certificate's arabic template"
                                            : "يجب عليك تحديد صورة الخلفية أو اللون للنموذج باللغة العربية أولاً";

                                        return new BaseResponse<object>(ResponseMessage, true, 400);
                                    }

                                    string FileNameForDigitalSignature = Path.GetFileName(DigitalSignatureEntity!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                    byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                    string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                    ArabicHTMLContent = ArabicHTMLContent
                                        .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                        .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                    IEnumerable<DynamicAttributeValue> ArabicDynamicAttributeValueEntities = DynamicAttributeValueEntities
                                        .Where(x => ArabicProvidedFormEntities.Select(y => y.Id).Any(y => y == x.RecordId));

                                    CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                                    ArabicHTMLContentForEachForm = ArabicProvidedFormEntities
                                        .OrderByDescending(x => x.Id)
                                        .Select(Entity => ArabicHTMLContent
                                            .Replace("###FullName###", DigitalSignatureEntity.ArabicFullName)
                                            .Replace("###Occupation###", DigitalSignatureEntity.ArabicOccupation)
                                            .Replace("###SubscriberFullName###", ArabicDynamicAttributeValueEntities
                                                .FirstOrDefault(x => x.RecordId == Entity.Id)?.Value ?? null)
                                            .Replace("###CycleNumber###", Entity.Category!.Cycle!.CycleNumber.ToString())
                                            .Replace("###CycleYear###", Entity.Category!.Cycle!.Year.ToString())
                                            .Replace("###SubCategoryName###", Entity.Category!.ArabicName)
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor)
                                            .Replace("###Color###", TemplateEntity.FontColor)
                                            .Replace("###DateOfObtaining###", Request.DateOfObtainingTheCertificate != null
                                                ? Request.DateOfObtainingTheCertificate.Value.ToString("d/M/yyyy", ArabicCulture)
                                                : DateTime.UtcNow.ToString("d/M/yyyy", ArabicCulture)))
                                        .ToList();
                                }

                                List<Domain.Entities.ProvidedFormModel.ProvidedForm> EnglishProvidedFormEntities = ArbitrationResultEntitiesToUpdate
                                    .Where(x => x.ProvidedForm!.Formlanguage == "en")
                                    .Select(x => x.ProvidedForm!)
                                    .OrderByDescending(x => x.Id)
                                    .ToList();

                                List<string> EnglishHTMLContentForEachForm = new List<string>();
                                List<FilePathAndProvidedFormIdDto> EnglishDownloadedHTMLFilePaths = new List<FilePathAndProvidedFormIdDto>();

                                if (EnglishProvidedFormEntities.Any())
                                {
                                    string EnglishHtmlBody = Request.ImagePath + "/CertificatesMainTemplates/Statement-en-2.html";

                                    string EnglishHTMLContent = await File.ReadAllTextAsync(EnglishHtmlBody);

                                    // Generate DownloadedHTMLFileName as a List<string>
                                    List<string> EnglishDownloadedHTMLFileNames = EnglishProvidedFormEntities
                                        .Select(entity => "Statment2forFormId" + entity.Id + ".html")
                                        .ToList();

                                    // Generate DownloadedHTMLFilePath as a List<string>
                                    EnglishDownloadedHTMLFilePaths = EnglishProvidedFormEntities
                                        .Select(Entity => new FilePathAndProvidedFormIdDto()
                                        {
                                            FilePath = Request.ImagePath + "/SavedCertificates/Statment2Certificates/Statment2forFormId" + Entity.Id + ".html",
                                            ProvidedFormId = Entity.Id
                                        }).ToList();

                                    if (TemplateEntity.BackgroundImageColor is not null)
                                    {
                                        string[] HTMLContentCopy = EnglishHTMLContent.Split("<!-- Start Image -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[2]
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor);

                                        EnglishHTMLContent = HTMLContentCopy[0] + HTMLContentCopyForColor;
                                    }
                                    else if (TemplateEntity.BackgroundImageUrl is not null)
                                    {
                                        string[] HTMLContentCopy = EnglishHTMLContent.Split("<!-- Start Color -->");

                                        string HTMLContentCopyForColor = HTMLContentCopy[0]
                                            .Replace("###Color###", TemplateEntity.FontColor);

                                        string FileNameForBackGroundImage = Path.GetFileName(TemplateEntity.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                        byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                        string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);
                                        
                                        EnglishHTMLContent = HTMLContentCopyForColor + HTMLContentCopy[2];

                                        EnglishHTMLContent = EnglishHTMLContent
                                            .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                    }
                                    else
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? "You must either select a background image or color first for the certificate's english template"
                                            : "يجب عليك تحديد صورة الخلفية أو اللون للنموذج باللغة الإنكليزية أولاً";

                                        return new BaseResponse<object>(ResponseMessage, true, 400);
                                    }

                                    string FileNameForDigitalSignature = Path.GetFileName(DigitalSignatureEntity!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                    byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                    string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                    EnglishHTMLContent = EnglishHTMLContent
                                        .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                        .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                    IEnumerable<DynamicAttributeValue> EnglishDynamicAttributeValueEntities = DynamicAttributeValueEntities
                                        .Where(x => EnglishProvidedFormEntities.Select(y => y.Id).Any(y => y == x.RecordId));

                                    CultureInfo EnglishCulture = new CultureInfo("en-US");

                                    EnglishHTMLContentForEachForm = EnglishProvidedFormEntities
                                        .OrderByDescending(x => x.Id)
                                        .Select(Entity => EnglishHTMLContent
                                            .Replace("###FullName###", DigitalSignatureEntity.EnglishFullName)
                                            .Replace("###Occupation###", DigitalSignatureEntity.EnglishOccupation)
                                            .Replace("###SubscriberFullName###", EnglishDynamicAttributeValueEntities
                                                .FirstOrDefault(x => x.RecordId == Entity.Id)?.Value ?? null)
                                            .Replace("###CycleNumber###", Entity.Category!.Cycle!.CycleNumber.ToString())
                                            .Replace("###CycleYear###", Entity.Category!.Cycle!.Year.ToString())
                                            .Replace("###SubCategoryName###", Entity.Category!.EnglishName)
                                            .Replace("###BackgroundColor###", TemplateEntity.BackgroundImageColor)
                                            .Replace("###Color###", TemplateEntity.FontColor)
                                            .Replace("###DateOfObtaining###", Request.DateOfObtainingTheCertificate != null
                                                ? Request.DateOfObtainingTheCertificate.Value.ToString("d/M/yyyy", EnglishCulture)
                                                : DateTime.UtcNow.ToString("d/M/yyyy", EnglishCulture)))
                                        .ToList();
                                }

                                await _ArbitrationResultRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.GotStatement2, true)
                                        .SetProperty(x => x.DateOfObtainingTheStatement2, Request.DateOfObtainingTheStatement2 != null
                                            ? Request.DateOfObtainingTheStatement2.Value
                                            : DateTime.UtcNow));

                                IEnumerable<FilePathAndProvidedFormIdDto> DownloadedHTMLFilePaths = ArabicDownloadedHTMLFilePaths
                                    .Concat(EnglishDownloadedHTMLFilePaths);

                                List<int> AlreadyExistSavedCertificateEntities = new List<int>();

                                if (DownloadedHTMLFilePaths.Any())
                                {
                                    List<int> ProvidedFormIdsInDownloadedHTMLFilePaths = DownloadedHTMLFilePaths
                                        .Select(x => x.ProvidedFormId).ToList();

                                    AlreadyExistSavedCertificateEntities = await _SavedCertificateRepository
                                        .Where(x => ProvidedFormIdsInDownloadedHTMLFilePaths.Contains(x.ProvidedFormId) &&
                                            x.TemplateType == TemplateTypes.Testimonial_Version_2)
                                        .Select(x => x.ProvidedFormId)
                                        .ToListAsync();

                                    IEnumerable<SavedCertificate> NewSavedCertificateEntities = DownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => new SavedCertificate()
                                        {
                                            FilePath = x.FilePath,
                                            TemplateType = TemplateType,
                                            ProvidedFormId = x.ProvidedFormId,
                                            TemplateId = TemplateEntity.Id,
                                            DigitalSignatureId = Request.DigitalSignatureId!.Value
                                        });

                                    await _SavedCertificateRepository.AddRangeAsync(NewSavedCertificateEntities);
                                }

                                if (ArabicDownloadedHTMLFilePaths.Any())
                                {
                                    List<string> CopyArabicDownloadedHTMLFilePaths = ArabicDownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => x.FilePath)
                                        .ToList();

                                    foreach (string DownloadedHTMLFilePath in CopyArabicDownloadedHTMLFilePaths)
                                    {
                                        string ContentToSave = ArabicHTMLContentForEachForm[CopyArabicDownloadedHTMLFilePaths.IndexOf(DownloadedHTMLFilePath)];
                                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ContentToSave, System.Text.Encoding.UTF8);
                                    }
                                }

                                if (EnglishDownloadedHTMLFilePaths.Any())
                                {
                                    List<string> CopyEnglishDownloadedHTMLFilePaths = EnglishDownloadedHTMLFilePaths
                                        .Where(x => !AlreadyExistSavedCertificateEntities.Contains(x.ProvidedFormId))
                                        .Select(x => x.FilePath)
                                        .ToList();

                                    foreach (string DownloadedHTMLFilePath in CopyEnglishDownloadedHTMLFilePaths)
                                    {
                                        string ContentToSave = EnglishHTMLContentForEachForm[CopyEnglishDownloadedHTMLFilePaths.IndexOf(DownloadedHTMLFilePath)];
                                        await File.WriteAllTextAsync(DownloadedHTMLFilePath, ContentToSave, System.Text.Encoding.UTF8);
                                    }
                                }
                            }
                            else
                            {
                                await _ArbitrationResultRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.GotStatement2, false)
                                        .SetProperty(y => y.DateOfObtainingTheStatement2, y => null));

                                List<SavedCertificate> SavedCertificatesEntitiesToDelete = await _SavedCertificateRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                                        x.TemplateType == TemplateTypes.Testimonial_Version_2)
                                    .ToListAsync();

                                foreach (SavedCertificate SavedCertificateToDelete in SavedCertificatesEntitiesToDelete)
                                {
                                    File.Delete(SavedCertificateToDelete.FilePath);
                                }

                                await _SavedCertificateRepository.DeleteListAsync(SavedCertificatesEntitiesToDelete);
                            }
                        }

                        ResponseMessage = Request.lang == "en"
                            ? "Arbitration result has been deleted successfully"
                            : "تم تعديل نتيجة التحكيم بنجاح";

                        Transaction.Complete();

                        return new BaseResponse<object>(ResponseMessage, true, 200);
                    }
                    else
                    {
                        List<ArbitrationResult> ArbitrationResultEntitiesToUpdate = await _ArbitrationResultRepository
                            .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                            .ToListAsync();

                        byte[] NotAuthenticatedHeaderImageBytes = await File.ReadAllBytesAsync(Request.ImagePath + "/CertificatesMainTemplates/logo_dark_ar.png");
                        string NotAuthenticatedHeaderImagebase64String = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes);
                        
                        if (Request.isCerticate == CertificationActionTypes.True)
                        {
                            ArbitrationResult? ArbitrationResultEntity = ArbitrationResultEntitiesToUpdate
                                .FirstOrDefault(x => x.ProvidedForm!.Category!.MinimumRequirementToObtainACertificate == null ||
                                    x.ProvidedForm!.Category!.MaximumRequirementToObtainACertificate == null);

                            if (ArbitrationResultEntity is not null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"This category: {ArbitrationResultEntity.ProvidedForm!.Category!.EnglishName} doesn't contain a certificate"
                                    : $"هذه الفئة {ArbitrationResultEntity.ProvidedForm!.Category!.ArabicName} لا تحتوي على شهادة";

                                return new BaseResponse<object>(ResponseMessage, true, 400);
                            }

                            if (Request.isCerticate == CertificationActionTypes.True)
                            {
                                List<SavedCertificate> SavedCertificateEntities = await _SavedCertificateRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                                        (x.TemplateType == TemplateTypes.CertificateOfParticipation ||
                                        x.TemplateType == TemplateTypes.Evaluation_Form))
                                    .ToListAsync();

                                if (SavedCertificateEntities.Any())
                                {
                                    List<SavedCertificate> ArabicSavedCertificateEntities = SavedCertificateEntities
                                        .Where(x => x.ProvidedForm!.Formlanguage == "ar")
                                        .ToList();

                                    if (ArabicSavedCertificateEntities.Any())
                                    {
                                        List<RecipientsWithViews> ArabicCertificateRecipients = ArabicSavedCertificateEntities
                                            .Where(x => x.TemplateType == TemplateTypes.CertificateOfParticipation)
                                            .Select(x =>
                                            {
                                                // Fetch content from the URL
                                                string Body = File.ReadAllText(x.FilePath);

                                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");

                                                if (!string.IsNullOrEmpty(x.Template!.BackgroundImageUrl))
                                                {
                                                    string FileNameForBackGroundImage = Path.GetFileName(x.Template!.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                    LinkedResource BackGroundImage1 = new LinkedResource($"wwwroot/CertificateTemplates/{FileNameForBackGroundImage}") { ContentId = "BackGroundImage" };
                                                    AlternateView.LinkedResources.Add(BackGroundImage1);

                                                    byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                                    string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);

                                                    Body = Body
                                                        .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                                }

                                                string FileNameForDigitalSignature = Path.GetFileName(x.DigitalSignature!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                LinkedResource BackGroundImage2 = new LinkedResource($"wwwroot/DigitalSignatures/{FileNameForDigitalSignature}") { ContentId = "DigitalSignature" };
                                                AlternateView.LinkedResources.Add(BackGroundImage2);

                                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogoImage" };
                                                AlternateView.LinkedResources.Add(HeaderImage);

                                                byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                                string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                                Body = Body
                                                    .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                                    .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                                return new RecipientsWithViews()
                                                {
                                                    Recipient = x.ProvidedForm!.User!.Email,
                                                    Body = Body,
                                                    AlternateView = AlternateView
                                                };
                                            }).ToList();

                                        await _EmailSender.SendEmailAsyncWithDifferentBodies
                                            (ArabicCertificateRecipients, "شهادة مشاركة");

                                        List<RecipientsWithViews> ArabicEvaluationFormRecipients = ArabicSavedCertificateEntities
                                            .Where(x => x.TemplateType == TemplateTypes.Evaluation_Form)
                                            .Select(x =>
                                            {
                                                // Fetch content from the URL
                                                string Body = File.ReadAllText(x.FilePath);

                                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");

                                                if (!string.IsNullOrEmpty(x.Template!.BackgroundImageUrl))
                                                {
                                                    string FileNameForBackGroundImage = Path.GetFileName(x.Template!.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                    LinkedResource BackGroundImage1 = new LinkedResource($"wwwroot/CertificateTemplates/{FileNameForBackGroundImage}") { ContentId = "BackGroundImage" };
                                                    AlternateView.LinkedResources.Add(BackGroundImage1);

                                                    byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                                    string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);

                                                    Body = Body
                                                        .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                                }

                                                string FileNameForDigitalSignature = Path.GetFileName(x.DigitalSignature!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                LinkedResource BackGroundImage2 = new LinkedResource($"wwwroot/DigitalSignatures/{FileNameForDigitalSignature}") { ContentId = "DigitalSignature" };
                                                AlternateView.LinkedResources.Add(BackGroundImage2);

                                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogoImage" };
                                                AlternateView.LinkedResources.Add(HeaderImage);

                                                byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                                string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                                Body = Body
                                                    .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                                    .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");
                                                return new RecipientsWithViews()
                                                {
                                                    Recipient = x.ProvidedForm!.User!.Email,
                                                    Body = Body,
                                                    AlternateView = AlternateView
                                                };
                                            }).ToList();

                                        await _EmailSender.SendEmailAsyncWithDifferentBodies
                                            (ArabicEvaluationFormRecipients, "استمارة تقويمية");
                                    }

                                    List<SavedCertificate> EnglishSavedCertificateEntities = SavedCertificateEntities
                                        .Where(x => x.ProvidedForm!.Formlanguage == "en")
                                        .ToList();

                                    if (EnglishSavedCertificateEntities.Any())
                                    {
                                        List<RecipientsWithViews> EnglishCertificateRecipients = EnglishSavedCertificateEntities
                                            .Where(x => x.TemplateType == TemplateTypes.CertificateOfParticipation)
                                            .Select(x =>
                                            {
                                                // Fetch content from the URL
                                                string Body = File.ReadAllText(x.FilePath);

                                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");

                                                if (!string.IsNullOrEmpty(x.Template!.BackgroundImageUrl))
                                                {
                                                    string FileNameForBackGroundImage = Path.GetFileName(x.Template!.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                    LinkedResource BackGroundImage1 = new LinkedResource($"wwwroot/CertificateTemplates/{FileNameForBackGroundImage}") { ContentId = "BackGroundImage" };
                                                    AlternateView.LinkedResources.Add(BackGroundImage1);

                                                    byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                                    string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);

                                                    Body = Body
                                                        .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                                }

                                                string FileNameForDigitalSignature = Path.GetFileName(x.DigitalSignature!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                LinkedResource BackGroundImage2 = new LinkedResource($"wwwroot/DigitalSignatures/{FileNameForDigitalSignature}") { ContentId = "DigitalSignature" };
                                                AlternateView.LinkedResources.Add(BackGroundImage2);

                                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogoImage" };
                                                AlternateView.LinkedResources.Add(HeaderImage);

                                                byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                                string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                                Body = Body
                                                    .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                                    .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");
                                                return new RecipientsWithViews()
                                                {
                                                    Recipient = x.ProvidedForm!.User!.Email,
                                                    Body = Body,
                                                    AlternateView = AlternateView
                                                };
                                            }).ToList();

                                        await _EmailSender.SendEmailAsyncWithDifferentBodies
                                            (EnglishCertificateRecipients, "Participation Certificate");

                                        List<RecipientsWithViews> EnglishEvaluationFormRecipients = EnglishSavedCertificateEntities
                                            .Where(x => x.TemplateType == TemplateTypes.Evaluation_Form)
                                            .Select(x =>
                                            {
                                                // Fetch content from the URL
                                                string Body = File.ReadAllText(x.FilePath);

                                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");

                                                if (!string.IsNullOrEmpty(x.Template!.BackgroundImageUrl))
                                                {
                                                    string FileNameForBackGroundImage = Path.GetFileName(x.Template!.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                    LinkedResource BackGroundImage1 = new LinkedResource($"wwwroot/CertificateTemplates/{FileNameForBackGroundImage}") { ContentId = "BackGroundImage" };
                                                    AlternateView.LinkedResources.Add(BackGroundImage1);

                                                    byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                                    string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);

                                                    Body = Body
                                                        .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                                }

                                                string FileNameForDigitalSignature = Path.GetFileName(x.DigitalSignature!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                LinkedResource BackGroundImage2 = new LinkedResource($"wwwroot/DigitalSignatures/{FileNameForDigitalSignature}") { ContentId = "DigitalSignature" };
                                                AlternateView.LinkedResources.Add(BackGroundImage2);

                                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogoImage" };
                                                AlternateView.LinkedResources.Add(HeaderImage);

                                                byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                                string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                                Body = Body
                                                    .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                                    .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");
                                                return new RecipientsWithViews()
                                                {
                                                    Recipient = x.ProvidedForm!.User!.Email,
                                                    Body = Body,
                                                    AlternateView = AlternateView
                                                };
                                            }).ToList();

                                        await _EmailSender.SendEmailAsyncWithDifferentBodies
                                            (EnglishEvaluationFormRecipients, "Participation Certificate");
                                    }
                                }
                            }
                        }

                        if (Request.isStatment1 == CertificationActionTypes.True)
                        {
                            ArbitrationResult? ArbitrationResultEntity = ArbitrationResultEntitiesToUpdate
                                .FirstOrDefault(x => !x.ProvidedForm!.Category!.ContainStatment1);

                            if (ArbitrationResultEntity is not null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"This category: {ArbitrationResultEntity.ProvidedForm!.Category!.EnglishName} doesn't contain a statment"
                                    : $"هذه الفئة {ArbitrationResultEntity.ProvidedForm!.Category!.ArabicName} لا تحتوي على إفادة";

                                return new BaseResponse<object>(ResponseMessage, true, 400);
                            }

                            if (Request.isStatment1 == CertificationActionTypes.True)
                            {
                                List<SavedCertificate> SavedCertificateEntities = await _SavedCertificateRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                                        x.TemplateType == TemplateTypes.Testimonial_Version_1)
                                    .ToListAsync();

                                if (SavedCertificateEntities.Any())
                                {
                                    List<SavedCertificate> ArabicSavedCertificateEntities = SavedCertificateEntities
                                        .Where(x => x.ProvidedForm!.Formlanguage == "ar")
                                        .ToList();

                                    if (ArabicSavedCertificateEntities.Any())
                                    {
                                        List<RecipientsWithViews> ArabicRecipients = ArabicSavedCertificateEntities
                                            .Select(x =>
                                            {
                                                // Fetch content from the URL
                                                string Body = File.ReadAllText(x.FilePath);

                                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");

                                                if (!string.IsNullOrEmpty(x.Template!.BackgroundImageUrl))
                                                {
                                                    string FileNameForBackGroundImage = Path.GetFileName(x.Template!.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                    LinkedResource BackGroundImage1 = new LinkedResource($"wwwroot/CertificateTemplates/{FileNameForBackGroundImage}") { ContentId = "BackGroundImage" };
                                                    AlternateView.LinkedResources.Add(BackGroundImage1);

                                                    byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                                    string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);

                                                    Body = Body
                                                        .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                                }

                                                string FileNameForDigitalSignature = Path.GetFileName(x.DigitalSignature!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                LinkedResource BackGroundImage2 = new LinkedResource($"wwwroot/DigitalSignatures/{FileNameForDigitalSignature}") { ContentId = "DigitalSignature" };
                                                AlternateView.LinkedResources.Add(BackGroundImage2);

                                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogoImage" };
                                                AlternateView.LinkedResources.Add(HeaderImage);

                                                byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                                string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                                Body = Body
                                                    .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                                    .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                                return new RecipientsWithViews()
                                                {
                                                    Recipient = x.ProvidedForm!.User!.Email,
                                                    Body = Body,
                                                    AlternateView = AlternateView
                                                };
                                            }).ToList();

                                        await _EmailSender.SendEmailAsyncWithDifferentBodies
                                            (ArabicRecipients, "إفادة 1");
                                    }

                                    List<SavedCertificate> EnglishSavedCertificateEntities = SavedCertificateEntities
                                        .Where(x => x.ProvidedForm!.Formlanguage == "en")
                                        .ToList();

                                    if (EnglishSavedCertificateEntities.Any())
                                    {
                                        List<RecipientsWithViews> EnglishRecipients = EnglishSavedCertificateEntities
                                            .Select(x =>
                                            {
                                                // Fetch content from the URL
                                                string Body = File.ReadAllText(x.FilePath);

                                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");

                                                if (!string.IsNullOrEmpty(x.Template!.BackgroundImageUrl))
                                                {
                                                    string FileNameForBackGroundImage = Path.GetFileName(x.Template!.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                    LinkedResource BackGroundImage1 = new LinkedResource($"wwwroot/CertificateTemplates/{FileNameForBackGroundImage}") { ContentId = "BackGroundImage" };
                                                    AlternateView.LinkedResources.Add(BackGroundImage1);

                                                    byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                                    string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);

                                                    Body = Body
                                                        .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                                }

                                                string FileNameForDigitalSignature = Path.GetFileName(x.DigitalSignature!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                LinkedResource BackGroundImage2 = new LinkedResource($"wwwroot/DigitalSignatures/{FileNameForDigitalSignature}") { ContentId = "DigitalSignature" };
                                                AlternateView.LinkedResources.Add(BackGroundImage2);

                                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogoImage" };
                                                AlternateView.LinkedResources.Add(HeaderImage);

                                                byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                                string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                                Body = Body
                                                    .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                                    .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                                return new RecipientsWithViews()
                                                {
                                                    Recipient = x.ProvidedForm!.User!.Email,
                                                    Body = Body,
                                                    AlternateView = AlternateView
                                                };
                                            }).ToList();

                                        await _EmailSender.SendEmailAsyncWithDifferentBodies
                                            (EnglishRecipients, "Statment 1");
                                    }
                                }
                            }
                        }

                        if (Request.isStatment2 == CertificationActionTypes.True)
                        {
                            ArbitrationResult? ArbitrationResultEntity = ArbitrationResultEntitiesToUpdate
                                .FirstOrDefault(x => x.ProvidedForm!.Category!.MinimumAmountToObtainAStatement2 == null ||
                                    x.ProvidedForm!.Category!.MaximumAmountToObtainAStatement2 == null);

                            if (ArbitrationResultEntity is not null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"This category: {ArbitrationResultEntity.ProvidedForm!.Category!.EnglishName} doesn't contain a statment"
                                    : $"هذه الفئة {ArbitrationResultEntity.ProvidedForm!.Category!.ArabicName} لا تحتوي على إفادة";

                                return new BaseResponse<object>(ResponseMessage, true, 400);
                            }

                            if (Request.isStatment2 == CertificationActionTypes.True)
                            {
                                List<SavedCertificate> SavedCertificateEntities = await _SavedCertificateRepository
                                    .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                                        x.TemplateType == TemplateTypes.Testimonial_Version_2)
                                    .ToListAsync();

                                if (SavedCertificateEntities.Any())
                                {
                                    List<SavedCertificate> ArabicSavedCertificateEntities = SavedCertificateEntities
                                        .Where(x => x.ProvidedForm!.Formlanguage == "ar")
                                        .ToList();

                                    if (ArabicSavedCertificateEntities.Any())
                                    {
                                        List<RecipientsWithViews> ArabicRecipients = ArabicSavedCertificateEntities
                                            .Select(x =>
                                            {
                                                // Fetch content from the URL
                                                string Body = File.ReadAllText(x.FilePath);
                                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");

                                                if (!string.IsNullOrEmpty(x.Template!.BackgroundImageUrl))
                                                {
                                                    string FileNameForBackGroundImage = Path.GetFileName(x.Template!.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                    LinkedResource BackGroundImage1 = new LinkedResource($"wwwroot/CertificateTemplates/{FileNameForBackGroundImage}") { ContentId = "BackGroundImage" };
                                                    AlternateView.LinkedResources.Add(BackGroundImage1);

                                                    byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                                    string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);

                                                    Body = Body
                                                        .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                                }

                                                string FileNameForDigitalSignature = Path.GetFileName(x.DigitalSignature!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                LinkedResource BackGroundImage2 = new LinkedResource($"wwwroot/DigitalSignatures/{FileNameForDigitalSignature}") { ContentId = "DigitalSignature" };
                                                AlternateView.LinkedResources.Add(BackGroundImage2);

                                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogoImage" };
                                                AlternateView.LinkedResources.Add(HeaderImage);

                                                byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                                string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                                Body = Body
                                                    .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                                    .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                                return new RecipientsWithViews()
                                                {
                                                    Recipient = x.ProvidedForm!.User!.Email,
                                                    Body = Body,
                                                    AlternateView = AlternateView
                                                };
                                            }).ToList();

                                        await _EmailSender.SendEmailAsyncWithDifferentBodies
                                            (ArabicRecipients, "إفادة 2");
                                    }

                                    List<SavedCertificate> EnglishSavedCertificateEntities = SavedCertificateEntities
                                        .Where(x => x.ProvidedForm!.Formlanguage == "en")
                                        .ToList();

                                    if (EnglishSavedCertificateEntities.Any())
                                    {
                                        List<RecipientsWithViews> EnglishRecipients = EnglishSavedCertificateEntities
                                            .Select(x =>
                                            {
                                                // Fetch content from the URL
                                                string Body = File.ReadAllText(x.FilePath);

                                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");

                                                if (!string.IsNullOrEmpty(x.Template!.BackgroundImageUrl))
                                                {
                                                    string FileNameForBackGroundImage = Path.GetFileName(x.Template!.BackgroundImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                    LinkedResource BackGroundImage1 = new LinkedResource($"wwwroot/CertificateTemplates/{FileNameForBackGroundImage}") { ContentId = "BackGroundImage" };
                                                    AlternateView.LinkedResources.Add(BackGroundImage1);

                                                    byte[] NotAuthenticatedHeaderImageBytes3 = File.ReadAllBytes(Request.ImagePath + $"/CertificateTemplates/{FileNameForBackGroundImage}");
                                                    string NotAuthenticatedHeaderImagebase64String3 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes3);

                                                    Body = Body
                                                        .Replace("'cid:BackGroundImage'", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String3}'");
                                                }

                                                string FileNameForDigitalSignature = Path.GetFileName(x.DigitalSignature!.ImageUrl.Replace("\\", "/").Replace("\"", "/"));

                                                LinkedResource BackGroundImage2 = new LinkedResource($"wwwroot/DigitalSignatures/{FileNameForDigitalSignature}") { ContentId = "DigitalSignature" };
                                                AlternateView.LinkedResources.Add(BackGroundImage2);

                                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/logos.png") { ContentId = "LogoImage" };
                                                AlternateView.LinkedResources.Add(HeaderImage);

                                                byte[] NotAuthenticatedHeaderImageBytes2 = File.ReadAllBytes(Request.ImagePath + $"/DigitalSignatures/{FileNameForDigitalSignature}");
                                                string NotAuthenticatedHeaderImagebase64String2 = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes2);

                                                Body = Body
                                                    .Replace("\"cid:LogoImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'")
                                                    .Replace("\"cid:DigitalSignature\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String2}'");

                                                return new RecipientsWithViews()
                                                {
                                                    Recipient = x.ProvidedForm!.User!.Email,
                                                    Body = Body,
                                                    AlternateView = AlternateView
                                                };
                                            }).ToList();

                                        await _EmailSender.SendEmailAsyncWithDifferentBodies
                                            (EnglishRecipients, "Statment 2");
                                    }
                                }
                            }
                        }

                        ResponseMessage = Request.lang == "en"
                            ? "Arbitration result has been deleted successfully"
                            : "تم تعديل نتيجة التحكيم بنجاح";

                        Transaction.Complete();

                        return new BaseResponse<object>(ResponseMessage, true, 200);
                    }
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
