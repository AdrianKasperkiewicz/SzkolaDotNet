using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleApp
{
    public class Ex9
    {
        public void Temperature()
        {
            Console.WriteLine("Enter the temperature");
            string temp = Console.ReadLine();

            if (Double.TryParse(temp, out double temp1))
            {
                if (temp1 < 0)
                    Console.WriteLine("Damn cold");
                else if (temp1 >= 0 && temp1 < 10)
                    Console.WriteLine("It's cold");
                else if (temp1 >= 10 && temp1 < 20)
                    Console.WriteLine("Cool");
                else if (temp1 >= 20 && temp1 < 30)
                    Console.WriteLine("Just right");
                else if (temp1 >= 30 && temp1 < 40)
                    Console.WriteLine("It's starting to get weak because it's hot");
                else if (temp1 >= 40)
                    Console.WriteLine("And let's move to Alaska.");
            }
            else
                Console.WriteLine("Wrong format");
        }
    }
}
