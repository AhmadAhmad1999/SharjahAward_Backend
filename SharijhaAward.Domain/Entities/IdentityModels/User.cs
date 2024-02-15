using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.MeetingUserModel;
using SharijhaAward.Domain.Entities.NoteModel;
using ErrorOr;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SharijhaAward.Domain.Entities.IdentityModels;


public class User  {

    public Guid Id { get; set; } 
    public string ArabicName { get; set; } = string.Empty;
    public string EnglishName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public bool IsDelete { get; set; }
    public Role? Role { get; set; }

    [ForeignKey(nameof(Role))]
    public Guid? RoleId { get; set; }
    public virtual List<MeetingUser> MeetingUsers { get; set; } = null!;

    public virtual List<Note> Notes { get; set; } = null!;
}