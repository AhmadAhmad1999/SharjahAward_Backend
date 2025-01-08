using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.ReorderPages
{
    public class ReorderPagesCommand : IRequest<BaseResponse<object>>
    {
        public List<ReorderPagesSubCommand> InsideCells { get; set; } = new List<ReorderPagesSubCommand>();
        public List<ReorderPagesSubCommand> OutsideCells { get; set; } = new List<ReorderPagesSubCommand>();
        public string? lang { get; set; }

        public bool ValidateUniqueness(out string ErrorMessage)
        {
            ErrorMessage = string.Empty;

            if (InsideCells.Count() != 5)
            {
                ErrorMessage = lang == "en"
                    ? "Main pages's count must be 5 pages only."
                    : "يجب أن يكون عدد الصفحات الرئيسية 5 صفحات فقط.";

                return false;
            }

            if (InsideCells.GroupBy(x => x.Id).Any(g => g.Count() > 1))
            {
                ErrorMessage = lang == "en"
                    ? "Duplicate Id found in InsideCells."
                    : "تم العثور على معرف الطلب المكرر داخل الخلايا.";
                return false;
            }

            if (InsideCells.GroupBy(x => x.OrderId).Any(g => g.Count() > 1))
            {
                ErrorMessage = lang == "en"
                    ? "Duplicate OrderId found in InsideCells."
                    : "تم العثور على معرف الطلب المكرر داخل الخلايا.";
                
                return false;
            }

            if (OutsideCells.GroupBy(x => x.Id).Any(g => g.Count() > 1))
            {
                ErrorMessage = lang == "en"
                    ? "Duplicate Id found in OutsideCells."
                    : "تم العثور على معرف مكرر في الخلايا الخارجية.";

                return false;
            }

            if (OutsideCells.GroupBy(x => x.OrderId).Any(g => g.Count() > 1))
            {
                ErrorMessage = lang == "en"
                    ? "Duplicate OrderId found in OutsideCells."
                    : "تم العثور على معرف الطلب المكرر في الخلايا الخارجية.";

                return false;
            }

            return true;
        }
    }
}
