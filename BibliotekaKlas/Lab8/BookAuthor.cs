using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using BibliotekaKlas.Lab5;

namespace BibliotekaKlas.Lab8
{
    [Table("BookAuthor")]
    public class BookAuthor : InterfejsID<long>, InterfejsDataUtworzenia
    {
        [Key]
        public long id { get; set; }

        public DateTime CreationTime { get; set; } = DateTime.Now;

        public int BookId { get; set; }
        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }

        public long PersonId { get; set; }
        public Person Person { get; set; }


        public DateTime getDate()
        {
            return this.CreationTime;
        }

        public long getId()
        {
            return this.id;
        }

        public void setDate(DateTime date)
        {
            this.CreationTime = date;
        }

        public void setId(long t)
        {
            this.id = t;
        }
    }
}
