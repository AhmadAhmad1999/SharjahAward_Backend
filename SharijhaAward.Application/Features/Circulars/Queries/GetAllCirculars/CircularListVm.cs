using SharijhaAward.Application.Features.Circulars.Queries.GetCircularById;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars
{
    public class CircularListVm
    {
        public List<CircularDto>? Circulars { get; set; }
        public int? NumberOfUnRead { get; set; }
    }
}
