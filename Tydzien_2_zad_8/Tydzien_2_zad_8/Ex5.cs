using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tydzien_2_zad_8
{
    public class Ex5
    {
        public void Exponentiation()
        {
            int[] numbers = Enumerable.Range(1, 20).ToArray();

            foreach (var number in numbers)
                Console.WriteLine(Math.Pow(number, 3));
        }
	}
}

