
using SimplePay.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAccountRepo
    {
        IEnumerable<Account> GetAll();
        void Add(Account currency);
        IEnumerable<Account> FilterAccounts(Expression<Func<Account, bool>> match, int pageIndex, int pageSize);
    }
}
