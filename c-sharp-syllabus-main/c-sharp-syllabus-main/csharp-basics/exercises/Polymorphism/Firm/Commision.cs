using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    internal class Commision : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commision(string name, string address, string phone, string socSecNumber, double rate, double commissionRate) : base(name, address, phone, socSecNumber, rate)
        {
            _totalSales = 0;
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales * _commissionRate;
        }
    }
}
