using AutoMapper;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Features.Authentication.SignUp;
using SharijhaAward.Application.Features.Event.Commands.CreateEvent;
using SharijhaAward.Application.Features.Event.Commands.UpdateEvent;
using SharijhaAward.Application.Features.Event.Queries.GetAllEvents;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;
using SharijhaAward.Application.Features.Event.Queries.GetEventWithInvitees;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.CreateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.DeleteGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Command.UpdateGroupInvitee;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupInviteeById;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.CreatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.DeletePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ConfirmAttendancePersonal;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalInviteeById;
using SharijhaAward.Domain.Entities.InvitationModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Application.Features.User.Commands.DeleteUser;
using SharijhaAward.Application.Features.User.Queries.GetUserById;
using SharijhaAward.Application.Features.User.Queries.GetAllUsers;
using SharijhaAward.Application.Features.Identity.Role.Queries.GetAllRoles;
using SharijhaAward.Application.Features.User.Queries.AsignRoleToUser;
using SharijhaAward.Application.Features.ProvidedForm.Command.CreateProvidedForm;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Application.Features.Categories.Command.CreateCategory;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoryById;
using SharijhaAward.Application.Features.Categories.Queries.GetAllCategories;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetPersonalByInviteeNumber;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupByInviteeNumber;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.DeleteTrainingWorkshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Application.Features.FAQs.Commands.CreateFAQ;
using SharijhaAward.Application.Features.FAQs.Commands.UpdateFAQ;
using SharijhaAward.Application.Features.FAQs.Commands.DeleteFAQ;
using SharijhaAward.Application.Features.FAQs.Queries.GetFAQById;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Application.Features.Cycles.Commands.CreateCycle;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Application.Features.DynamicAttributeFeaturesFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.ExportToExcel;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.ExportGroupToExcel;
using SharijhaAward.Application.Features.Event.Queries.ExportToExcel;
using SharijhaAward.Domain.Entities.NewsModel;
using SharijhaAward.Application.Features.News.Commands.CreateNews;
using SharijhaAward.Application.Features.News.Commands.UpdateNews;
using SharijhaAward.Application.Features.News.Queries.GetNewsById;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles;
using SharijhaAward.Application.Features.Cycles.Commands.UpdateCycle;
using SharijhaAward.Application.Features.Cycles.Queries.GetCycleById;
using SharijhaAward.Application.Features.User.Commands.UpdateUser;
using SharijhaAward.Application.Features.Categories.Command.UpdateCategory;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection;

