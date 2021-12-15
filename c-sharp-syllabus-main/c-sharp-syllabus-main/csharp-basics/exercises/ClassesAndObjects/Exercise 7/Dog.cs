using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Dog
    {
        string _name;
        string _sex;
        string _mother;
        string _father;

        public Dog(string name, string sex, string mother, string father)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }
        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
            _mother = "unknown";
            _father = "unknown";
        }

        public string ReturnName()
        {
            return _name;
        }
        public string ReturnFather()
        {
            return _father;
        }
        public string ReturnMother()
        {
            return _mother;
        }
        public bool HasSameMotherAs(Dog otherDog)
        {
            return this._mother == otherDog._mother;
        }
    }
}
