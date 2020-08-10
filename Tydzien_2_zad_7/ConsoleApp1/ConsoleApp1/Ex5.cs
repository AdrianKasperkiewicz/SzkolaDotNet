using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Ex5
    {
        public void Age()
        {
            Console.WriteLine("Age check");
            Console.WriteLine("Enter age");
            string a = Console.ReadLine();

            if (Int32.TryParse(a, out int age))
            {
                if (age >= 21 && age <= 29)
                    Console.WriteLine("You can become a Member of Parliament");
                else if (age >= 30 && age <= 34)
                    Console.WriteLine("You can become a Senator");
                else if (age >= 35)
                    Console.WriteLine("You can become a President");
                else
                    Console.WriteLine("You are too young!!!");
            }
            else
                Console.WriteLine($"Wrong format: {a}");
        }

    }
}
