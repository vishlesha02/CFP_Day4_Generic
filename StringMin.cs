using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class StringMin
    {
        static void Main()
        {
            Console.WriteLine("Enter three strings:");

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();

            string min = FindMinimumString(str1, str2, str3);

            Console.WriteLine($"The minimum value is : {min}");
        }

        static string FindMinimumString(string str1, string str2, string str3)
        {
            string min = str1;

            if (string.Compare(str2, min) < 0)
            {
                min = str2;
            }

            if (string.Compare(str3, min) < 0)
            {
                min = str3;
            }

            return min;
        }
    }
}
