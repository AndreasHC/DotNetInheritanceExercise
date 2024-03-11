namespace DotNetInheritanceExercise
{
    public class Human
    {
        private string firstName;
        private string lastName;
        protected string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length < 4)
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                if (!Char.IsUpper(value[0]))
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                firstName = value;
            }
        }
        protected string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName ");
                if (!Char.IsLetter(value[0]))
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                lastName = value;
            }
        }
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return $"First name: {FirstName}{Environment.NewLine}LastName: {LastName}";
        }
    }
}
