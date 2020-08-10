using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Ex12
    {
        public void DayOfTheWeek()
        {
            Console.WriteLine("Enter the number of the day of the week");
            string day = Console.ReadLine();

            if (Int32.TryParse(day, out int value))
            {
                switch (value)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
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
