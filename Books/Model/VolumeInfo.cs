using System;
namespace Books
{
	public class VolumeInfo
	{
        
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string Description { get; set; }
        
        public VolumeInfo(string title, string[] authors, string description)
		{
            
            Title = title;
            Authors = authors;
            Description = description;
          
        }
	}
}

