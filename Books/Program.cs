using System.Text.Json;
using System.Net;
using System.Collections.Generic;

namespace Books
{
    public class Program
    {
        static void Main(string[] args)
        {
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var filePath = root + $"{Path.DirectorySeparatorChar}myBook.json";
            var dataPath = root + $"{Path.DirectorySeparatorChar}data";

            // create options JSONSerializer must follow
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var books = new List<Book>();
            Book book;
            foreach (string fileName in Directory.GetFiles(dataPath))
            {
                // set JSON string to empty and set up streamreader based on data file's path
                string jsonString = string.Empty;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    jsonString = sr.ReadToEnd();

                }

                // deserialize (read) JSON and create object(s) based on its information
                book = JsonSerializer.Deserialize<Book>(jsonString, options);
                Console.WriteLine(book);
                books.Add(book);
            }
            
            
            string[] authors = { "Yoon Lee" };
            VolumeInfo info = new("Please Work", authors, "HI HI HI");

            var realItem = new Items(info, "2942", "www.PleaseWork.com");
            Items[] items = { realItem };
            var myBook = new Book(items);

            string jsonString2 = JsonSerializer.Serialize(myBook, options);
            using (StreamWriter sw = new StreamWriter(filePath))
            {
               sw.WriteLine(jsonString2);

            }

        }

    }
}    
