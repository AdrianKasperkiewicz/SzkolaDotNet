using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex10
    {
        public void MultipleSearch()
        {
            Console.WriteLine("Enter two numbers");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();

            if (Int32.TryParse(number1, out int value1) && Int32.TryParse(number2, out int value2))
            {
                int x = value1 * value2;
                int y;
                while(value2 != 0)
                {
                    y = value1 % value2;
                    value1 = value2;
                    value2 = y;
                }
                int nww = x / value1;
                Console.WriteLine($"Least common multiple: {nww}");
            }
        }
    }
}
