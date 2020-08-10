using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Ex11
    {
        public void SchoolGrade()
        {
            Console.WriteLine("Enter grade");
            string grade = Console.ReadLine();

            if (Int32.TryParse(grade, out int value))
            {
                switch (value)
                {
                    case 6:
                        Console.WriteLine("Excellent");
                        break;
                    case 5:
                        Console.WriteLine("Very good");
                        break;
                    case 4:
                        Console.WriteLine("Good");
                        break;
                    case 3:
                        Console.WriteLine("Sufficient");
                        break;
                    case 2:
                        Console.WriteLine("Allowing");
                        break;
                    case 1:
                        Console.WriteLine("Not allowing");
                        break;
                    default:
                        Console.WriteLine("Wrong value");
                        break;
                }
            }
            else
                Console.WriteLine("Wrong format");
        }
    }
}
