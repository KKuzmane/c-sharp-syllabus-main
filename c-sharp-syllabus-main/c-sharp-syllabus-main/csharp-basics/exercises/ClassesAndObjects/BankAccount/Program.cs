using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        private string _accountName;
        private double _balance;

        private Program(string accountName, double balance)
        {
            _accountName = accountName;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance >= 0)
            {
                return $"{_accountName}, ${String.Format("{0:0.00}", _balance)}";
            }
            else
            {
                return $"{_accountName}, -${String.Format("{0:0.00}", (_balance * -1))}";
            }
        }

        static void Main(string[] args)
        {
            Program benson = new Program("Benson", -17.5);
            Console.WriteLine(benson.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }
}
