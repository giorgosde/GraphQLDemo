using GraphQLDemo.Types;

namespace GraphQLDemo.Queries
{
    public class Query
    {
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IEnumerable<Book> GetBook()
            => new List<Book>()
            {
                new Book()
                {
                    Title = "C# in depth.",
                    Author = new Author
                    {
                        Name = "Jon Skeet"
                    }
                },
                new Book()
                {
                    Title = "Foo",
                    Author = new Author
                    {
                        Name = "Bar"
                    }
                }
            };
    }
}
