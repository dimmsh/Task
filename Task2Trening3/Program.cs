using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2Trening3
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }

        class Program
        {
            static void Main(string[] args)
            {

                Person pers1 = new Person()
                {
                    Name = "Andriy",
                    Age = 25,
                   // PhoneNumbers

                };
                Person pers2 = new Person()
                {
                    Name = "Petro",
                    Age = 29,
                    //PhoneNumbers = "0 32 298 44 55"
                };
                Person pers3 = new Person()
                {
                    Name = "Danylo",
                    Age = 42,
                    //PhoneNumbers = "0 32 298 44 55"
                };
                Person pers4 = new Person()
                {
                    Name = "Sergiy",
                    Age = 19,
                   // PhoneNumbers = "0 32 298 44 55"
                };
                Person pers5 = new Person()
                {
                    Name = "Oleksandr",
                    Age = 50,
                   // PhoneNumbers = "0 32 298 44 55"
                };
                Person pers6 = new Person()
                {
                    Name = "Stepan",
                    Age = 30,
                   // PhoneNumbers = "0 32 298 44 55"
                };
                Person pers7 = new Person()
                {
                    Name = "Slavik",
                    Age = 25,
                   // PhoneNumbers = "0 32 298 44 55"
                };

                List<Person> pers = new List<Person>();
                pers.Add(pers1);
                pers.Add(pers2);
                pers.Add(pers3);
                pers.Add(pers4);
                pers.Add(pers5);


               //var pers = new List<Person>();
               List<Person> list2 = new List<Person>{ pers6, pers7 };

               pers.AddRange(list2);

                foreach (Person c in pers)
                {
                    Console.WriteLine("Name = {0}, Age = {1}", c.Name, c.Age);
                }
                Console.ReadKey();

            }
        }
    }
}
