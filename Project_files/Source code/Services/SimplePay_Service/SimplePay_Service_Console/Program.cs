using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization;

namespace SimplePay_Service_Console
{
	[ServiceContract]
	public interface IService
	{
		[OperationContract]
		void Register(string name, string surname, string username, string password, string age, string card);
		[OperationContract]
		void LogIn(string usename, string password);
		[OperationContract]
		void Transfer(string card1, string card2, string amount);
		[OperationContract]
		void Add(string card, string currency, int amount);
		[OperationContract]
		void Withdraw(string card, string currency, int amount);
	}

	[ServiceBehavior]
	public class Service_Class : IService
	{
		public void Add(string card, string currency, int amount)
		{

		}

		public void LogIn(string usename, string password)
		{

		}

		public void Register(string name, string surname, string username, string password, string age, string card)
		{

		}

		public void Transfer(string card1, string card2, string amount)
		{

		}

		public void Withdraw(string card, string currency, int amount)
		{

		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			ServiceHost host = new ServiceHost(typeof(Service_Class));

			host.Open();
			Console.WriteLine("[Enter] to close this service..");
			Console.ReadLine();
			host.Close();
		}
	}
}
