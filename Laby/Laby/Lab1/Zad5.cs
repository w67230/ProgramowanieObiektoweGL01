using System;
using System.Collections.Generic;
using System.Text;

namespace Laby.Lab1
{
    public class Zad5
    {

        private static Random random = new Random();
        public static void Run()
        {
            int wylosowanaLiczba = random.Next(0, 20);
            int proba = 1;
            int zgadniecie = -1;
            Console.WriteLine("Zgadnij jaka liczbe od 0 do 20 wylosowal komputer");
            while(zgadniecie != wylosowanaLiczba)
            {
                Console.WriteLine("Proba nr: " + proba);
                zgadniecie = Convert.ToInt32(Console.ReadLine());
                proba++;
            }
            Console.WriteLine("Zgadles!!!!");
            

        }
    }
}
