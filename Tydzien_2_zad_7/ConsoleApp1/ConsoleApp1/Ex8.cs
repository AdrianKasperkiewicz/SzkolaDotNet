using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Ex8
    {
        public void ApplyingForStudies()
        {
            Console.WriteLine("Enter your exam results. Maths:");
            string math = Console.ReadLine();
            Console.WriteLine("Physics:");
            string physics = Console.ReadLine();
            Console.WriteLine("Chemistry:");
            string chemistry = Console.ReadLine();

            if (Int32.TryParse(math, out int math1) && Int32.TryParse(physics, out int physics1) && Int32.TryParse(chemistry, out int chemistry1))
            {
                if (math1>70 && physics1>55 && chemistry1>45 || math1 + physics1 + chemistry1>180 || math1 + physics1>150 || math1 + chemistry1>150)
                    Console.WriteLine("Candidate admitted to recruitment");
                else
                    Console.WriteLine("Candidate not admitted to recruitment");
            }
            else
                Console.WriteLine("Wrong format");

        }
    }
}
