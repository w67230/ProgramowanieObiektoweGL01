using System;
using System.Collections.Generic;
using System.Text;
using BibliotekaKlas.Lab5;

namespace BibliotekaKlas.Lab6
{

   
    public class BookRepository : IBookRepository
    {

        private List<Book> data = new List<Book>();
        public void Create(Book item)
        {
            item.setId(data.Count + 1);
            this.data.Add(item);
        }

        public void Delete(int id)
        {
            foreach(Book book in data)
            {
                if(book.getId() == id)
                {
                    data.Remove(book);
                    break;
                }
            }
        }

        public Book Get(int id)
        {
            foreach(Book book in data)
            {
                if(book.getId() == id)
                {
                    return book;
                }
            }
            Book nowa = new Book();
            nowa.setId(id);
            return nowa;
        }

        public List<Book> GetAll()
        {
            return this.data;
        }

        public void Update(Book item)
        {
            for(int i = 0; i < this.data.Count; i++)
            {
                if(this.data[i].getId() == item.getId())
                {
                    this.data[i] = item;
                    break;
                }
            }
        }
    }

    public class PersonRepository : IPersonRepository
    {

        private List<Person> data = new List<Person>();
        public void Create(Person item)
        {
            this.data.Add(item);
        }

        public void Delete(string id)
        {
            foreach (Person person in data)
            {
                if (person.getId() == id)
                {
                    data.Remove(person);
                    break;
                }
            }
        }

        public Person Get(string id)
        {
            foreach (Person person in data)
            {
                if (person.getId() == id)
                {
                    return person;
                }
            }
            Person nowa = new Person(id);
            return nowa;
        }

        public List<Person> GetAll()
        {
            return this.data;
        }

        public void Update(Person item)
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                if (this.data[i].getId() == item.getId())
                {
                    this.data[i] = item;
                    break;
                }
            }
        }
    }
}
