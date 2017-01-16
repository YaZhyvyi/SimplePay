using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new SPContext())
            {
                Currency c1 = new Currency() { ShortName = "UAH", FullName = "UkraineMoney" };
                Currency c2 = new Currency() { ShortName = "USD", FullName = "USAMoney" };


                db.Currencies.Add(c1);
                db.Currencies.Add(c2);
                db.SaveChanges();

                foreach(var c in db.Currencies)
                {
                    Console.WriteLine("{0} ({1})", c.FullName, c.ShortName);
                }
            }

            Console.Read();
        }
    }
}
