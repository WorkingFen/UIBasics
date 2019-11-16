using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public class Data
    {
        public List<Song> songs = new List<Song>();

        public event Action<Song> AddSongEvent;
        public event Action<ListViewItem> UpdateSongEvent;
        public event Action<ListViewItem> DeleteSongEvent;

        public void AddSong(Song song)
        {
            songs.Add(song);
            AddSongEvent?.Invoke(song);
        }

        public void UpdateSong(ListViewItem item)
        {
            UpdateSongEvent?.Invoke(item);
        }

        public void DeleteSong(Song song, ListViewItem item)
        {
            songs.Remove(song);
            DeleteSongEvent?.Invoke(item);
        }
    }
}
