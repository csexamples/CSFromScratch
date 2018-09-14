using System;

namespace Inheritance
{
    public class Worker : Employee
    {
        public Worker(string name, double wage) : base(name)
        {
            HourlyWage = wage;
        }

        public double HourlyWage { get; set; }

        public override void TakeVacation()
        {
            vacationDays += 10;
        }

        public override string ToString()
        {
            return $"[Worker. Name: {Name}, HourlyWage: {HourlyWage}, Vacation: {vacationDays}]";
        }
    }
}
