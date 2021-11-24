using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qz17
{
    class Program
    {
		public static void Main()
		{
			BankAccount acc1 = new BankAccount();
			BankAccount acc2 = new BankAccount();
			acc1.GiveInfo();



		}
		class BankAccount
		{
			private int idAccount;
			private double balance;
			private string name;

			public void GiveInfo()
			{
				int IdAccount = Convert.ToInt32(Console.ReadLine());
				double Balance = Convert.ToDouble(Console.ReadLine());
				string Name = Console.ReadLine();
			}
			public void GetInfo()
			{
				Console.WriteLine();
			}

			public IdAccount
		{
			set
			{
					idAccount = value;
			}
		get
			{
			return idAccount;
			}
}

public double Balance
{
	set
	{
		if (value >= 0)
		{
			balance = value;
		}
		else
		{
			Console.WriteLine("Баланс не может быть отрицательным");
		}
	}
	get
	{
		return balance;
	}
}

public string Name
{
	set
	{
		name = value;
	}
	get
	{
		return name;
	}
}
	}
}
