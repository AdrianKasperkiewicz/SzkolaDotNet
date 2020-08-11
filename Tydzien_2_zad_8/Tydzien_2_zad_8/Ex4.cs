using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex4
    {
        public void Pyramid()
        {
            Console.WriteLine("Enter value");
            string value = Console.ReadLine();
            int count = 1;

            if (Int32.TryParse(value, out int number))
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write($"{count} ");
                        count++;

                        if (count > number)
                            break;    
                    }
                    Console.WriteLine();
                    if (count > number)
                        break;  
                }
            }
            else
                Console.WriteLine("Wrong value");
        }
    }
}
