using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharpCourse
{
    public class Test

    {
        public static void Main()
        {
            int x; // Input value 1
            int y; // Input value 2

            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swap: " + x + "," + y);
            Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);
        }

        private static void Swap(ref int a, ref int b)
        {
            

            int temp = a;
            a = b;
            b = temp;
        }
    }
}
