using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.InterviewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ArbitratorInterviewModel
{
    public class ArbitratorInterview
    {
        public  int  Id { get; set; }

        public Arbitrator Arbitrator { get; set; } = null!;

        [ForeignKey(nameof(Arbitrator))]
        public int ArbitratorId {  get; set; }

        public Interview Interview { get; set; } = null!;

        [ForeignKey(nameof(Interview))]
        public int InterviewId { get; set;}
    }
}
