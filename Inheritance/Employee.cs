using System;

namespace Inheritance
{
    public class Employee
    {
        public Employee(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        protected double vacationDays;

        public virtual void TakeVacation() {}

        public override string ToString()
        {
            return $"[Employee: Name = {Name}]";
        }
    }
}
