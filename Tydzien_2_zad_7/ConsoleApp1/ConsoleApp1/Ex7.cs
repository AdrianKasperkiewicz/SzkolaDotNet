using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Ex7
    {
        public void HighestNumber()
        {
            Console.WriteLine("Enter three number. First:");
            string a = Console.ReadLine();
            Console.WriteLine("Second");
            string b = Console.ReadLine();
            Console.WriteLine("Third");
            string c = Console.ReadLine();

            if (Int32.TryParse(a, out int number1) && Int32.TryParse(b, out int number2) && Int32.TryParse(c, out int number3))
            {
                int[] numbers = { number1, number2, number3 };
                Array.Sort(numbers);
                Array.Reverse(numbers);

                foreach (int values in numbers)
                {
                    Console.WriteLine($"\r\n{values} ");
                }
            }
            else
                Console.WriteLine($"Wrong format");

        }
    }
}
