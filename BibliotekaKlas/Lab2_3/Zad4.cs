using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekaKlas.Lab2_3
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;
        private Samochód samochod;

        public Osoba(string imie, string nazwisko, Samochód samochod, DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.samochod = samochod;
            this.dataUrodzenia = dataUrodzenia;
        }

        public string getImieAndNazwisko()
        {
            return this.imie + " " + this.nazwisko;
        }

        public bool isPelnoletnia()
        {
            DateTime now = DateTime.Now;
            return (now.Year - this.dataUrodzenia.Year) > 17;
        }

        public void setNazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

        //this.getSamochod().rokProdukcji = 1999;
        public Samochód getSamochod()
        {
            return this.samochod;
        }

        public string infoOSamochodzie()
        {
            return $"Samochód marki {this.getSamochod().marka} wyprodukowany w roku {this.getSamochod().rokProdukcji}";
        }
    }
}
