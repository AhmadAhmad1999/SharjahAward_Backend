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
using SharijhaAward.Domain.Model.IdentityModels;


namespace SharijhaAward.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.EventModel.Event , CreateEventDto>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event , CreateEventCommand>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event , UpdateEventCommand>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event , EventListVM>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event , EventDto>().ReverseMap();
            CreateMap<Domain.Entities.EventModel.Event , EventInviteesVM>().ReverseMap();

            CreateMap<PersonalInvitee , CreatePersonalInviteeCommand>().ReverseMap();
            CreateMap<PersonalInvitee , UpdatePersonalInviteeCommand>().ReverseMap();
            CreateMap<PersonalInvitee , DeletePersonalInviteeCommand>().ReverseMap();
            CreateMap<PersonalInvitee , PersonalInviteeVM>().ReverseMap();
            CreateMap<PersonalInvitee , PersonalInviteeListVM>().ReverseMap();
            CreateMap<PersonalInvitee , EventInvitessDto>().ReverseMap();
            CreateMap<PersonalInvitee , ConfirmAttendancePersonalQuery>().ReverseMap();

            CreateMap<GroupInvitee , CreateGroupInviteeCommand>().ReverseMap();
            CreateMap<GroupInvitee , DeleteGroupInviteeCommand>().ReverseMap();
            CreateMap<GroupInvitee , UpdateGroupInviteeCommand>().ReverseMap();    
            CreateMap<GroupInvitee , GroupInviteeListVM>().ReverseMap();
            CreateMap<GroupInvitee , GroupInviteeVM>().ReverseMap();
            CreateMap<GroupInvitee , ConfirmAttendanceGroupQuery>();

            CreateMap<User , LoginCommand>();
            CreateMap<User , SignUpCommand>().ReverseMap();
        }
    }
}
