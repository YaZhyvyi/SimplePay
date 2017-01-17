using DatabaseLibrary.Context;
using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = DatabaseLibrary.DataModels;

namespace Repositories
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public IEnumerable<Entities.Currency> GetAll()
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

        public void Add(Entities.Currency currency)
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

        public void Edit(Entities.Currency currency)
        {
            using (var db = new SPContext())
            {
                Models.Currency currToEdit = db.Currencies.FirstOrDefault(c => c.ID == currency.ID);
                currToEdit.ShortName = currency.ShortName;
                currToEdit.FullName = currency.FullName;

                db.SaveChanges();
            }
        }

        public void Delete(Entities.Currency currency)
        {
            using (var db = new SPContext())
            {
                Models.Currency currToDelete = db.Currencies.FirstOrDefault(c => c.ID == currency.ID);
                db.Currencies.Remove(currToDelete);
                db.SaveChanges();
            }
        }


        public Entities.Currency SelectById(int id)
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
    }
}
