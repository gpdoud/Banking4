using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking4 {

	class Program {

		static void Main(string[] args) {

			//Account a1 = new Account("acct1", "First Account");
			//a1.Deposit(1000);
			//a1.Withdraw(200);
			//Console.WriteLine($"{a1.Description} balance is {a1.GetBalance()}");
			//a1.Deposit(-100);
			//a1.Withdraw(-100);
			//Console.WriteLine($"{a1.Description} balance is {a1.GetBalance()}");
			//a1.Balance = 10000;

			Savings s1 = new Savings("sav1", "First Savings");
			s1.Deposit(1000);
			Console.WriteLine($"{s1.Description} balance is {s1.GetBalance()}");
			s1.CalcInterest(12);
			Console.WriteLine($"{s1.Description} balance is {s1.GetBalance()}");

			Checking c1 = new Checking("chk1", "First Checking");
			c1.Deposit(1000);
			c1.WriteCheck("Denise", 100);


			List<Account> accounts = new List<Account> { c1, s1 };
			decimal totalAllAccounts = 0;
			foreach (Account account in accounts) {
				totalAllAccounts += account.GetBalance();
			}
		}
	}
}
