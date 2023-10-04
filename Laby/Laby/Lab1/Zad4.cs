using System;
using System.Collections.Generic;
using System.Text;

namespace Laby.Lab1
{
    public class Zad4
    {

        public static int Silnia(int liczba)
        {
            if (liczba <= 1) return 1;
            return Silnia(liczba - 1) * liczba;
        }
        public static void Run()
        {
            Console.WriteLine("Podaj liczbe do silni");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x > -1)
            {
                Console.WriteLine("Silnia z "+x+" wynosi: "+Silnia(x));
            }
            else
            {
                Console.WriteLine("Liczba nie moze byc ujemna");
            }
        }
    }
}
