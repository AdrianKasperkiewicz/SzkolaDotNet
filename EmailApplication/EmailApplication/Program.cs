using System;
using EmailApplication.Services;

namespace EmailApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StartScreenServices startScreen=new StartScreenServices();
            startScreen.StartScreen();
        }
    }
}
