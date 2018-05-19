using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3Or5
{
    public class Kata
    {
        public static int MultiplesOf3Or5(int num)
        {
            int sum = 0;
            for (var i = 1; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }

        public static int MultiplesOf3Or5_LINQ(int num)
        {
            return Enumerable.Range(1, num).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
        }
    }
}
