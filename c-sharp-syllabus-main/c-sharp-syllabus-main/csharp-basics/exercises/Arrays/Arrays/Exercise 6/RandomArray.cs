using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    public class RandomArray
    {
        public int[] RandomNumbers()
        {
            int[] RandomNums = new int[10];

            Random number = new Random();

            for (int i = 0; i < RandomNums.Length; i++)
            {
                RandomNums[i] = number.Next(1, 101);
            }

            return RandomNums;
        }

        public int[] RandomNumberCopy(int[] array)
        {
            int[] NewArray = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                NewArray[i] = array[i];
            }
            return NewArray;
        }
        
        public string PrintFirstArray(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (j == array.Length - 1)
                {
                    array[j] = -7;
                }
            }
            
            return String.Join(" ", array);
        }

        public string PrintSecondArray(int[] array)
        {
            return String.Join(" ", array);
        }
    }
}
