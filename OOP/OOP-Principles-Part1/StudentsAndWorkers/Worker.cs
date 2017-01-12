namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; private set; }

        public double WorkHoursPerDay { get; private set; }

        public double MoneyPerHour()
        {
            double result;

            result = this.WeekSalary / (this.WorkHoursPerDay * 5); ////5 days workweek

            return result;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {string.Format("${0:f2}", this.MoneyPerHour())}";
        }
    }
}
