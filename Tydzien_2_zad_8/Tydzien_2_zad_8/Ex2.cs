using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex2
    {
        public void EvenNumbers()
        {
            int maxValue = 1000;
            int a = 0;
            do
            {
                if (a %2==0)
                {
                    Console.Write($"{a} ");
                }
                a++;
            } while (a <=maxValue);
        }

    }
}
