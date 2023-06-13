using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class RefactorMinP7
    {
        static void Main()
        {
            Console.WriteLine("Enter three values:");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int minInt = FindMinimum(num1, num2, num3);
            Console.WriteLine($"The minimum integer value is : {minInt}");

            Console.WriteLine("Enter three floating-point values:");

            float float1 = float.Parse(Console.ReadLine());
            float float2 = float.Parse(Console.ReadLine());
            float float3 = float.Parse(Console.ReadLine());

            float minFloat = FindMinimum(float1, float2, float3);
            Console.WriteLine($"The minimum float value is : {minFloat}");

            Console.WriteLine("Enter three strings:");

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();

            string minString = FindMinimum(str1, str2, str3);
            Console.WriteLine($"The minimum string value is : {minString}");
        }

        static T FindMinimum<T>(T value1, T value2, T value3) where T : IComparable<T>
        {
            T min = value1;

            if (value2.CompareTo(min) < 0)
            {
                min = value2;
            }
            if (value3.CompareTo(min) < 0)
            {
                min = value3;
            }

            return min;
        }
    }
}
