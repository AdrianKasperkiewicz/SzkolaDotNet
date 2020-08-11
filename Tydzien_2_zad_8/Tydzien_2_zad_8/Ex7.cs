using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex7
    {
        public void Diamond()
        {
            Console.WriteLine("Enter width");
            string command = Console.ReadLine();
            if (Int32.TryParse(command, out int value))
            {
                for (int i = 0; i < Math.Ceiling(value/2.0); i++)
                {
                    for (int j = 1; j <= (value/2) - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j<2*i+1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                for (int i = value/2-1; i>=0; i--)
                {
                    for (int j = 1; j<=(value/2)-i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j<2*i+1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
