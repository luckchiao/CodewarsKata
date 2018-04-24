using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramDetection
{
    class AnagramDetection
    {
        static void Main(string[] args)
        {
           IsAnagram("Buckethead", "DeathCubeK");
        }

        public static bool IsAnagram(string test, string original)
        {
            char[] aTest = test.ToLower().ToArray();
            Array.Sort(aTest);
            char[] aOriginal = original.ToLower().ToArray();
            Array.Sort(aOriginal);

            return aTest.SequenceEqual(aOriginal);
        }
    }
}
