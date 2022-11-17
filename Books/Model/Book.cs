namespace Books
{
    public class Book
	{
		
		public List<Item> Item { get; set; }

        public Book(List<Item> item)
		{
			Item = item;
		}
	}
}

