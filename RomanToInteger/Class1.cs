using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    public class Solution
    {
       public int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanNumbersDictionary = new()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L', 50 },
                {'C',100 },
                {'D', 500 },
                {'M', 1000 }
            };
            for (int i = 0; i < s.Length; i++)
            {
               char Current = s[i];
               romanNumbersDictionary.TryGetValue(s[i], out int num);
               if(i > 3999)
                {
                    Console.WriteLine("Too Large");
                    return 0;
                }
               if (i < 0)
                {
                    return 0;
                }
               sum += num;
               return sum;
            }
            
        }
    }
}
