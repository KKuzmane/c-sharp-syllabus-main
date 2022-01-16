using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaLozaWoza
{
    public class CozaLozaWoza
    {
        private List<string> _list = new List<string>();

        public List<string> CreateArrays(int input)
        {
            int j = 1;

            while (j <= input)
            {
                if ((j % 3 == 0) && (j % 5 == 0) && (j % 7 == 0))
                {
                    _list.Add("CozaLozaWoza");
                }
                else if ((j % 3 == 0) && (j % 5 == 0))
                {
                    _list.Add("CozaLoza");
                }
                else if ((j % 5 == 0) && (j % 7 == 0))
                {
                    _list.Add("LozaWoza");
                }
                else if ((j % 3 == 0) && (j % 7 == 0))
                {
                    _list.Add("CozaWoza");
                }
                else if (j % 3 == 0)
                {
                    _list.Add("Coza");
                }
                else if (j % 5 == 0)
                {
                    _list.Add("Loza");
                }
                else if (j % 7 == 0)
                {
                    _list.Add("Woza");
                }
                else
                {
                    _list.Add(j.ToString());
                }

                j++;
            }
            return _list;
        }
    }
}
