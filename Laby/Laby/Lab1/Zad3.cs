using System;
using System.Collections.Generic;
using System.Text;

namespace Laby.Lab1
{
    public class Zad3
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1: Zadanie 1");
                Console.WriteLine("2: Zadanie 2");
                Console.WriteLine("3: Zadanie 4");
                Console.WriteLine("4: Zadanie 5");
                Console.WriteLine("5: Zadanie 6");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 5 || x < 1) continue;
                else
                {
                    if (x == 1) Zad1.Run();
                    else if (x == 2) Zad2.Run();
                    else if (x == 3) Zad4.Run();
                    else if (x == 4) Zad5.Run();
                    else if (x == 5) Zad6.Run();
                    break;
                }
            }
        }
    }
}
