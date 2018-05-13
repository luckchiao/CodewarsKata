using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingTermInArithmeticProgression
{
    public class Kata
    {
        static void Main(string[] args)
        {
        }

        public static int FindMissing(List<int> list) 
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                    temp.Add(list[i] - list[i - 1]);
            }

            int min = temp.Min();
            int max = temp.Max();

            var indexAtMax = temp.IndexOf(max);
            return list[indexAtMax] + min;
        }
    }
}
