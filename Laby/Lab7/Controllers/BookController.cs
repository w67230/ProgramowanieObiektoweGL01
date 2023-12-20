using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotekaKlas.Lab5;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab7.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }


        [HttpGet]
        public Book Get(int id)
        {
            return this.bookRepository.Get();
        }

        [HttpPost]
        public void Create(Book input)
        {
            this.bookRepository.Create(input);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            this.bookRepository.Delete(id);
        }

        [HttpGet]
        public List<Book> GetAll()
        {
            return this.bookRepository.GetAll();
        }

        [HttpPut]
        public void Update(Book book)
        {
            this.bookRepository.Update(book);
        }

    }
}