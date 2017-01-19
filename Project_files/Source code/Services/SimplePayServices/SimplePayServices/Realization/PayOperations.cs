using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplePayServices.DateObjects;
using SimplePayServices.Interface;

namespace SimplePayServices.Realization
{
    public class PayOperations : IPayOperations
    {
        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public void LogIn(string usename, string password)
        {
            throw new NotImplementedException();
        }

        public void Refill(Account account, Currency currency, double amount)
        {
            throw new NotImplementedException();
        }

        public void Register(string name, string surname, string username, string password, string age, string card)
        {
            throw new NotImplementedException();
        }

        public CurrencyForDate SetCurrencyForDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Account> ShowUserAccount(User user)
        {
            throw new NotImplementedException();
        }

        public List<Account> TheUserHistory(User user)
        {
            throw new NotImplementedException();
        }

        public void Transfer(Account fromAccount, Account toAccount, double amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(Account account, Currency currency, double amount)
        {
            throw new NotImplementedException();
        }
    }
}
