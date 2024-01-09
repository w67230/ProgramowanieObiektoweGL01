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
    public class PersonController : ControllerBase
    {

        private readonly IPersonRepository personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }


        [HttpGet]
        public Person Get(string id)
        {
            return this.personRepository.Get(id);
        }

        [HttpPost]
        public void Create(Person input)
        {
            this.personRepository.Create(input);
        }

        [HttpDelete]
        public void Delete(string id)
        {
            this.personRepository.Delete(id);
        }

        [HttpGet]
        public List<Person> GetAll()
        {
            return this.personRepository.GetAll();
        }

        [HttpPut]
        public void Update(Person person)
        {
            this.personRepository.Update(person);
        }

    }
}