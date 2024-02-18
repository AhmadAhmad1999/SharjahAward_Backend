﻿using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AgendaConstants;
using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.AgendaModel; 

public class Agenda : AuditableEntity
{
    public Guid Id { get; set; }
    // the arabic title of the agenda 
    public string ArabicTitle { get; set; } = string.Empty;
    // the english title of the agenda
    public string EnglishTitle { get; set; } = string.Empty;
    // the icon of the agenda 
    public string Icon { get; set; } = string.Empty;
    // type of the agenda 
    public AgendaDateType Type { get; set; }
    // the DateTime of the agenda 
    public DateTime Date { get; set; }
    // slug to the agenda indicate the type of the agenda 
    public AgendaSlug Slug { get; set; } = AgendaSlug.Undefined;
    // arabic note
    public string? ArabicNote { get; set; }
    // english note
    public string? EnglishNote { get; set; }
    // navigation property for the cycle model 
    public Guid CycleId { get; set; }
    public Cycle Cycle { get; set; } = null!;
}