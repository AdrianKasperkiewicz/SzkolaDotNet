using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Ex4
    {
        public void LeapYear()
        {
            Console.WriteLine("Checking if the year is leap year");
            Console.WriteLine("Enter year");
            string a = Console.ReadLine();
            bool parse = Int32.TryParse(a, out int year);

            if (parse && year % 4==0 && year % 100 !=0 || year % 400 ==0)
                Console.WriteLine($"{year} is a leap year");
            else if (!parse)
                Console.WriteLine($"Wrong format : {a}");
            else
                Console.WriteLine($"{year} is not a leap year");
        }
    }
}
