using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex8
    {
        public string Reverse(string value)
        {
            char[] arr = value.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
            
        }
    }
}
