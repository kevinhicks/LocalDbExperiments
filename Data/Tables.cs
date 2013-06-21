using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base ("DatabaseContext") {
            Console.Write(Database.Connection.ConnectionString);
        }
                
        public DbSet<Person> People { get; set; }
    }
}
