using System;
namespace ITMO.CSharpcourse
{
    internal class Utils

    {
        //<summary>
        /// this the test harness 
        /// </summary> 


        public static void Main(string[] args)
        {
            int x; //input value 1
            int y; //input value 2
            

            // get input numbers 
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            //test the Swap() method

            Console.WriteLine("Before swap " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap " + x + "," + y);

        }

        public static void Swap( ref int a, ref int b)
        {   int temp = a;
            a = b;
            b = temp;
        }

        public static int Greater(int x, int y)
        {
            if (x > y)
                return x;
            else if (x < y)
                return y;
            else
                return 1;
        }

    }
}