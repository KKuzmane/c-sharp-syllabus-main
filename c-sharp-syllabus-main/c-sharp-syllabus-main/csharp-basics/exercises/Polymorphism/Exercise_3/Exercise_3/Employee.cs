﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Employee : Person
    {
        private string _jobTitle;

        public Employee (string firstName, string lastName, string address, int id, string jobTitle) : base (firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public string JobTitle
        {
            get { return _jobTitle;}
            set { _jobTitle = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Job title: {_jobTitle}");
        }
    }
}
