using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex3
    {
        public int Fib(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                return c;
            }
            return c;
            
        }
    }
}
