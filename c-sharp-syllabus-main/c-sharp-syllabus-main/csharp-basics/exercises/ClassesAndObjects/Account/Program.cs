using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account bartosAccount = new Account("Barto's account", 100.00);
            Account mattsAccount = new Account("Matt's account", 1000.00);
            Account myAccount = new Account("My account", 0);
            Account mySecondAccount = new Account("My second account", 0);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount.ToString());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Initial state");
            Console.WriteLine(mattsAccount.ToString());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Initial state");
            Console.WriteLine(myAccount.ToString());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Initial state");
            Console.WriteLine(mySecondAccount.ToString());
            Console.WriteLine("-----------------------------------");

            bartosAccount.Deposit(20);
            Transfer(mattsAccount, myAccount, 50);
            Transfer(myAccount, mySecondAccount, 25);

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);
            Console.WriteLine(mySecondAccount);
            Console.WriteLine("-----------------------------------");

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.Deposit(howMuch);
            from.Withdrawal(howMuch);
        }
    }
}