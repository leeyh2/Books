using System;
namespace Books
{
	public class AuthorBase
	{
		public Authors Author { get; set; }
		public AuthorBase(Authors author)
		{
			Author = author;
		}
	}
}

