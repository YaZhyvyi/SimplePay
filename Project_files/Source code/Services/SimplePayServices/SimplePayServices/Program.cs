using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Net;
using System.ServiceModel.Description;
using SimplePayServices.Realization;

namespace SimplePayServices
{

    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(PayOperations));

            host.Open();
            Console.WriteLine("Service started...");

            Console.ReadLine();

            host.Close();

        }
    }
}
