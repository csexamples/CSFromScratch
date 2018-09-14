using System;

namespace Arrays
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Person[] people = new Person[7];

            people[0] = new Person() { Name = "John" };
            people[1] = new Person() { Name = "Paul" };
            people[2] = new Person() { Name = "George" };
            people[3] = new Person() { Name = "Ringo" };
            people[4] = new Person() { Name = "Frodo" };
            people[5] = new Person() { Name = "Merry" };
            people[6] = new Person() { Name = "Pippin" };

            foreach(Person person in people)
            {
                Console.WriteLine($"Name = {person.Name}");
            }
        }
    }
}
