using GraphQLDemo.Types;

namespace GraphQLDemo.Mutations
{
    public class Mutation
    {
        public async Task<AddBookPayload> AddBook(AddBookInput input)
        {
            var book = new Book()
            {
                Title = input.Title
            };

            // Business logic to store the book....

            return await Task.FromResult(new AddBookPayload(book));
        }

        public record AddBookInput(string Title);

        public record AddBookPayload(Book book);
    }
}
