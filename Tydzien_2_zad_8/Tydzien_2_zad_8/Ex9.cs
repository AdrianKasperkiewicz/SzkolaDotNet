using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex9
    {
        public void Binary()
        {
            Console.WriteLine("Enter number");
            string number = Console.ReadLine();
            string empty = "";

            if (Int32.TryParse(number, out int value))
            {
                while (value > 0)
                {
                    if (value % 2 == 0)
                        empty += "0";
                    else
                        empty += "1";

                    value /= 2;
                }
                for (int i = empty.Length - 1; i >= 0; i--)
                {
                    Console.Write(empty[i]);
                }
            }
            else
                Console.WriteLine("Wrong value");
        }
    }
}
