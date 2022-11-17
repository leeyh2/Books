namespace Books
{
    public class Book
	{
		public string Id { get; set; }
		public string Title { get; set; }
        public List<AuthorBase> Authors { get; set; }
        public string Description { get; set; }
        public string SelfLink { get; set; }

        public Book(string id, string title, List<AuthorBase> author,string description, string selflink)
		{
			Id = id;
			Title = title;
			Authors = author;
			Description = description;
			SelfLink = selflink;
		}
	}
}

