using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex2 ex2 = new Ex2();
            ex2.write1();
            ex2.write('a', 'b', 'c');

            Ex3 ex3 = new Ex3();
            ex3.field(458.4);

            Ex4 ex4 = new Ex4();
            ex4.type(10, "Szkoła Dotneta", 12.5);

            Ex5 ex5 = new Ex5();
            ex5.PersonalData();
        }
    }
}
