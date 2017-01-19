using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Net;
using System.ServiceModel.Description;
using SimplePayServices.DateObjects;


namespace SimplePayServices.Interface
{
    public interface IPayOperations
    {
        [OperationContract]
        void Register(string name, string surname, string username, string password, string age, string card);
        [OperationContract]
        void LogIn(string usename, string password);

        // user function
        [OperationContract]
        List<Account> ShowUserAccount(User user); // список акаунтів певного користувача
        [OperationContract]
        void Transfer(Account fromAccount, Account toAccount, double amount); // переказ коштів іншому користувачу
        [OperationContract]
        void Refill(Account account, Currency currency, double amount); //поповнення рахунку
        [OperationContract]
        void Withdraw(Account account, Currency currency, double amount); // зняття коштів з рахунку


        // admin function    
        [OperationContract]
        List<User> GetAllUsers();  // перегляд списку користувачів
        [OperationContract]
        List<Account> TheUserHistory(User user);  // перегляд історії по користувачу
        [OperationContract]
        CurrencyForDate SetCurrencyForDate(DateTime date); //встановлення поточного рахунку на день
        
    }
}
}
