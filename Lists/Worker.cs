using System;
using System.Collections.Generic;

namespace Lists
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            List<Person> people = new List<Person>();

            Person john = new Person() { Name = "John" };
            people.Add(john);

            people.Add(new Person() { Name = "Paul" });
            people.Add(new Person() { Name = "George" });
            people.Add(new Person() { Name = "Ringo" });
            people.Add(new Person() { Name = "Frodo" });
            people.Add(new Person { Name = "Merry" });
            people.Add(new Person { Name = "Pippin" });
            people.Add(new Person { Name = "Gandalf" });

            foreach(Person person in people)
            {
                Console.WriteLine($"Name = {person.Name}");
            }
        }
    }
}
