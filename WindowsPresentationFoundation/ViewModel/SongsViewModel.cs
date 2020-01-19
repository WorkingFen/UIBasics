using System;
using System.Linq;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using WindowsPresentationFoundation.MVVM;
using WindowsPresentationFoundation.Model;

namespace WindowsPresentationFoundation.ViewModel {
    public class SongsViewModel : IViewModel, INotifyPropertyChanged {
        private SongsModel SongsModel { get; }
        private readonly CollectionViewSource collectionViewSource;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICollectionView Songs { get; }

        public string NoSongs { get { return "Count: " + collectionViewSource.View.Cast<Song>().Count() + "/" + collectionViewSource.View.SourceCollection.Cast<Song>().Count(); } }

        private Song selectedSong;
        public Song SelectedSong {
            get { return selectedSong; }
            set {
                selectedSong = value;
                EditCommand.NotifyCanExecuteChanged();
                DeleteCommand.NotifyCanExecuteChanged();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedSong)));
            }
        }

        private string filterText = "";
        public string FilterText {
            get { return filterText; }
            set {
                filterText = value;
                UpdateFilter();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FilterText)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NoSongs)));
            }
        }
        private void UpdateFilter() {
            collectionViewSource.View.Refresh();
        }
        bool FilterSong(Song song) {
            return song.Title.Contains(FilterText) || song.Author.Contains(FilterText);
        }

        public Action Close { get; set; }

        private RelayCommand<object> addCommand;
        public RelayCommand<object> AddCommand => (addCommand = addCommand ?? new RelayCommand<object>(o => AddSong()));

        private RelayCommand<object> editCommand;
        public RelayCommand<object> EditCommand => (editCommand = editCommand ?? new RelayCommand<object>(o => EditSong(SelectedSong), o => SelectedSong != null));
        
        private RelayCommand<object> deleteCommand;
        public RelayCommand<object> DeleteCommand => (deleteCommand = deleteCommand ?? new RelayCommand<object>(o => DeleteSong(SelectedSong), o => SelectedSong != null));

        private RelayCommand<object> addNewViewCommand;
        public RelayCommand<object> AddNewViewCommand => (addNewViewCommand = addNewViewCommand ?? new RelayCommand<object>(o => AddNewView()));

        public SongsViewModel(SongsModel songsModel) {
            SongsModel = songsModel;
            collectionViewSource = new CollectionViewSource { Source = SongsModel.Songs };
            collectionViewSource.View.Filter = (o) => FilterSong((Song)o);
            Songs = collectionViewSource.View;
        }
        public void AddSong() {
            SongViewModel songViewModel = new SongViewModel(SongsModel, null);
            ((App)Application.Current).WindowService.ShowDialog(songViewModel);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NoSongs)));
        }

        public void EditSong(Song song) {
            if(song != null) {
                SongViewModel songViewModel = new SongViewModel(SongsModel, song);
                ((App)Application.Current).WindowService.ShowDialog(songViewModel);
            }
            UpdateFilter();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NoSongs)));
        }
        public void DeleteSong(Song song) {
            if(song != null)
                SongsModel.Songs.Remove(song);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NoSongs)));
        }

        public void AddNewView() {
            SongsViewModel songsViewModel = new SongsViewModel(SongsModel);
            ((App)Application.Current).WindowService.Show(songsViewModel);
        }
    }
}
