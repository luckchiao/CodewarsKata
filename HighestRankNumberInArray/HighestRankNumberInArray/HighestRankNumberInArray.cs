using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestRankNumberInArray
{
    public class HighestRankNumberInArray
    {
        public static int HighestRank(int[] iarr)
        {
            var numbers = iarr.ToList();
            return numbers.GroupBy(g => g).OrderByDescending(o => o.Count()).ThenByDescending(t=>t.Key).Select(s => s.Key).FirstOrDefault();
        }
    }
}
