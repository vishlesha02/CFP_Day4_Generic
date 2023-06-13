using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class FloatMin
    {
        static void Main()
        {
            Console.WriteLine("Enter three floats:");

            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());

            float min = Math.Min(Math.Min(num1, num2), num3);

            Console.WriteLine($"The minimum value is: {min}");
        }
    }
}
