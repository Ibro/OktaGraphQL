using Api.Database;
using GraphQL.Types;

namespace Api.GraphQL
{
	public class BookType : ObjectGraphType<Book>
	{
		public BookType()
		{
			Name = "Book";

			Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Book.");
			Field(x => x.Name).Description("The name of the Book");
			Field(x => x.Genre).Description("Book genre");
			Field(x => x.Published).Description("If the book is published or not");
		}
	}
}