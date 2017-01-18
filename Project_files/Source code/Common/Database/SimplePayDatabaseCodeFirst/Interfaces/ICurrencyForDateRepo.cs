
using SimplePay.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICurrencyForDateRepo
    {
        IEnumerable<CurrencyForDate> GetAll();
        void Add(CurrencyForDate currency);

        CurrencyForDate SelectByDate(DateTime date);
    }
}
