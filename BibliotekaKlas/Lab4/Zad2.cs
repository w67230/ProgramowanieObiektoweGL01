using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekaKlas.Lab4
{
    public abstract class Osoba
    {

        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string pesel { get; set; }

        public virtual void SetFirstName(string name)
        {
            this.imie = name;
        }

        public virtual void SetLastName(string lastName)
        {
            this.nazwisko = lastName;
        }

        public virtual void SetPesel(string pesel)
        {
            this.pesel = pesel;
        }

        public virtual int GetAge()
        {
            int year = Convert.ToInt32(pesel.Substring(0, 2));
            int month = Convert.ToInt32(pesel.Substring(2,2));
            if(month > 20)
            {
                year += 2000;
            }
            else
            {
                year += 1900;
            }

            return DateTime.Now.Year - year;
        }

        public virtual string GetGender()
        {
            int i = Convert.ToInt32(this.pesel[9]);
            if (i % 2 == 0) return "Kobieta";
            return "Mężczyzna";
        }

        public abstract string GetEducationInfo();

        public abstract string GetFullName();

        public abstract bool CanGoAloneToHome();

    }

    public class Uczen : Osoba
    {

        public string szkola;
        public bool mozeSamWracacDoDomu;
        public override string GetEducationInfo()
        {
            return this.szkola;
        }

        public override string GetFullName()
        {
            return this.imie + " " + this.nazwisko;
        }

        public override bool CanGoAloneToHome()
        {
            return mozeSamWracacDoDomu;
        }

        public void SetSchool(string school)
        {
            this.szkola = school;
        }

        public void ChangeSchool(string school)
        {
            this.SetSchool(school);
        }

        public void SetCanGoHomeAlone(bool moze)
        {
            this.mozeSamWracacDoDomu = moze;
        }

        public string Info()
        {
            return "Nie moze sam wracac ponizej 12 lat chyba ze ma pozwolenie";
        }
    }

    public class Nauczyciel : Uczen
    {
        public string TytulNaukowy;
        public List<Uczen> kolekcjaUczniow = new List<Uczen>();

        public List<Uczen> ktoMozeIscSamDoDomu()
        {
            List<Uczen> ktoMoze = new List<Uczen>();
            foreach(Uczen uczen in this.kolekcjaUczniow)
            {
                if (uczen.CanGoAloneToHome())
                {
                    ktoMoze.Add(uczen);
                }
            }

            return ktoMoze;
        }

        public List<string> wypiszJakisDzienCzyCus(DateTime date)
        {
            List<string> row = new List<string>();
            row.Add($"{this.GetEducationInfo()} Dnia: {date.DayOfWeek}");
            row.Add($"Nauczyciel {this.TytulNaukowy} {this.imie} {this.nazwisko}");
            row.Add($"Lista studentów:");
            int i = 1;
            foreach(Uczen uczen in this.kolekcjaUczniow)
            {
                row.Add($"{i}. {uczen.imie} {uczen.nazwisko} - {uczen.GetGender()} - {uczen.CanGoAloneToHome()} {uczen.Info()}");
            }

            return row;
        }
    }
}
