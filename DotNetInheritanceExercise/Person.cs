using System.Text;

namespace DotNetInheritanceExercise
{
    internal class Person
    {
        private string name;
        private int age;
        protected virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                name = value;
            }
        }
        protected virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                age = value;
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        // Does this actually offer any performance advantage over $"Name: {Name}, Age: {Age}"? There is only one string object either way, surely?
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();
        }
    }
}
