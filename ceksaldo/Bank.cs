using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceksaldo
{
	public class Bank
	{
		public class BankAccount : Bank
		{
			List<double> DepositList = new List<double>();
			//object[] DepositArr = new object[6];
			public string username { get; set; }

			public double Balance { get; set; }

			public BankAccount(string username, double Balance)
			{
				this.username = username;
				this.Balance = Balance;

				Console.WriteLine("Username: {0} , Balance: {1}", username, Balance);
			}
		}
	}
}
