using BibliotekaKlas.Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotekaKlas.Lab8
{
    public class DbBookRepository : IBookRepository
    {
        private LibraryDbContext _dbContext;
            public DbBookRepository(LibraryDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public void Create(Book item)
            {
                using (var dbContext = new LibraryDbContext())
                {
                    dbContext.Books.Add(item);
                    dbContext.SaveChanges();
                }
            }

            public void Delete(int id)
            {
                var book = _dbContext.Books.FirstOrDefault(x => x.id == id);
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }

            public Book Get(int id)
            {
                return _dbContext.Books.FirstOrDefault(x => x.id == id);
            }

            public List<Book> GetAll()
            {
                return _dbContext.Books.ToList();
            }

            public List<Book> GetBooksByAuthor(string author)
            {
                return _dbContext.Books.Where(x => x.autor.ToLower().Contains(author.ToLower())).ToList();
            }

            public List<Book> GetBooksByPublishYear(int year)
            {
                return _dbContext.Books.Where(x => x.rokWydania == year).ToList();
            }

            public void Update(Book item)
            {
                _dbContext.Books.Update(item);
                _dbContext.SaveChanges();
            }



    }
}
