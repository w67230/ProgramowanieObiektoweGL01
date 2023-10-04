using System;
using System.Collections.Generic;
using System.Text;

namespace Laby.Lab1
{
    public class Zad2
    {
        public static void Run()
        {
            Console.WriteLine("Podaj liczbe");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 1;
            while(y <= x)
            {
                if(y%2==0) Console.WriteLine(y);
                y++;
            }
        }
    }
}
