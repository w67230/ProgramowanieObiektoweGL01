using System;
using System.Collections.Generic;
using System.Text;
using BibliotekaKlas.Lab5;
using System.IO;
using System.Text.Json;

namespace BibliotekaKlas.Lab8
{
    public class FilePersonRepository : IPersonRepository
    {
        const string fileName = "persons.json";

        public void Create(Person item)
        {
            var list = this.GetAll();
            Random random = new Random();
            item.setId(Convert.ToString(random.Next(0, 10000000)));
            list.Add(item);

            this.WriteFile(list);
        }

        public void Delete(string id)
        {
            var data = this.GetAll();
            foreach (Person person in data)
            {
                if (person.getId() == id)
                {
                    data.Remove(person);
                    break;
                }
            }
            this.WriteFile(data);
        }

        public Person Get(string id)
        {
            foreach (Person person in this.GetAll())
            {
                if (person.getId() == id)
                {
                    return person;
                }
            }
            return new Person();
        }

        public List<Person> GetAll()
        {
            return this.ReadFile();
        }

        public void Update(Person item)
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

        private List<Person> ReadFile()
        {
            if (File.Exists(fileName))
            {
                string content = File.ReadAllText(fileName);
                if (content == null || content == "") return new List<Person>();
                return JsonSerializer.Deserialize<List<Person>>(content);
            }
            return new List<Person>();
        }

        private void WriteFile(List<Person> data)
        {
            string content = JsonSerializer.Serialize(data);

            //File.Create(fileName);
            File.WriteAllText(fileName, content);
        }
    }
}
