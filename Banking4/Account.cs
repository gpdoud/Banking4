using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking4 {

	abstract class Account {

		public string AccountNbr { get;  private set; }
		public string Description { get; set; }
		public decimal Balance { get;  private set; }

		public void Deposit(decimal Amount) {
			if(Amount <=0) {
				Console.WriteLine("Amount must be GT zero");
				return;
			}
			Balance += Amount;
		}

		public void Withdraw(decimal Amount) {
			if (Amount <= 0) {
				Console.WriteLine("Amount must be GT zero");
				return;
			}
			if(Amount > Balance) {
				Console.WriteLine("Amount must be LTE Balance");
				return;
			}
			Balance -= Amount;
		}

		public decimal GetBalance() {
			return Decimal.Round(Balance, 2);
		}

		public Account(string AccountNbr, string Description) {
			this.AccountNbr = AccountNbr;
			this.Description = Description;
			this.Balance = 0.0M;
		}

		public Account() {

		}
	}
}
