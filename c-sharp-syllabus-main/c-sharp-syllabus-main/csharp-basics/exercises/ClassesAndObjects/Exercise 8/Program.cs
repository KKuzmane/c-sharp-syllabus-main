using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount account = new SavingsAccount(0, 0, 0, 0, 0);
            Console.Write("How much money is in the account? ");
            double startingBalance = double.Parse(Console.ReadLine());
            account.StartingBalance(startingBalance);
            account.Balance();
            Console.Write("Enter annual interest rate: ");
            double interestRate = double.Parse(Console.ReadLine());
            account.InterestRate(interestRate);
            Console.Write("How long has the account been opened? ");
            double months = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for(int i = 0; i < months; i++)
            {
                Console.Write($"Enter amount deposited for month: {i+1}: ");
                int deposit = int.Parse(Console.ReadLine());
                account.MonthDeposite(deposit);
                Console.Write($"Enter amount withdrawn for {i + 1}: ");
                int withdrawn = int.Parse(Console.ReadLine());
                account.MonthWithdrawn(withdrawn);
                account.InterestEarned();
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine($"Total deposited: ${account.ReturnDeposit()}");
            Console.WriteLine($"Total withdrawn: ${account.ReturnWithdrawe()}");
            Console.WriteLine($"Interest earned: ${account.InterestEarned()}");
            Console.WriteLine($"Ending balance: ${account.EndingBalance()}");

            Console.ReadKey();

        }
    }
}
