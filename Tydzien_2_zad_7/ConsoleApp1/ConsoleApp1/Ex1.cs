using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Ex1
    {
        int a = 5;
        int b = 5;

        public void EqualityCheck()
        {
            Console.WriteLine("Value comparison");
            if (a==b)
                Console.WriteLine($"{a} and {b} are equal");
            else
                Console.WriteLine($"{a} and {b} are not equal");
        }
    }
}