using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.UpdateDynamicAttribute;
using SharijhaAward.Domain.Entities.AgendaModel;
using SharijhaAward.Application.Features.Agendas.Commands.CreateAgenda;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendaById;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Application.Features.CycleConditions.Commands.CreateCycleCondition;
using SharijhaAward.Application.Features.CycleConditions.Commands.UpdateCycleCondition;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using SharijhaAward.Application.Features.TermsAndConditions.Commands.CreateTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Commands.UpdateTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetTermAndConditionById;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Features.Agendas.Commands.UpdateAgenda;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDataTypes;
using SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.CreateDynamicAttributeListValue;
using SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.UpdateDynamicAttributeListValue;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllAttributeOperations;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllAttributeTablesNames;
using SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetAllDynamicAttributePattern;
using SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetDynamicAttributePatternById;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.CreateAttachment;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using SharijhaAward.Application.Features.ExplanatoryGuides.Commands.CreateExplanatoryGuide;
using SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.CreateWorkshpoeAttachment;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterion;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntities;
using SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinator;
using SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionItemAttachment;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionAttachment;
using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetProvidedFormById;
using SharijhaAward.Application.Features.GeneralFAQs.Commands.CreateGeneralFAQ;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution;
using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions;
using SharijhaAward.Domain.Entities.RelatedAccountModel;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllReceivedRequests;
using SharijhaAward.Application.Features.GeneralFAQCategories.Commands.CreateGeneralFAQCategory;
using SharijhaAward.Application.Features.GeneralFAQCategories.Commands.UpdateGeneralFAQCategory;
using SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory;
using SharijhaAward.Application.Features.Settings.Queries.GetProfileById;
using SharijhaAward.Application.Features.Cycles.Queries.GetLimteNumberOfCategories;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;
using SharijhaAward.Application.Features.GeneralWorkshops.Commands.CreateGeneralWorkshop;
using SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetAllGeneralWorkshops;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateGoal;
using SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetGeneralWorkshopById;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Application.Features.Coordinators.Queries.AddCordinatorToEduEntity;
using SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetRelatedAccoutProfileById;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById;
using SharijhaAward.Domain.Entities.AchievementModel;
using SharijhaAward.Application.Features.Achievements.Commands.CreateAchievement;
using SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsPage;
using SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideDetailsByCategoryId;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.UpdateCriterion;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionItem;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.UpdateCriterionItem;
using SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateSubCriterion;
using SharijhaAward.Application.Features.CriterionFeatures.Queries.GetMainCriterionById;
using SharijhaAward.Application.Features.Achievements.Commands.UpdateAchievement;
using SharijhaAward.Application.Features.GeneralWorkshops.Commands.UpdateGeneralWorkshop;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.UpdateAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Commands.UpdateGoal;
using SharijhaAward.Application.Features.ExplanatoryGuides.Commands.UpdateExplanatoryGuide;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitrator;
using SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById;
using SharijhaAward.Application.Features.EducationalEntities.Command.UpdateEducationalEntity;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetEducationalEntityById;
using SharijhaAward.Application.Features.EducationalInstitutions.Commands.UpdateEducationalInstitutions;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using SharijhaAward.Application.Features.CycleConditions.Attachments.Commands.CreateAttachment;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Application.Features.Classes.Commands.CreateClass;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Application.Features.Classes.Commands.UpdateClass;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Features.Classes.Queries.GetClassById;
using SharijhaAward.Application.Features.CriterionFeatures.Queries.GetCriterionItemById;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Application.Features.ExtraAttachments.Commands.CreateExtraAttachment;
using SharijhaAward.Application.Features.ExtraAttachments.Commands.UpdateExtraAttachment;
using SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachment;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachmentByFormId;
using SharijhaAward.Domain.Entities.AppVersioningModel;
using SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetLastAppVersion;
using SharijhaAward.Domain.Entities.InstructionModel;
using SharijhaAward.Application.Features.InstructionsFeatures.Commands.UpdateInstruction;
using SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetAllInstructions;
using SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetInstructionBySlugId;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.UpdateWorkshopAttachment;
using SharijhaAward.Application.Features.RoleFeatures.Commands.UpdateRole;
using SharijhaAward.Application.Features.ExtraAttachments.Attachment.Commands.AddExtraAttachmentFile;
using SharijhaAward.Application.Features.RoleFeatures.Queries.GetAllRoles;
using SharijhaAward.Application.Features.PermissionFeatures.Queries.GetAllPermissions;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard;
using SharijhaAward.Application.Features.MessageTypes.Commands.UpdateMsgType;
using SharijhaAward.Application.Features.MessageTypes.Queries.GetAllMsgType;

