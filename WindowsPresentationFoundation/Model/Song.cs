using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPresentationFoundation.Model {
    public enum Category {
        Rock,
        Pop,
        Rap
    }

    public class Song : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private string title;
        public string Title {
            get { return title; }
            set { title = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title")); } 
        }

        private string author;
        public string Author {
            get { return author; }
            set { author = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Author")); }
        }

        private DateTime releaseDate;
        public DateTime ReleaseDate {
            get { return releaseDate; }
            set { releaseDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReleaseDate")); }
        }

        private Category category;
        public Category Category {
            get { return category; }
            set { category = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Category")); }
        }

        public Song(string title, string author, DateTime release, Category category) {
            Title = title;
            Author = author;
            ReleaseDate = release;
            Category = category;
        }
    }
}
