using SharijhaAward.Domain.Model.ArbitratorModel;
using SharijhaAward.Domain.Model.InterviewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.ArbitratorInterviewModel
{
    public class ArbitratorInterview
    {
        public  int  Id { get; set; }

        public Arbitrator Arbitrator { get; set; } = null!;

        [ForeignKey(nameof(Arbitrator))]
        public Guid ArbitratorId {  get; set; }

        public Interview Interview { get; set; } = null!;

        [ForeignKey(nameof(Interview))]
        public Guid InterviewId { get; set;}
    }
}
