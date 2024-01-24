using BibliotekaKlas.Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotekaKlas.Lab8
{
    public class DbPersonRepository : IPersonRepository
    {
        private LibraryDbContext _dbContext;
            public DbPersonRepository(LibraryDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public void Create(Person item)
            {
                using (var dbContext = new LibraryDbContext())
                {
                    dbContext.Persons.Add(item);
                    dbContext.SaveChanges();
                }
            }

            public void Delete(string id)
            {
                var person = _dbContext.Persons.FirstOrDefault(x => x.getId() == id);
                _dbContext.Persons.Remove(person);
                _dbContext.SaveChanges();
            }

            public Person Get(string id)
            {
                return _dbContext.Persons.FirstOrDefault(x => x.getId() == id);
            }

            public List<Person> GetAll()
            {
                return _dbContext.Persons.ToList();
            }

            public void Update(Person item)
            {
                _dbContext.Persons.Update(item);
                _dbContext.SaveChanges();
            }



    }
}
