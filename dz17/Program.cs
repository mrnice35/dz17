using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.NumberAccount = 213;
            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.NumberAccount = "24554353";
            bankAccount1.GetInfo<int>();
            bankAccount1.Info();
            bankAccount2.GetInfo<string>();
            bankAccount2.Info();
            Console.ReadKey();
            /* Console.WriteLine("Введите номер счета");
             bankAccount1.NumberAccount = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите ФИО клиента");
             bankAccount1.FullName = Console.ReadLine();
             Console.WriteLine("Введите баланс клиента");
             bankAccount1.Balance = Convert.ToInt32(Console.ReadLine());
             bankAccount1.Info();


             BankAccount<string> bankAccount2 = new BankAccount<string>();
             bankAccount2.NumberAccount = "456";
             bankAccount2.FullName = "Петр Петрович Петров";
             bankAccount2.Balance = 5678;
             bankAccount2.Info();
             Console.ReadKey();*/



        }
    }
    class BankAccount<T>// создаем класс банковского счета
    {
        private T numberAccount;//закрытые поля номер счета
        private string fullName;//Полное имя
        private double balance;//баланс
        public T NumberAccount
        {
            set
            {
                numberAccount = value;
            }
            get
            {
                return numberAccount;
            }
        }
        public string FullName
        {
            set
            {
                fullName = value;
            }
            get
            {
                return fullName;
            }
        }
        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }

    
        public void Info()
        {
            Console.WriteLine("номер счета {0}\nФИО клиента {1}\nБаланс счета {2}", NumberAccount, FullName, balance);
        }
        public void GetInfo<U>()
        {
            Console.WriteLine("Введите ФИО клиента");
            FullName = Console.ReadLine();
            Console.WriteLine("Введите баланс клиента");
            Balance = Convert.ToInt32(Console.ReadLine());

        }
    }
}

