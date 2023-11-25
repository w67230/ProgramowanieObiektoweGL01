using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekaKlas.Lab2_3
{
    public class Samochód
    {
        public string marka;
        public string model;
        public int rokProdukcji;

        private float predkoscSamochodu;
        private float przebieg;
        private StanSilnika stanSilnika;
        private int iloscCheckow = 1;

        public Samochód(string marka, string model, int rokProdukcji)
        {
            this.marka = marka;
            this.model = model;
            this.rokProdukcji = rokProdukcji;
            this.predkoscSamochodu = 0.0f;
            this.przebieg = 0;
            this.stanSilnika = StanSilnika.NIEURUCHOMIONY;
        }

        public void ustawTempomat(float predkosc)
        {
            this.predkoscSamochodu = predkosc;
        }

        public void przyspiesz()
        {
            if (this.stanSilnika != StanSilnika.URUCHOMIONY) return;
            this.predkoscSamochodu += 5.0f;
        }

        public void zwolnij()
        {
            if (this.stanSilnika != StanSilnika.URUCHOMIONY) return;
            this.predkoscSamochodu -= 5.0f;
        }

        public void uruchomSilnik()
        {
            this.stanSilnika = StanSilnika.URUCHOMIONY;
        }

        public void wylaczSilnik()
        {
            this.stanSilnika = StanSilnika.NIEURUCHOMIONY;
        }

        public float przejedzPodanyDystans(float metry)
        {
            this.przebieg += metry;
            if (this.przebieg/ this.iloscCheckow > 10000)
            {
                this.stanSilnika = StanSilnika.CHECK_ENGINE;
                this.iloscCheckow++;
            }
                
            return metry / this.predkoscSamochodu;
        }

        public void naprawSilnik()
        {
            if(this.stanSilnika == StanSilnika.ZEPSUTY)
            {
                this.stanSilnika = StanSilnika.NIEURUCHOMIONY;
            }
        }

        public float getPredkosc()
        {
            return this.predkoscSamochodu;
        }
    }

    public enum StanSilnika
    {
        NIEURUCHOMIONY,
        URUCHOMIONY,
        ZEPSUTY,
        CHECK_ENGINE

    }
}
