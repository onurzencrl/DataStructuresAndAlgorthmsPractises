using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorthmsPractises
{
    internal class Recursive
    {
        public Recursive()
        {
            int[] numbers = new int[] { 1, 5, 7, 9, 10 };
            var index = FindIndex_Iteration(numbers, 7, 1);
            var indexForRecursive = FindIndex_Recursive(numbers, 7, 1);

        }
        //Recursive Methods 

        //Kendi kendini çağıran yinelenen 




        //Iteration Metodu 
        int FindIndex_Iteration(int[] numbers, int value, int startIndex)
        {
            for (int i = startIndex; i < numbers.Length - startIndex; i++)
            {
                if (numbers[i] == value)
                    return i;
            }
            return -1;
        }

        //Recursive Metot 
        //indexForRecursive 'i 3 aşamada ele alırız
        int FindIndex_Recursive(int[] numbers, int value, int startIndex)
        {
            //bir şartımız olmalı  Exit Condition
            if (startIndex >= numbers.Length)
                return -1;

            //  Actual process gerçekten işlemin yapıldığı alan
            if (numbers[startIndex] == value)
                return startIndex;
            // re-calling
            return FindIndex_Recursive(numbers, value, startIndex + 1);

        }
    }
}
