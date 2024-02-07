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

            CreateMap<PersonalInvitee, CreatePersonalInviteeCommand>().ReverseMap();
            CreateMap<PersonalInvitee, UpdatePersonalInviteeCommand>().ReverseMap();
            CreateMap<PersonalInvitee, DeletePersonalInviteeCommand>().ReverseMap();
            CreateMap<PersonalInvitee, PersonalInviteeVM>().ReverseMap();
            CreateMap<PersonalInvitee, PersonalInviteeListVM>().ReverseMap();
            CreateMap<PersonalInvitee, EventInvitessDto>().ReverseMap();
            CreateMap<PersonalInvitee, ConfirmAttendancePersonalQuery>().ReverseMap();
            CreateMap<PersonalInvitee, PersonalDto >().ReverseMap();

            CreateMap<GroupInvitee, CreateGroupInviteeCommand>().ReverseMap();
            CreateMap<GroupInvitee, DeleteGroupInviteeCommand>().ReverseMap();
            CreateMap<GroupInvitee, UpdateGroupInviteeCommand>().ReverseMap();    
            CreateMap<GroupInvitee, GroupInviteeListVM>().ReverseMap();
            CreateMap<GroupInvitee, GroupInviteeVM>().ReverseMap();
            CreateMap<GroupInvitee, ConfirmAttendanceGroupQuery>();
            CreateMap<GroupInvitee, GroupDto>().ReverseMap();

            CreateMap<User, LoginCommand>().ReverseMap();
            CreateMap<User, SignUpCommand>().ReverseMap();
            CreateMap<User, UpdateEventCommand>();
            CreateMap<User, DeleteUserCommand>();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserListVm>().ReverseMap();
            CreateMap<User, AsignRoleToUserQuery>();

            CreateMap<Role, RoleListVm>().ReverseMap();

            CreateMap<ProvidedForm, CreateProvidedFormCommand>();

            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, UpdateEventCommand>();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListVM>().ReverseMap();
        }
    }
}
