using System;
using System.Runtime.InteropServices;

namespace Tydzien_2_zad_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1 ex1 = new Ex1();
            ex1.integers();

            Ex2 ex2 = new Ex2();
            ex2.EvenNumbers();

            Ex3 ex3 = new Ex3();
            ex3.Fib(2);

            Ex4 ex4 = new Ex4();
            ex4.Pyramid();

            Ex5 ex5 = new Ex5();
            ex5.Exponentiation();

            Ex6 ex6 = new Ex6();
            ex6.Sum();

            Ex7 ex7 = new Ex7();
            ex7.Diamond();

            Ex8 ex8 = new Ex8();
            ex8.Reverse();

            Ex9 ex9 = new Ex9();
            ex9.Binary();

            Ex10 ex10 = new Ex10();
            ex10.MultipleSearch();
        }
    }
}
