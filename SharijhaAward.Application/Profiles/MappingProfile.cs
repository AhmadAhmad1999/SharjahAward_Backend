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
using SharijhaAward.Application.Features.Categories.Queries.GatCategoryById;
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
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSections;
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
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDataTypes;
using SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.CreateDynamicAttributeListValue;
using SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.UpdateDynamicAttributeListValue;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllAttributeOperations;


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
            CreateMap<User, UpdateUserCommand>();
            CreateMap<User, DeleteUserCommand>();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserListVm>().ReverseMap();
            CreateMap<User, AsignRoleToUserQuery>();

            CreateMap<Role, RoleListVm>().ReverseMap();

            CreateMap<ProvidedForm, CreateProvidedFormCommand>();

            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListVM>().ReverseMap();

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
            CreateMap<CycleCondition, CycleDto>().ReverseMap();
            CreateMap<CycleCondition, CycleListVM>().ReverseMap();

            CreateMap<TermAndCondition, CreateTermAndConditionCommand>().ReverseMap();
            CreateMap<TermAndCondition, UpdateTermAndConditionCommand>().ReverseMap();
            CreateMap<TermAndCondition, TermAndConditionDto>().ReverseMap();
            CreateMap<TermAndCondition, TermAndConditionListVM>().ReverseMap();

            //
            // Dynamic Attribute..
            //

            // Create..
            CreateMap<DynamicAttribute, CreateDynamicAttributeCommand>().ReverseMap();
            CreateMap<GeneralValidation, CreateGeneralValidation>().ReverseMap();
            CreateMap<Dependency, CreateDependency>().ReverseMap();
            CreateMap<DependencyValidation, CreateDependencyValidation>().ReverseMap();
            CreateMap<DynamicAttributeSection, CreateDynamicAttributeSectionCommand>().ReverseMap();

            // Update..
            CreateMap<DynamicAttributeSection, UpdateDynamicAttributeSectionCommand>().ReverseMap();
            CreateMap<DynamicAttribute, UpdateDynamicAttributeCommand>().ReverseMap();
            CreateMap<DynamicAttributeListValue, UpdateDynamicAttributeListValueCommand>().ReverseMap();

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
        }
    }
}
