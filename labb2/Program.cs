using System;
using System.Collections.Generic;
using System.Linq;
namespace labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { name = "adil", age = 17, profession = "engeneer" };
            Person person2 = new Person() { name = "sadiq", age = 23, profession = "devloper" };
            Person person3 = new Person() { name = "sabir", age = 28, profession = "teacher" };
            var list =new List<Person>() {person1,person2,person3 };
            foreach (Person item in INSPECTIONS(list))
            {
                Console.WriteLine(item.ToString());
            }
            
        }
        static IEnumerable<Person> INSPECTIONS(List<Person> person)
        {
          
           return person.Where(pres => pres.age >18);
          
        }
    }

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string profession { get; set; }

        public override string ToString()
        {
            return $"Name:{name}  Age:{age}  Profession:{profession}" ;
        }
    }
}
