using System;

namespace Constructors
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(int years, int office)
        {
            YearsOfService = years;
            Office = office;
        }

        public int YearsOfService { get; set; }
        public int Office { get; set; }
    }
}
