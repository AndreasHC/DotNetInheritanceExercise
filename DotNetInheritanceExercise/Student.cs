namespace DotNetInheritanceExercise
{
    public class Student : Human
    {
        private string facultyNumber;
        protected String FacultyNumber
        {
            get
            {
                return facultyNumber;
            }
            set
            {
                if (value.Length > 10 || value.Length < 5 || !value.All(Char.IsLetterOrDigit))
                    throw new ArgumentException("Invalid faculty number!");
                facultyNumber = value;
            }
        }
        public Student(string firstName, string LastName, string facultyNumber) : base(firstName, LastName)
        {
            FacultyNumber = facultyNumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}FacultyNumber: {FacultyNumber}";
        }
    }
}
