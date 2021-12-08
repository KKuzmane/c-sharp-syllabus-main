using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class SavingsAccount
    {
        private double _startingBalance;
        private double _interestRate;
        private double _deposit;
        private double _withdrawn;
        private double _interestEarnedMonthly;
        private double _balance;

        public SavingsAccount(double startingBalance, double interestRate, double deposit,  double withdraw, double interestEarnedMonthly)
        {
            _startingBalance = startingBalance;
            _interestRate = interestRate;
            _deposit = deposit;
            _withdrawn = withdraw;
            _interestEarnedMonthly = interestEarnedMonthly;
        }

        public double ReturnStartingBalance()
        {
            return _startingBalance;
        }

        public double ReturnInterestRate()
        {
            return _interestRate;
        }

        public double ReturnDeposit()
        {
            return Math.Round(_balance, 2);
        }

        public double ReturnWithdrawe()
        {
            return Math.Round(_withdrawn, 2);
        }

        public void MonthDeposite(double deposit)
        {
            _balance += deposit;
        }

        public void MonthWithdrawn(double withdrawn)
        {
            _withdrawn += withdrawn;
        }
        public void StartingBalance(double startingBalance)
        {
            _startingBalance = startingBalance;
        }
        public void InterestRate(double interestRate)
        {
            _interestRate = interestRate;
        }

        public double InterestEarned()
        {
            double monthlyInterestRate = _interestRate / 12;
            _interestEarnedMonthly = Math.Round(((monthlyInterestRate * _balance) + _balance), 2);
            return _interestEarnedMonthly;
        }
        public double EndingBalance()
        {
            double endingBalance = _balance + _interestEarnedMonthly - _withdrawn;

            return endingBalance;
        }
        public void Balance()
        {
            _balance = _startingBalance + _deposit;
        }
    }
}
