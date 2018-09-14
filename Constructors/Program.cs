using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(5, 101);
            Console.WriteLine($"emp years of servie: {emp.YearsOfService}");
            Console.WriteLine($"emp office: {emp.Office}");

            Employee emp2 = new Employee();
            emp2.YearsOfService = 15;
            emp2.Office = 201;
            Console.WriteLine($"emp2 years of servie: {emp2.YearsOfService}");
            Console.WriteLine($"emp2 office: {emp2.Office}");

            Employee emp3 = new Employee()
            {
                YearsOfService = 20,
                Office = 301
            };
            Console.WriteLine($"emp3 years of servie: {emp3.YearsOfService}");
            Console.WriteLine($"emp3 office: {emp3.Office}");
        } 
    }
}
