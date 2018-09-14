using System;

namespace Inheritance
{
    public class Manager : Employee
    {
        public Manager(string name, bool hasCar) : base(name)
        {
            CompanyCar = hasCar;
        }

        public bool CompanyCar { get; set; }

        public override void TakeVacation()
        {
            vacationDays += 15;
        }

        public override string ToString()
        {
            return $"[Manager. Name: {Name}, CompanyCar: {CompanyCar}, Vacation: {vacationDays}]";
        }
    }
}
