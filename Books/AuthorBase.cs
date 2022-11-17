using System;
namespace Books
{
	public class AuthorBase
	{
		public Author Author { get; set; }
		public AuthorBase(Author author)
		{
			Author = author;
		}
	}
}

