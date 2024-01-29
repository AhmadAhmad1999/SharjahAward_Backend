using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.MeetingUserModel;
using SharijhaAward.Domain.Model.NoteModel;
using ErrorOr;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SharijhaAward.Domain.Model.IdentityModels;


public class User {

    public Guid Id { get; set; } 
    public string ArabicName { get; set; } = string.Empty;
    public string EnglishName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Gender Gender { get; set; }

    public virtual List<MeetingUser> MeetingUsers { get; set; } = null!;

    public virtual List<Note> Notes { get; set; } = null!;
}