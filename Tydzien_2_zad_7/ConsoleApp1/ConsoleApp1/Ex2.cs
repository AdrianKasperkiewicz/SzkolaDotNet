using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp
{
    public class Ex2
    {
        public void Even()
        {
            Console.WriteLine("Parity check");
            Console.WriteLine("Enter one digit");
            string a = Console.ReadLine();
            bool parse = Int32.TryParse(a, out int number);

            if (parse && number % 2==0)
                Console.WriteLine($"{number} is an even number");
            else if (!parse)
                Console.WriteLine($"Wrong format {a}");
            else
                Console.WriteLine($"{number} it is not even");  
        }       
    }
}
