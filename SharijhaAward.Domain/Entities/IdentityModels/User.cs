﻿using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.MeetingUserModel;
using SharijhaAward.Domain.Entities.NoteModel;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels;
public class User : AuditableEntity  {

    public Guid Id { get; set; } 
    public string ArabicName { get; set; } = string.Empty;
    public string EnglishName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public string PhoneNumber { get; set; } = null!;
    public Role? Role { get; set; }
    [ForeignKey(nameof(Role))]
    public Guid? RoleId { get; set; }
    public int? ConfirmationCode { get; set; }
    public virtual List<MeetingUser> MeetingUsers { get; set; } = null!;
    public virtual List<Note> Notes { get; set; } = null!;
}