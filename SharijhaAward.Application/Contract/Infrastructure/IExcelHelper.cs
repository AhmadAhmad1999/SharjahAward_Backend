using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Infrastructure
{
    public interface IExcelHelper<T> where T : class
    {
        public byte[] ExportToExcel (List<T> data);
    }
}
