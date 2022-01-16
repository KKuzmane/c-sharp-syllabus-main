using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    public class Date
    {
        private int _month;
        private int _year;
        private int _day;

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public int Month(int month)
        {
            if(month > 0 && month <= 12)
            {
                _month = month;
            }
            else
            {
                _month = 0;
            }
            return _month;
        }
        public int Day(int day)
        {
            if(day > 0 && day <= 31)
            {
                _day = day;
            }
            else
            {
                _day = 0;
            }
            return _day;
        }

        public int Year(int year)
        {
            _year = year;
            return _year;
        }

        public string DisplayDate()
        {
            return $"{_day}/{_month}/{_year}";
        }
    }
}
