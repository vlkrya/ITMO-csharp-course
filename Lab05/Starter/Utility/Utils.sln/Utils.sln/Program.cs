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
            int greater; // result from Greater()

            // get input numbers 
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            //test the Greater() method
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);
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


