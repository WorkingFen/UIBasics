using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public enum Category
    {
        Rock,
        Pop,
        Rap
    }

    public class Song
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Category Category { get; set; }

        public Song(string title, string author, DateTime release, Category category) 
        {
            Title = title;
            Author = author;
            ReleaseDate = release;
            Category = category;
        }
    }
}
