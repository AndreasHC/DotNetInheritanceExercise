namespace DotNetInheritanceExercise
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        protected decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value <= 10)
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                weekSalary = value;
            }
        }
        protected decimal WorkHoursPerDay
        {
            get
            {
                return workHoursPerDay;
            }
            set
            {
                if(value < 1 ||value > 12)
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                workHoursPerDay = value;
            }
        }
        protected decimal SalaryPerHour
        { get
            {
                return WeekSalary / workHoursPerDay / 5;
            }
        }
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay):base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Week Salary: {WeekSalary:f2}{Environment.NewLine}Hours per day: {WorkHoursPerDay:f2}{Environment.NewLine}Salary per hour: {SalaryPerHour:f2}";
        }
    }
}
