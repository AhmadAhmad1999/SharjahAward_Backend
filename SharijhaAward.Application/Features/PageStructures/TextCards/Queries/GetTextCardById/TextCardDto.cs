using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetTextCardById
{
    public class TextCardDto
    {
        public int Id { get; set; }
        public string EnglishContent { get; set; } = string.Empty;
        public string ArabicContent { get; set; } = string.Empty;
        public CardType CardType { get; set; }
        public int orderId { get; set; }
        public int PageStructureId { get; set; }

    }
}
