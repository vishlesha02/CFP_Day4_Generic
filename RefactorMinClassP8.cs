using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class RefactorMinClassP8<T> where T : IComparable<T>
    {
       
        private T value1;
        private T value2;
        private T value3;

        public RefactorMinClassP8(T value1, T value2, T value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public T TestMinimum()
        {
            return FindMinimum(value1, value2, value3);
        }

        private static T FindMinimum(T value1, T value2, T value3)
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

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter three integers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            RefactorMinClassP8<int> intMinimumFinder = new RefactorMinClassP8<int>(num1, num2, num3);
            int minInt = intMinimumFinder.TestMinimum();
            Console.WriteLine("The minimum integer value is: " + minInt);

            Console.WriteLine("Enter three floating-point values:");
            float float1 = float.Parse(Console.ReadLine());
            float float2 = float.Parse(Console.ReadLine());
            float float3 = float.Parse(Console.ReadLine());

            RefactorMinClassP8<float> floatMinimumFinder = new RefactorMinClassP8<float>(float1, float2, float3);
            float minFloat = floatMinimumFinder.TestMinimum();
            Console.WriteLine("The minimum float value is: " + minFloat);

            Console.WriteLine("Enter three strings:");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();

            RefactorMinClassP8<string> stringMinimumFinder = new RefactorMinClassP8<string>(str1, str2, str3);
            string minString = stringMinimumFinder.TestMinimum();
            Console.WriteLine("The minimum string value is: " + minString);
        }
    }
   
    
}

