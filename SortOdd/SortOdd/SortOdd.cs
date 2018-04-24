using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOdd
{
    class SortOdd
    {
        static void Main(string[] args)
        {
            int[] data = new[] {5, 3, 2, 8, 1, 4};
            SortArray(data);
        }

        //sortArray([5, 3, 2, 8, 1, 4]) == [1, 3, 2, 8, 5, 4]
        public static int[] SortArray(int[] intArray)
        {
            if (intArray.Length == 0)
                return new int[]{};

            List<int> tempOdd = intArray.Where(t => t % 2 == 1).ToList();
            tempOdd.Sort();

            int oddIndex = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 1)
                {
                    intArray[i] = tempOdd[oddIndex];
                    oddIndex++;
                }

            }
            return intArray;
        }
    }
}
