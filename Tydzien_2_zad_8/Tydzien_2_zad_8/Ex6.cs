using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex6
    {
        public void Sum()
        {
            int a = 1;
            double result = 0;

            for (int i = 1; i <= 20; i++)
            {
                for (int k = 1; k <=i ; k++)
                {
                    result += 1.0 / k;
                }
                Console.WriteLine($"{result} ");
            }
        }
    }
}
