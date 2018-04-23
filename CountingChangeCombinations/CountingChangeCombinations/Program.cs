using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingChangeCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            CountCombinations(4, new[] {1, 2, 3});
        }
        public static int CountCombinations(int money, int[] coins)//ex: money=4, coins[1,2,3]
        {
            int count = 0;
            if (coins.Length == 1)
            {
                int temp = money % coins[0];
                return temp == 0 ? 1 : 0;
            }

            for (var i = 0; i * coins[0] <= money; i++)
            {
                if (i * coins[0] == money)
                {
                    count += 1;
                }
                else
                {
                    count += CountCombinations(money - i * coins[0], coins.Skip(1).ToArray());
                }
            }
            return count;
        }
    }
}
