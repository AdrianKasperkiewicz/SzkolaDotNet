using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Ex2
    {
        public void write1()
        {
            char first1 = 'a';
            char second1 = 'b';
            char third1 = 'c';

            if (first1 == null & second1 == null & third1 == null)
                Console.WriteLine("Variables are empty");
            else
                Console.WriteLine($"{third1} {second1} {first1}");
        }


        public void write(char first, char second, char third)
        {
            if (first == null & second == null & third == null)
                Console.WriteLine("Variables are empty");
            else
                Console.WriteLine($"{third} {second} {first}");
        }
    }
}
