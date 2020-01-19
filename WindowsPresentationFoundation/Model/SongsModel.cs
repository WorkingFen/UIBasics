using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPresentationFoundation.Model {
    public class SongsModel {
        public ObservableCollection<Song> Songs { get; private set; } = new ObservableCollection<Song>();
        public SongsModel() {
            Songs.Add(new Song("Music To Be Murdered By", "Eminem", new DateTime(2020, 1, 17, 0, 0, 0), Category.Rap));
            Songs.Add(new Song("Bleach", "Nirvana", new DateTime(1989, 6, 15, 0, 0, 0), Category.Rock));
            Songs.Add(new Song("When We All Fall Asleep, Where Do We Go?", "Billie Eilish", new DateTime(2019, 3, 29, 0, 0, 0), Category.Pop));
        }
    }
}
