using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using BibliotekaKlas.Lab5;

namespace BibliotekaKlas.Lab8
{
    [Table("BorrowedBooks")]
    public class BorrowedBook : InterfejsID<Int32>, InterfejsDataUtworzenia
    {
        [Key]
        public long id { get; set; }

        public DateTime CreationTime { get; set; } = DateTime.Now;


        public DateTime getDate()
        {
            throw new NotImplementedException();
        }

        public int getId()
        {
            throw new NotImplementedException();
        }

        public void setDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void setId(int t)
        {
            throw new NotImplementedException();
        }
    }
}
