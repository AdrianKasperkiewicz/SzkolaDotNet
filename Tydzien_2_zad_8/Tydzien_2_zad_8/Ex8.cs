using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex8
    {
<<<<<<< HEAD
        public string Reverse(string value)
        {
            char[] arr = value.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
            
=======
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
>>>>>>> e8164b41ed31e9210d9cf9d6be68de4718de1a72
        }
    }
}
