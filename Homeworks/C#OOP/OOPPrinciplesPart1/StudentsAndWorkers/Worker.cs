using System.Runtime.CompilerServices;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {

        public Worker(string firstName, string lastName, double weekSalary) : base(firstName, lastName)
        {
            this.WorkHoursPerDay = 8;
            this.WeekSalary = weekSalary;
            this.MoneyPerHour = CalculateMoneyPerHour();
        }

        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; private set; }
        public double MoneyPerHour { get; private set; }

        private double CalculateMoneyPerHour()
        {
            return (this.WeekSalary/5)/WorkHoursPerDay;
        }
    }
}