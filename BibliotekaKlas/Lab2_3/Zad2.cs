using System;

namespace BibliotekaKlas.Lab2_3
{
    public class Sumator
    {

        private int[] Liczby;

	    public Sumator(int[] liczby)
	    {
            this.Liczby = liczby;
	    }


        public int Suma()
        {
            int suma = 0;
            for(int i = 0; i < this.Liczby.Length; i++)
            {
                suma += this.Liczby[i];
            }
            return suma;
        }

        public int SumaPodziel3()
        {
            int suma = 0;
            for (int i = 0; i < this.Liczby.Length; i++)
            {
                if(this.Liczby[i]%3 == 0)
                {
                    suma += this.Liczby[i];
                }
            
            }
            return suma;
        }

        public int ileElementow()
        {
            return this.Liczby.Length;
        }

        public string[] wypiszWszystkieElementyTablicy()
        {
            string[] liczby = new string[this.Liczby.Length];
            for(int i = 0; i < this.Liczby.Length; i++)
            {
                liczby[i] = this.Liczby[i].ToString();
            }
            return liczby;
        }

        public int[] getLiczby()
        {
            return this.Liczby;
        }

        public void wypiszLiczbyZPomiedzyIndeksow(int lowIndex, int highIndex)
        {
            for (int i = lowIndex; i < this.Liczby.Length && i <= highIndex; i++)
            {
                // wypisanie
            }
        }


    }
}

