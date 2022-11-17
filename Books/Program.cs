using System.Text.Json;
using System.Net;

namespace Books
{
    public class Program
    {
        static void Main(string[] args)
        {
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var filePath = root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}Nightbitch.json";
            var dataPath = root + $"{Path.DirectorySeparatorChar}Data";

            // create options JSONSerializer must follow
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var books = new List<Book>();
            foreach (string fileName in Directory.GetFiles(dataPath))
            {
                // set JSON string to empty and set up streamreader based on data file's path
                string jsonString = string.Empty;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    jsonString = sr.ReadToEnd();
                }

                // deserialize (read) JSON and create object(s) based on its information
                var book = JsonSerializer.Deserialize<Book>(jsonString, options);
                books.Add(book);
            }
        }
    }
}