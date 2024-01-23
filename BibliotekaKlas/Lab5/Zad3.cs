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
        public int id { get; set; }
        public string tytul { get; set; }
        public string autor { get; set; }
        public DateTime dataUtworzenia { get; set; }

        public int rokWydania { get; set; }

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
        private string pesel { get; set; }
        private DateTime dataUrodzenia;
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public List<Book> listaWypozyczonychKsiazek { get; set; } = new List<Book>();

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
        public void Create(T item);
        public void Update(T item);
        public List<T> GetAll();
        public T Get(TEntity id);
        public void Delete(TEntity id);
    }

    public interface IBookRepository : IBaseRepository<Book, Int32>
    {

    }

    public interface IPersonRepository : IBaseRepository<Person, String>
    {

    }
}
