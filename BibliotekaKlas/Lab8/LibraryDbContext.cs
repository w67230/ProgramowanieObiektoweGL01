using BibliotekaKlas.Lab5;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekaKlas.Lab8
{
    public class LibraryDbContext : DbContext
    {
        private readonly string DbPath = "F:\\ProgramowanieObiektoweGL01\\Laby\\Lab7";


        public DbSet<Book> Books { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
