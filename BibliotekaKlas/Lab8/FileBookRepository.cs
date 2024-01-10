using System;
using System.Collections.Generic;
using System.Text;
using BibliotekaKlas.Lab5;
using System.IO;
using System.Text.Json;

namespace BibliotekaKlas.Lab8
{
    public class FileBookRepository : IBookRepository
    {
        const string fileName = "books.json";

        public void Create(Book item)
        {
            var list = this.GetAll();
            item.setId(list.Count + 1);
            list.Add(item);

            this.WriteFile(list);
        }

        public void Delete(int id)
        {
            var data = this.GetAll();
            foreach (Book book in data)
            {
                if (book.getId() == id)
                {
                    data.Remove(book);
                    break;
                }
            }
            this.WriteFile(data);
        }

        public Book Get(int id)
        {
            foreach(Book book in this.GetAll())
            {
                if(book.getId() == id)
                {
                    return book;
                }
            }
            return new Book();
        }

        public List<Book> GetAll()
        {
            return this.ReadFile();
        }

        public void Update(Book item)
        {
            var data = this.GetAll();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].getId() == item.getId())
                {
                    data[i] = item;
                    break;
                }
            }
            this.WriteFile(data);
        }

        private List<Book> ReadFile()
        {
            if (File.Exists(fileName))
            {
                var content = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<List<Book>>(content) ?? new List<Book>();
            }
            return new List<Book>();
        }

        private void WriteFile(List<Book> data)
        {
            var content = JsonSerializer.Serialize(data);

            File.Create(fileName);
            File.WriteAllText(fileName, content);
        }
    }
}
