using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace ConsoleApp
{
    public class Ex6
    {
        public void GrowthCategories()
        {
            Console.WriteLine("Height categories. Enter your height");
            string height = Console.ReadLine();

            if (Int32.TryParse(height, out int number))
            {
                if (number <=140)
                    Console.WriteLine("You are a dwarf");
                else if(number>=141 && number <=159)
                    Console.WriteLine("you are slightly taller than the dwarf");
                else if(number>=160 && number <=179)
                    Console.WriteLine("You are a person of average height");
                else if(number>=180 && number <=199)
                    Console.WriteLine("Hmmm you are tall :)");
                else if(number >=200 && number <=219)
                    Console.WriteLine("Are you Shaquille O'Neal?");
                else if(number >=220 && number <=500)
                    Console.WriteLine("You are very tall");
            }
            else 
                Console.WriteLine($"Wrong format: {height}");
        }
    }
}
