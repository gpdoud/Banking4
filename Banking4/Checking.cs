using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking4 {

	class Checking : Account {

		public int NextCheckNbr { get; set; } = 1;

		public void WriteCheck(string Payee, decimal Amount) {
			int CheckNbr = NextCheckNbr++;
			Withdraw(Amount);
		}

		public Checking(string AccountNbr, string Description) 
			: base(AccountNbr, Description) {

		}
	}
}
