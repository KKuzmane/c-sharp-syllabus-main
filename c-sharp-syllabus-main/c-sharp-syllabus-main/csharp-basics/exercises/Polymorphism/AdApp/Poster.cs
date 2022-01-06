using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    internal class Poster : Advert
    {
        private int _numberOfCopies;
        private int _costPerCopy;

        public Poster(int fee, int numberOfCopies, int costPerCopy) : base(fee)
        {
            _numberOfCopies = numberOfCopies;
            _costPerCopy = costPerCopy;
        }

        public override int Cost()
        {
            return _numberOfCopies * _costPerCopy + _fee;
        }
    }
}
