using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekaKlas.Lab5
{
    public interface InterfejsID<T>
    {
        public T getId();
        public void setId(T t);
    }

    public interface InterfejsDataUtworzenia
    {
        public DateTime getDate();
        public void setDate(DateTime date);
    }

    public class Book : InterfejsID<Int32>, InterfejsDataUtworzenia
    {
        private int id;
        public string tytul;
        public Person autor;
        private DateTime dataUtworzenia;

        public DateTime getDate()
        {
            return this.dataUtworzenia;
        }

        public int getId()
        {
            return this.id;
        }

        public void setDate(DateTime date)
        {
            this.dataUtworzenia = date;
        }

        public void setId(int t)
        {
            this.id = t;
        }
    }

    public class Person : InterfejsID<String>, InterfejsDataUtworzenia
    {
        private string pesel;
        private DateTime dataUrodzenia;
        public string imie;
        public string nazwisko;
        public List<Book> listaWypozyczonychKsiazek = new List<Book>();
        public DateTime getDate()
        {
            return this.dataUrodzenia;
        }

        public string getId()
        {
            return this.pesel;
        }

        public void setDate(DateTime date)
        {
            this.dataUrodzenia = date;
        }

        public void setId(string t)
        {
            this.pesel = t;
        }
    }

    public interface IBaseRepository<T, TEntity> where T : InterfejsID<TEntity>
    {
        public void Create();
        public void Update();
        public void GetAll();
        public void Get();
        public void Delete();
    }

    public interface IBookRepository : IBaseRepository<Book, Int32>
    {

    }

    public interface IPersonRepository : IBaseRepository<Person, String>
    {

    }
}
