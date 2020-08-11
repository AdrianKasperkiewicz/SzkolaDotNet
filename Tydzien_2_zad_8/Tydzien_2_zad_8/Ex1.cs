using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex1
    {
        public void integers()
        {
            int maxValue = 100;
            int minValue = 0;
            int a = 0;

            Console.WriteLine("Natural numbers: ");
            for (int i = 2; i <= maxValue; i++)
            { 
                if (i == 2 || i == 3 || i == 5 || i == 7 || i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    Console.WriteLine($"{i}");
                    minValue++;
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
