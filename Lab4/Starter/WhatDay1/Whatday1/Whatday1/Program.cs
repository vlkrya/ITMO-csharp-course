using System;

namespace ITMO.CSharpcourse
{ 
    enum MonthName { January, February, Match, April, May, June, July, August, September, October, November, December }
    class WhatDay
    {
        static void Main()
        {
            Console.Write("Please enter a day number between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);

            int monthNum = 0;
            int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }
            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();

            Console.WriteLine(" {0} {1} ", dayNum, monthName);



        }
    }
}