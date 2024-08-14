using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetFormStatusById
{
    public class GetFormStatusByIdDto
    {
        public int FormId { get; set; }
        public FormStatus isAccepted { get; set; }
        public FormStatus isAcceptedFromChairman { get; set; }
    }
}
