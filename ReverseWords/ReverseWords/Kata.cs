using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    public class Kata
    {
        public static string ReverseWords(string str)
        {
            var result = string.Empty;
            var words = str.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                var temp = string.Empty;
                foreach (var wChar in words[i].Reverse())
                    temp += wChar.ToString();
                result += temp;
                if (i != words.Length - 1)
                    result = result.Insert(result.Length, " ");
            }

            return result;
        }
    }
}
