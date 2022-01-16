using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, string>();
        }

        private bool Find(string name)
        {
            return _data.ContainsKey(name);
        }

        public string GetNumber(string name)
        {
            if (!Find(name))
            {
                return null;
            }

            return _data[name];

        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            _data.Add(name, number);

        }
    }
}