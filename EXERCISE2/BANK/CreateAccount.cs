using System;

namespace ITMO.CSCourse
{
	class CreateAccount
	{
		static void Main()
		{
			Console.WriteLine("Sid's Account");
			long sidsAccNo = Banking.Bank.CreateAccount();
			Banking.BankAccount sids = Banking.Bank.GetAccount(sidsAccNo);
			TestDeposit(sids);
			TestWithdraw(sids);
			Write(sids);
			if (Banking.Bank.CloseAccount(sidsAccNo))
				Console.WriteLine("Account closed");
			else
				Console.WriteLine("Something went wrong closing the account");

		}


		static void TestDeposit(Banking.BankAccount acc)
		{
			Console.Write("Enter amount to deposit: ");
			decimal amount = decimal.Parse(Console.ReadLine());
			acc.Deposit(amount);
		}

		static void TestWithdraw(Banking.BankAccount acc)
		{
			Console.Write("Enter amount to withdraw: ");
			decimal amount = decimal.Parse(Console.ReadLine());
			acc.Withdraw(amount);
		}

		static void Write(Banking.BankAccount acc)
		{
			Console.WriteLine("Account number is {0}", acc.Number());
			Console.WriteLine("Account balance is {0}", acc.Balance());
			Console.WriteLine("Account type is {0}", acc.Type());
			Console.WriteLine("Transactions:");
			foreach (Banking.BankTransaction tran in acc.Transactions())
			{
				Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
			}
			Console.WriteLine();
		}

	}
}