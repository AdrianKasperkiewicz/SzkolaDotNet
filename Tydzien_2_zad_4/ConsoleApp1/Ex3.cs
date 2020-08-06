using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Ex3
    {
        public void field(double Lenght)
        {
            if (Lenght == null)
            {
                Console.WriteLine("The variable is empty");
            }
            else
                Console.WriteLine($"The field is {Math.Sqrt(Lenght)}");
        }
    }
}
