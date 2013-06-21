using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Workflow
    {
        private DatabaseContext db = new DatabaseContext();

        public bool SavePerson(Person p)
        {
            db.People.Add(p);
            db.SaveChanges();

            return true;
        }

        public Person FindPerson(string name)
        {
            return db.People.Where(table => table.Name == name).FirstOrDefault();
        }

        public void RemovePerson(string name)
        {
            var people = db.People.Where(table => table.Name == name);
            
            foreach (var person in people)
            {
                db.People.Remove(person);
            }

            db.SaveChanges();
        }

        public List<Person> FindAllPeople()
        {
            return db.People.ToList();
        }

        public string ConnectionString
        {
            get
            {
                return db.Database.Connection.ConnectionString;
            }
            private set{}
        }

    }
}
