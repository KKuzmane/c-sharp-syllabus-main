using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Student : Person
    {
        private double _gpa;

        public Student(string firstName, string lastName, string address, int id, double gpa) : base (firstName, lastName, address, id)
        {
            _gpa = gpa;
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Gpa: {_gpa}");
        }
    }
}