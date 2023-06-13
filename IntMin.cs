using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class IntMin
    {
        static void Main()
        {
            Console.WriteLine("Enter three integers:");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int min = Math.Min(Math.Min(num1, num2), num3);

            Console.WriteLine($"The minimum value is: {min}");
        }

    }
}