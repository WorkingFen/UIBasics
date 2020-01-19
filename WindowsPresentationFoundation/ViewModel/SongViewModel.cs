using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsPresentationFoundation.MVVM;
using WindowsPresentationFoundation.Model;

namespace WindowsPresentationFoundation.ViewModel {
    public class SongViewModel : IViewModel {
        private SongsModel SongsModel { get; }
        private Song Song { get; }
        public Action Close { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Category Category { get; set; }

        public RelayCommand<SongViewModel> OkCommand { get; } = new RelayCommand<SongViewModel>(
            (studentViewModel) => { studentViewModel.Ok(); }
        );

        public RelayCommand<SongViewModel> CancelCommand { get; } = new RelayCommand<SongViewModel>(
            (studentViewModel) => { studentViewModel.Cancel(); }
        );

        public SongViewModel(SongsModel songsModel, Song song) {
            SongsModel = songsModel;
            Song = song;
            if(Song != null) {
                Title = Song.Title;
                Author = Song.Author;
                ReleaseDate = Song.ReleaseDate;
                Category = Song.Category;
            }
            else {
                ReleaseDate = DateTime.Now;
            }
        }

        public void Ok() {
            if(Song == null) {
                Song song = new Song(Title, Author, ReleaseDate, Category);
                SongsModel.Songs.Add(song);
            }
            else {
                Song.Title = Title;
                Song.Author = Author;
                Song.ReleaseDate = ReleaseDate;
                Song.Category = Category;
            }
            Close?.Invoke();
        }

        public void Cancel() => Close?.Invoke();
    }
}
