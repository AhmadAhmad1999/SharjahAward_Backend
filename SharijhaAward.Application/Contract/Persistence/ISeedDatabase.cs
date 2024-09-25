using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Persistence
{
    public interface ISeedDatabase
    {
        Task Initialize(IServiceProvider serviceProvider);
    }
}
