using System;
using System.Collections.Generic;
using System.Text;
using BibliotekaKlas.Lab5;

namespace BibliotekaKlas.Lab6
{

    // todo
    public class BookRepository : IBookRepository
    {

        private List<Book> data = new List<Book>();
        public void Create(Book item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Book Get()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new NotImplementedException();
        }
    }

    public class PersonRepository : IPersonRepository
    {
        public void Create(Person item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Person Get()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Person item)
        {
            throw new NotImplementedException();
        }
    }
}
