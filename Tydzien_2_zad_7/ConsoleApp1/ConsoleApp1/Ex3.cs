using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Ex3
    {
        public void PositiveOrNegative()
        {
            Console.WriteLine("Checking if the value is positive or negative");
            Console.WriteLine("Enter one digit");
            string a = Console.ReadLine();
            bool parse = Int32.TryParse(a, out int number);
            if (parse && number > 0)
                Console.WriteLine($"{number} is greater than 0");
            else if (!parse)
                Console.WriteLine($"Wrong format {a}");
            else
                Console.WriteLine($"{number} is not greater than 0");
        }
    }
}