namespace SharijhaAward.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.EventModel.Event, CreateEventDto>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event, CreateEventCommand>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event, EventListVM>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event, EventDto>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event, EventInviteesVM>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event, EventsExportVM>().ReverseMap();

            CreateMap<PersonalInvitee, CreatePersonalInviteeCommand>().ReverseMap();
            CreateMap<PersonalInvitee, UpdatePersonalInviteeCommand>().ReverseMap();
            CreateMap<PersonalInvitee, DeletePersonalInviteeCommand>().ReverseMap();
            CreateMap<PersonalInvitee, PersonalInviteeVM>().ReverseMap();
            CreateMap<PersonalInvitee, PersonalInviteeListVM>().ReverseMap();
            CreateMap<PersonalInvitee, EventInvitessDto>().ReverseMap();
            CreateMap<PersonalInvitee, ConfirmAttendancePersonalQuery>().ReverseMap();
            CreateMap<PersonalInvitee, PersonalDto>().ReverseMap();
            CreateMap<PersonalInvitee, PersonalExportVM>().ReverseMap();


            CreateMap<GroupInvitee, CreateGroupInviteeCommand>().ReverseMap();
            CreateMap<GroupInvitee, DeleteGroupInviteeCommand>().ReverseMap();
            CreateMap<GroupInvitee, UpdateGroupInviteeCommand>().ReverseMap();
            CreateMap<GroupInvitee, GroupInviteeListVM>()
                .ForMember(x => x.StudentNamesAsString, x => x.MapFrom(y => y.StudentNames!.Select(z => z.StudentName))).ReverseMap();
            CreateMap<GroupInviteeListVM, GroupInvitee>();
            CreateMap<GroupInvitee, GroupInviteeVM>()
                .ForMember(x => x.StudentNamesAsString, x => x.MapFrom(y => y.StudentNames!.Select(z => z.StudentName))).ReverseMap();
            CreateMap<GroupInviteeVM, GroupInvitee>();
            CreateMap<GroupInvitee, ConfirmAttendanceGroupQuery>();
            CreateMap<GroupInvitee, GroupDto>().ReverseMap();
            CreateMap<GroupInvitee, GroupExportVM>()
                .ForMember(x => x.StudentNames, x => x.MapFrom(y => y.StudentNames!.Select(z => z.StudentName))).ReverseMap();
            CreateMap<Student, GroupInviteeStudentsDto>().ReverseMap();
           

            CreateMap<User, LoginCommand>().ReverseMap();
            CreateMap<User, SignUpCommand>().ReverseMap();
            CreateMap<User, UpdateUserCommand>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserListVm>().ReverseMap();
            CreateMap<User, AsignRoleToUserQuery>().ReverseMap();

            CreateMap<Role, RoleListVm>().ReverseMap();

            CreateMap<ProvidedForm, CreateProvidedFormCommand>();

            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListVM>().ReverseMap();
            CreateMap<Category, CategoriesSubcategoriesDto>().ReverseMap();
            CreateMap<Category, SubcategoriesListVM>().ReverseMap();

            CreateMap<TrainingWorkshop, CreateTrainingWorkshopsCommand>().ReverseMap();
            CreateMap<TrainingWorkshop, UpdateTrainingWorkshopCommand>().ReverseMap();
            CreateMap<TrainingWorkshop, DeleteTrainingWorkshopCommand>().ReverseMap();
            CreateMap<TrainingWorkshop, TrainingWorkshopDto>().ReverseMap();
            CreateMap<TrainingWorkshop, TrainingWorkshopListVm>().ReverseMap();

            CreateMap<FrequentlyAskedQuestion, CreateFAQCommand>().ReverseMap();
            CreateMap<FrequentlyAskedQuestion, UpdateFAQCommand>().ReverseMap();
            CreateMap<FrequentlyAskedQuestion, DeleteFAQCommand>().ReverseMap();
            CreateMap<FrequentlyAskedQuestion, FAQDto>().ReverseMap();
            CreateMap<FrequentlyAskedQuestion, FAQListVm>().ReverseMap();

            CreateMap<Cycle, CreateCycleCommand>().ReverseMap();
            CreateMap<Cycle, CycleListVM>().ReverseMap();
            CreateMap<Cycle, UpdateCycleCommand>().ReverseMap();
            CreateMap<Cycle, CycleDto>().ReverseMap();
            CreateMap<Cycle, LimitationDto>().ReverseMap();

            CreateMap<News, CreateNewsCommand>().ReverseMap();
            CreateMap<News, UpdateNewsCommand>().ReverseMap();
            CreateMap<News, NewsVM>().ReverseMap();
            CreateMap<News, NewsListVM>().ReverseMap();

            CreateMap<Agenda, CreateAgendaCommand>().ReverseMap();
            CreateMap<Agenda, UpdateAgendaCommand>().ReverseMap();
            CreateMap<Agenda, AgendaDto>().ReverseMap();
            CreateMap<Agenda, AgendaListVm>().ReverseMap();

            CreateMap<CycleCondition, CreateCycleConditionCommand>().ReverseMap();
            CreateMap<CycleCondition, UpdateCycleConditionCommand>().ReverseMap();
            CreateMap<CycleCondition, CycleConditionDto>().ReverseMap();
            CreateMap<CycleCondition, CycleConditionListVM>().ReverseMap();
            CreateMap<CycleCondition, CyclePublicConditionListVm>().ReverseMap();
            CreateMap<CycleCondition, CycleConditionProvidedFormListVm>().ReverseMap();

            CreateMap<CycleConditionAttachment, CreateCycleConditionAttachmentCommand>().ReverseMap();
            CreateMap<CycleConditionAttachment, CycleConditionAttachmentListVm>().ReverseMap();
            CreateMap<CycleConditionsProvidedForm, CyclePublicConditionListVm>().ReverseMap();
            CreateMap<CycleConditionsProvidedForm, CycleConditionProvidedFormListVm>().ReverseMap();

            CreateMap<TermAndCondition, CreateTermAndConditionCommand>().ReverseMap();
            CreateMap<TermAndCondition, UpdateTermAndConditionCommand>().ReverseMap();
            CreateMap<TermAndCondition, TermAndConditionDto>().ReverseMap();
            CreateMap<TermAndCondition, Features.TermsAndConditions.Queries.GetAllTermAndCondition.TermAndConditionListVM>().ReverseMap();
            CreateMap<TermAndCondition, TermAndConditionListVM>().ReverseMap();

            CreateMap<ConditionAttachment, AttachmentListVM>().ReverseMap();
            CreateMap<ConditionAttachment, CreateAttachmentCommand>().ReverseMap();
            CreateMap<ConditionsProvidedForms, ConditionProvidedFormListVm>().ReverseMap();


            CreateMap<ProvidedForm, CreateProvidedFormCommand>().ReverseMap();
            CreateMap<ProvidedForm, FormListVm>().ReverseMap();
            CreateMap<ProvidedForm, ProvidedFormDto>().ReverseMap();

            CreateMap<ExplanatoryGuide, CreateExplanatoryGuideCommand>().ReverseMap();
            CreateMap<ExplanatoryGuide, ExplanatoryGuideDetailsDto>().ReverseMap();
            CreateMap<ExplanatoryGuide, UpdateExplanatoryGuideCommand>().ReverseMap();
           

            CreateMap<TrainingWrokshopeAttachment, WorkshopAttachmentListVM>().ReverseMap();
            CreateMap<TrainingWrokshopeAttachment, CreateWorkshopeAttachmentCommand>().ReverseMap();
            CreateMap<TrainingWrokshopeAttachment, UpdateWorkshopAttachmentCommand>().ReverseMap();
         
            CreateMap<EducationalEntity, EducationalEntitiesListVm>().ReverseMap();
            CreateMap<EducationalEntity, CreateEducationalEntityCommand>().ReverseMap();

            CreateMap<EduEntitiesCoordinator, AddCoordinatorToEduEntityQuery>().ReverseMap();
            
            CreateMap<EducationalInstitution, CreateEducationalInstitutionCommand>().ReverseMap();
            CreateMap<EducationalInstitution, Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions.EducationalInstitutionListVM>().ReverseMap();

            CreateMap<Coordinator, CreateCoordinatorCommand>().ReverseMap();
            CreateMap<Coordinator, CoordinatorSearchListVM>().ReverseMap();
            CreateMap<Coordinator, CoordinatorDto>().ReverseMap();

            CreateMap<GeneralWorkshop, CreateGeneralWorkshopCommand>().ReverseMap();
            CreateMap<GeneralWorkshop, UpdateGeneralWorkshopCommand>().ReverseMap();
            CreateMap<GeneralWorkshop, GeneralWorkshopsListVM>().ReverseMap();
            CreateMap<GeneralWorkshop, GeneralWorkshopDto>().ReverseMap();

            CreateMap<AboutAwardPage, CreateAboutPageCommand>().ReverseMap();
            CreateMap<AboutAwardPage, AboutPageDto>().ReverseMap();
            CreateMap<AboutAwardPage, UpdateAboutPageCommand>().ReverseMap();

            CreateMap<OurGoal, CreateGoalCommand>().ReverseMap();
            CreateMap<OurGoal, UpdateGoalCommand>().ReverseMap();
            CreateMap<OurGoal, OurGoalsDto>().ReverseMap();
            
            CreateMap<EmailMessage, CreateMessageCommand>().ReverseMap();
            CreateMap<EmailMessage, EmailMessageListVM>().ReverseMap();
            CreateMap<EmailMessage, EmailMessageDto>().ReverseMap();

            CreateMap<EmailAttachment, EmailAttachmentListVm>().ReverseMap();

            CreateMap<Achievement, CreateAchievementCommand>().ReverseMap();
            CreateMap<Achievement, UpdateAchievementCommand>().ReverseMap();
            CreateMap<Achievement, AchievementsDto>().ReverseMap();

            CreateMap<ExtraAttachment, CreateExtraAttachmentCommand>().ReverseMap();
            CreateMap<ExtraAttachment, UpdateExtraAttachmentCommand>().ReverseMap();
            CreateMap<ExtraAttachment, ExtraAttachmentListVM>().ReverseMap();
            
            CreateMap<ExtraAttachmentFile, AttachmentDto>().ReverseMap();
            CreateMap<ExtraAttachmentFile, AddExtraAttachmentFileCommand>().ReverseMap();

            CreateMap<MessageType, CreateMessageCommand>().ReverseMap();
            CreateMap<MessageType, UpdateMsgTypeCommand>().ReverseMap();
            CreateMap<MessageType, MessageTypeListVM>().ReverseMap();

            //
            // Dynamic Attribute..
            //

            // Create..
            CreateMap<DynamicAttribute, CreateDynamicAttributeCommand>().ReverseMap();
            CreateMap<GeneralValidation, CreateGeneralValidation>().ReverseMap();
            CreateMap<Dependency, CreateDependency>().ReverseMap();
            CreateMap<DependencyValidation, CreateDependencyValidation>().ReverseMap();
            CreateMap<DynamicAttributeSection, CreateDynamicAttributeSectionCommand>().ReverseMap();
            CreateMap<Criterion, CreateCriterionCommand>().ReverseMap();
            CreateMap<Criterion, CreateSubCriterionDto>().ReverseMap();
            CreateMap<CriterionItem, CreateCriterionItemDto>().ReverseMap();
            CreateMap<CriterionAttachment, CreateCriterionAttachmentCommand>().ReverseMap();
            CreateMap<CriterionItemAttachment, CreateCriterionItemAttachmentCommand>().ReverseMap();
            CreateMap<CriterionAttachment, CreateCriterionAttachmentVM>().ReverseMap();
            CreateMap<CriterionItemAttachment, CreateCriterionItemAttachmentVM>().ReverseMap();
            CreateMap<GeneralFAQ, CreateGeneralFAQCommand>().ReverseMap();
            CreateMap<GeneralFAQCategory, CreateGeneralFAQCategoryCommand>().ReverseMap();
            CreateMap<CriterionItem, CreateCriterionItemCommand>().ReverseMap();
            CreateMap<Criterion, CreateSubCriterionCommand>().ReverseMap();
            CreateMap<Arbitrator, CreateArbitratorCommand>().ReverseMap();
            CreateMap<EducationalClass, CreateClassCommand>().ReverseMap();

            // Update..
            CreateMap<DynamicAttributeSection, UpdateDynamicAttributeSectionCommand>().ReverseMap();
            CreateMap<DynamicAttribute, UpdateDynamicAttributeCommand>().ReverseMap();
            CreateMap<DynamicAttributeListValue, UpdateDynamicAttributeListValueCommand>().ReverseMap();
            CreateMap<GeneralFAQCategory, UpdateGeneralFAQCategoryCommand>().ReverseMap();
            CreateMap<Criterion, UpdateCriterionCommand>().ReverseMap();
            CreateMap<CriterionItem, UpdateCriterionItemCommand>().ReverseMap();
            CreateMap<EducationalEntity, UpdateEducationalEntityCommand>().ReverseMap();
            CreateMap<EducationalInstitution, UpdateEducationalInstitutionsCommand>().ReverseMap();
            CreateMap<EducationalClass, UpdateClassCommand>().ReverseMap();
            CreateMap<Instruction, UpdateInstructionCommand>().ReverseMap();
            CreateMap<Role, UpdateRoleCommand>().ReverseMap();

            // Get..
            CreateMap<DynamicAttributeSection, DynamicAttributeSectionListVM>().ReverseMap();
            CreateMap<DynamicAttribute, DynamicAttributeListVM>().ReverseMap();
            CreateMap<DynamicAttribute, GetDynamicAttributeByIdDto>().ReverseMap();
            CreateMap<AttributeDataType, GetAllDataTypesListVM>().ReverseMap();
            CreateMap<GeneralValidation, GeneralValidationDto>()
                .ForMember(x => x.AttributeOperation, x => x.MapFrom(y => y.AttributeOperation.OperationAsString));
            CreateMap<GeneralValidationDto, GeneralValidation>();
            CreateMap<DynamicAttributeListValue, CreateDynamicAttributeListValueCommand>();
            CreateMap<AttributeOperation, GetAllAttributeOperationsListVM>()
                .ForMember(x => x.Name, x => x.MapFrom(y => y.OperationAsString));
            CreateMap<GetAllAttributeOperationsListVM, AttributeOperation>()
                .ForMember(x => x.OperationAsString, x => x.MapFrom(y => y.Name));
            CreateMap<DynamicAttributeListValue, DynamicAttributeListValueListVM>().ReverseMap();
            CreateMap<AttributeTableName, GetAllAttributeTablesNamesListVM>().ReverseMap();
            CreateMap<DynamicAttribute, DynamicAttributePattern>().ReverseMap();
            CreateMap<DynamicAttributePattern, GetAllDynamicAttributePatternListVM>().ReverseMap();
            CreateMap<DynamicAttributePatternValue, GetDynamicAttributePatternByIdValues>().ReverseMap();
            CreateMap<DynamicAttributePattern, GetDynamicAttributePatternByIdDto>().ReverseMap();
            CreateMap<CriterionAttachment, AttachmentListVM>().ReverseMap();
            CreateMap<CriterionItemAttachment, AttachmentListVM>().ReverseMap();
            CreateMap<RelatedAccountRequest, GetAllReceivedRequestsListVM>().ReverseMap();
            CreateMap<User, GetProfileByIdDto>().ReverseMap();
            CreateMap<User, RelatedAccountProfileData>().ReverseMap();
            CreateMap<ProvidedForm, RelatedAccountProvidedForms>().ReverseMap();
            CreateMap<User, UserDataResponse>().ReverseMap();
            CreateMap<Criterion, GetMainCriterionByIdDto>().ReverseMap();
            CreateMap<Criterion, SubCriterionListDto>().ReverseMap();
            CreateMap<CriterionItem, CriterionItemListDto>().ReverseMap();
            CreateMap<Coordinator, GetAllCoordinatorsListVM>().ReverseMap();
            CreateMap<Arbitrator, GetAllArbitratorsListVM>().ReverseMap();
            CreateMap<Arbitrator, ArbitratorDto>().ReverseMap();
            CreateMap<EducationalEntity, GetEducationalEntityByIdDto>().ReverseMap();
            CreateMap<EducationalClass, GetAllClassesListVM>().ReverseMap();
            CreateMap<EducationalClass, GetClassByIdDto>().ReverseMap();
            CreateMap<CriterionItem, GetCriterionItemByIdDto>().ReverseMap();
            CreateMap<AppVersion, GetLastAppVersionDto>().ReverseMap();
            CreateMap<Instruction, GetAllInstructionsListVM>().ReverseMap();
            CreateMap<Instruction, GetInstructionBySlugIdDto>().ReverseMap();
            CreateMap<Role, GetAllRolesListVM>().ReverseMap();
            CreateMap<Permission, PermissionListVM>().ReverseMap();
            CreateMap<EducationalEntity, GetAllEducationalEntitiesForAdminDashboardListVM>().ReverseMap();
        }
    }
}
