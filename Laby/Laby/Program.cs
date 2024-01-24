using System;
using Laby.Zadania;

namespace Laby
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab1.Zad1.Run();
            //Lab1.Zad2.Run();
            //Lab1.Zad3.Run();

            Ksiazka ksiazka = new Ksiazka("Taka ksiazka", "Ukasz Rydz", 1997);
            Ksiazka druga = new Ksiazka("Druga ksiazka", "Lukasz Fryc", 2002);
            Ksiazka trzecia = new Ksiazka("Nie ksiazka", "Nie Ukasz", 1201);
            ksiazka.wyswietlKsiazke();
            druga.wyswietlKsiazke();
            trzecia.wyswietlKsiazke();

            Prostokat prosty = new Prostokat(3f, 2f);
            Trojkat troj = new Trojkat(3f, 4f, 5f, 4f);
            Prostokat nieprosty = new Prostokat(5.5f, 10f);
            Trojkat nietroj = new Trojkat(20f, 20f, 20f, 20f);

            foreach(Kształt cos in Kształt.listaKształtów)
            {
                if(cos.zwrocObwod() > 10f)
                {
                    Console.WriteLine("Pole figury: " + cos.zwrocPole());
                }
            }
        }
    }
}
