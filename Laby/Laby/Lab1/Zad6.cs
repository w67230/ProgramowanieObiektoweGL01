using System;
using System.Collections.Generic;
using System.Text;

namespace Laby.Lab1
{
    public class Zad6
    {
        public static void Run()
        {
            Console.WriteLine("Podaj liczbe");
            int x = Convert.ToInt32(Console.ReadLine());
            int miara;
            do
            {
                WyswietlMenuMiar();
                miara = Convert.ToInt32(Console.ReadLine());
            } while (miara < 1 || miara > 3);

            int jednostka;
            do
            {
                Console.WriteLine("Wybierz jednostke:");
                WyswietlMenuJednostek(miara);
                jednostka = Convert.ToInt32(Console.ReadLine());
            } while (jednostka < 0 || jednostka > 4);

            int przeliczenie;
            do
            {
                Console.WriteLine("Wybierz jednostke na ktora mam przeliczyc:");
                WyswietlMenuJednostek(miara);
                przeliczenie = Convert.ToInt32(Console.ReadLine());
            } while (przeliczenie < 0 || przeliczenie > 4);

            int mnoznik;
            // zle obliczenia dalem ale czasu nie ma
            if (jednostka == przeliczenie) mnoznik = 1;
            else if (jednostka < przeliczenie) mnoznik = 1/(przeliczenie-jednostka);
            else mnoznik = (jednostka - przeliczenie) * 10;

            Console.WriteLine("Przeliczona liczba:");
            Console.WriteLine(x * mnoznik);


        }

        private static void WyswietlMenuMiar()
        {
            Console.WriteLine("Wybierz miare:");

            Console.WriteLine("1: Dlugosc (mm, cm, dm...)");
            Console.WriteLine("2: Waga (mg, g, dg...)");
        }

        private static void WyswietlMenuJednostek(int miara)
        {
            if (miara == 1)
            {
                Console.WriteLine("1: mm");
                Console.WriteLine("2: cm");
                Console.WriteLine("3: dm");
                Console.WriteLine("4: m");

            }
            else if(miara == 2)
            {
                Console.WriteLine("1: mg");
                Console.WriteLine("2: g");
                Console.WriteLine("3: dg");
                Console.WriteLine("4: kg");
            }
        }
    }
}
