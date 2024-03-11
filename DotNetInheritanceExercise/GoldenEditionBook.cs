namespace DotNetInheritanceExercise
{
    internal class GoldenEditionBook : Book
    {
        protected override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            }
        }
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {
        }

    }
}
