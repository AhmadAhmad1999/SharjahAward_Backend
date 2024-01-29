﻿using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Model.CategoryModel;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;

namespace SharijhaAward.Domain.Model.FAQModel; 

public class FrequentlyAskedQuestion : AuditInformation<User> {
    public Guid Id { get; set; }
    // the arabic question 
    public string ArabicQuestion { get; set; } = string.Empty;
    // the english question
    public string EnglishQuestion { get; set; } = string.Empty;
    // the arabic answer
    public string ArabicAnswer { get; set; } = string.Empty;
    // the english answer 
    public string EnglishAnswer { get; set; } = string.Empty;
    
    
    // navigation property to the category
    [ForeignKey(nameof(Category))]
    public Guid  CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}