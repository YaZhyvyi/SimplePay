
using SimplePay.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICurrencyRepo
    {
        IEnumerable<Currency> GetAll();
        void Add(Currency currency);
        void Edit(Currency currency);
        void Delete(Currency currency);

        Currency SelectById(int id);
        Currency SelectByShortName(string ShortName);

    }
}
