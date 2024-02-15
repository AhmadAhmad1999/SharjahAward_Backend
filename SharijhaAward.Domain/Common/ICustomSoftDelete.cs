using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Common
{
    public interface ICustomSoftDelete
    {
        public bool isDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
