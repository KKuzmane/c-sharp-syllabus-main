using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Person 
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person(string firstName, string lastName, string address, int id) 
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine($"First name: {_firstName}");
            Console.WriteLine($"Last name: {_lastName}");
            Console.WriteLine($"Address: {_address}");
            Console.WriteLine($"ID: {_id}");
        }
    }
}
