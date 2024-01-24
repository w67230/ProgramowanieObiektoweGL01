using System;
using System.Collections.Generic;
using System.Text;

namespace Laby.Zadania
{
    public class Ksiazka
    {
        public string tytul { get; set; }
        public string autor { get; set; }
        public int rokWydania { get; set; }

        public static List<Ksiazka> listaKsiazek = new List<Ksiazka>();

        public Ksiazka(string tytul, string autor, int rokWydania)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.rokWydania = rokWydania;
            listaKsiazek.Add(this);
        }

        public void wyswietlTytul()
        {
            Console.WriteLine("Tytuł: " + this.tytul);
        }

        public void wyswietlAutora()
        {
            Console.WriteLine("Autor: " + this.autor);
        }

        public void wyswietlRokWydania()
        {
            Console.WriteLine("Rok wydania: " + this.rokWydania);
        }

        public void wyswietlKsiazke()
        {
            this.wyswietlTytul();
            this.wyswietlAutora();
            this.wyswietlRokWydania();
        }

        public static void wypiszKsiazkiPodanegoAutora(string autor)
        {
            foreach(Ksiazka ksiazka in listaKsiazek)
            {
                if(ksiazka.autor == autor)
                {
                    ksiazka.wyswietlKsiazke();
                }
            }
        }

        public static void wypiszKsiazkiZDanegoRoku(int rok)
        {
            foreach (Ksiazka ksiazka in listaKsiazek)
            {
                if (ksiazka.rokWydania == rok)
                {
                    ksiazka.wyswietlKsiazke();
                }
            }
        }

        public static void dodajDoListy(Ksiazka ksiazka)
        {
            listaKsiazek.Add(ksiazka);
        }

        public static void wyswietlElementyListy()
        {
            foreach(Ksiazka ksiazka in listaKsiazek)
            {
                Console.WriteLine("----------");
                ksiazka.wyswietlKsiazke();
            }
        }

        public static void zaktualizujObiekt(Ksiazka ksiazka)
        {
            for(int i = 0; i < listaKsiazek.Count; i++)
            {
                if(listaKsiazek[i].tytul == ksiazka.tytul)
                {
                    listaKsiazek[i] = ksiazka;
                    break;
                }
            }
        }

        public static void usunObiekt(string tytul)
        {
            for (int i = listaKsiazek.Count; i > 0; i--)
            {
                if (listaKsiazek[i].tytul == tytul)
                {
                    listaKsiazek.RemoveAt(i);
                    break;
                }
            }
        }

    }
}
