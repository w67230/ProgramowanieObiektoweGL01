using System;
using System.Collections.Generic;
using System.Text;

namespace Laby.Lab1
{
    public class Zad1
    {

        public static void Run()
        {
            Console.WriteLine("Podaj liczbe");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0) Console.WriteLine("Liczba jest parzysta");
            else Console.WriteLine("Liczba jest nieparzysta");
        }
    }
}
