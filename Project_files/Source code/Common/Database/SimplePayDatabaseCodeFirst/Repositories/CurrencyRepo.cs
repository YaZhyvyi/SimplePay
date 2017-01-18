using DatabaseLibrary.Context;
using Interfaces;
using SimplePay.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Models = DatabaseLibrary.DataModels;

namespace Repositories
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public IEnumerable<Currency> GetAll()
        {
            using (var db = new SPContext())
            {
                return db.Currencies.Select(c => new Currency
                {
                    ID = c.ID,
                    ShortName = c.ShortName,
                    FullName = c.FullName
                }).ToList();
            }
        }

        public void Add(Currency currency)
        {
            using (var db = new SPContext())
            {
                Models.Currency currToAdd = new Models.Currency()
                {
                    ShortName = currency.ShortName,
                    FullName = currency.FullName
                };
                db.Currencies.Add(currToAdd);

                db.SaveChanges();
            }
        }

        public void Edit(Currency currency)
        {
            using (var db = new SPContext())
            {
                Models.Currency currToEdit = db.Currencies.FirstOrDefault(c => c.ID == currency.ID);
                currToEdit.ShortName = currency.ShortName;
                currToEdit.FullName = currency.FullName;

                db.SaveChanges();
            }
        }

        public void Delete(Currency currency)
        {
            using (var db = new SPContext())
            {
                Models.Currency currToDelete = db.Currencies.FirstOrDefault(c => c.ID == currency.ID);
                db.Currencies.Remove(currToDelete);
                db.SaveChanges();
            }
        }

        //public IEnumerable<Currency> FilterCurrencies(Expression<Func<Account, bool>> match)
        //{
        //    using (var db = new SPContext())
        //    {
        //        return db.Currencies..Where(match).ToList();
        //    }
        //}

        public Currency SelectById(int id)
        {
            using (var db = new SPContext())
            {
                Models.Currency findCurr = db.Currencies.FirstOrDefault(c => c.ID == id);
                return new Currency()
                { 
                    ID = findCurr.ID,  
                    ShortName = findCurr.ShortName,
                    FullName = findCurr.FullName
                };
            }
        }


        public Currency SelectByShortName(string ShortName)
        {
            using (var db = new SPContext())
            {
                Models.Currency findCurr = db.Currencies.FirstOrDefault(c => c.ShortName == ShortName);
                return new Currency()
                {
                    ID = findCurr.ID,
                    ShortName = findCurr.ShortName,
                    FullName = findCurr.FullName
                };
            }
        }
    }
}
