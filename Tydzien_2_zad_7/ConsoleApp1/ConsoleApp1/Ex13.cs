using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp
{
    public class Ex13
    {
        public void Calculator()
        {
            Console.WriteLine("Select an action and enter number:");
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Substraction");
            Console.WriteLine("3 Multiplication");
            Console.WriteLine("4 Division");

            string ActionSelected = Console.ReadLine();

            if (Int32.TryParse(ActionSelected, out int value))
            {
                switch (value)
                {
                    case 1:
                        CalcActionSum();
                        break;
                    case 2:
                        CalcActionSub();
                        break;
                    case 3:
                        CalcActionMulti();
                        break;
                    case 4:
                        CalcActionDiv();
                        break;
                    default:
                        Console.WriteLine("Wrong Value");
                        break;
                }               
            }
            else
                Console.WriteLine("Wrong format of the entered action");
        }

        public void CalcActionSum()
        {
            Console.WriteLine("Enter two variables First:");
            string a = Console.ReadLine();
            Console.WriteLine("Second: ");
            string b = Console.ReadLine();

            if (Int32.TryParse(a, out int ValueA) && Int32.TryParse(b, out int ValueB))
                Console.WriteLine($"The result is: {ValueA + ValueB}");

            else
                Console.WriteLine("Wrong format");
        }

        public void CalcActionSub()
        {
            Console.WriteLine("Enter two variables First:");
            string a = Console.ReadLine();
            Console.WriteLine("Second: ");
            string b = Console.ReadLine();

            if (Int32.TryParse(a, out int ValueA) && Int32.TryParse(b, out int ValueB))
                Console.WriteLine($"The result is: {ValueA - ValueB}");

            else
                Console.WriteLine("Wrong format");
        }

        public void CalcActionMulti()
        {
            Console.WriteLine("Enter two variables First:");
            string a = Console.ReadLine();
            Console.WriteLine("Second: ");
            string b = Console.ReadLine();

            if (Int32.TryParse(a, out int ValueA) && Int32.TryParse(b, out int ValueB))
                Console.WriteLine($"The result is: {ValueA * ValueB}");

            else
                Console.WriteLine("Wrong format");
        }

        public void CalcActionDiv()
        {
            Console.WriteLine("Enter two variables First:");
            string a = Console.ReadLine();
            Console.WriteLine("Second: ");
            string b = Console.ReadLine();
            if (Double.TryParse(a, out double ValueA) && Double.TryParse(b, out double ValueB) && ValueB != 0)
                Console.WriteLine($"The result is: {ValueA / ValueB}");

            else
                Console.WriteLine("Wrong format");
        }
    }
}
