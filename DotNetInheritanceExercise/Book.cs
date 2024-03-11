using System.Text;

namespace DotNetInheritanceExercise
{
    public class Book
    {

        private string author;
        private string title;
        private decimal price;
        protected virtual string Author
        {
            get { return author; }
            set
            {
                string[] segments = value.Split(' ');
                if (segments.Length >= 2)
                    if (Char.IsDigit(segments[1][0]))
                        throw new ArgumentException("Author not valid!");
                author = value;
            }
        }
        protected virtual string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Title not valid!");
                title = value;
            }
        }
        protected virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price not valid!");
                price = value;
            }
        }
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
