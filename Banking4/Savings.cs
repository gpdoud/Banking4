using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking4 {
	class Savings : Account {

		public decimal IntRate { get; set; }

		public void CalcInterest(int months) {
			decimal monthlyIntRate = IntRate / 12;
			decimal interest = GetBalance() * monthlyIntRate * months;
			Deposit(interest);
		}

		public Savings(string AccountNbr, string Description) : base(AccountNbr, Description) {
			this.IntRate = 0.02M;

		}
	}
}
