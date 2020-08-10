using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Ex10
    {
        public void Triangle()
        {
            Console.WriteLine("Enter three side lengths. First:");
            string side1 = Console.ReadLine();
            Console.WriteLine("Second:");
            string side2 = Console.ReadLine();
            Console.WriteLine("Third:");
            string side3 = Console.ReadLine();

            if (Double.TryParse(side1, out double sideA) && Double.TryParse(side2, out double sideB) && Double.TryParse(side3, out double sideC))
            {
                if ((sideA + sideB > sideC) || (sideA + sideC > sideB) || (sideC + sideB > sideA))
                    Console.WriteLine("You can make a triangle");
                else
                    Console.WriteLine("You can't make a triange");
            }
            else
                Console.WriteLine("Wrong format.");
        }
    }
}
