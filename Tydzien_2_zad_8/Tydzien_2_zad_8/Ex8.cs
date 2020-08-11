using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex8
    {
        public void Reverse()
        {
            Console.WriteLine("Enter word");
            string value = Console.ReadLine();
            char[] array = value.ToCharArray();
            Array.Reverse(array);
            foreach (var words in array)
            {
                Console.Write(words);
            }  
        }
    }
}
