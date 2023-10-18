using System;

namespace BibliotekaKlas.Lab2
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

        public void wypiszWszystkieElementyTablicy()
        {
            for(int i = 0; i < this.Liczby.Length; i++)
            {
                
            }
        }

        public int[] getLiczby()
        {
            return this.Liczby;
        }


    }
}

