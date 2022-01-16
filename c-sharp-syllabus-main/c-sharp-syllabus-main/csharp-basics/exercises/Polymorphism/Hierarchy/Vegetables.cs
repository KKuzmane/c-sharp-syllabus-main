using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Vegetables : Food
    {
        public Vegetables(int quantity) : base(quantity)
        {
        }

        public override string ToString()
        {
            return $"Vegetables {_quantity}";
        }
    }
}
