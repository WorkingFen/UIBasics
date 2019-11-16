using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MusicForm : Form
    {
        private Data Data { get; set; }
        private int NoData { get; set; }
        private DateTime filterDate = new DateTime(2000, 1, 1, 0, 0, 0);

        public MusicForm(Data data)
        {
            InitializeComponent();
            Data = data;
            NoData = data.songs.Count;
            NoLabel.Text = NoData.ToString();
        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            AddContextMenuItem_Click(sender, e);
        }

        private void AddStripButton_Click(object sender, EventArgs e)
        {
            AddContextMenuItem_Click(sender, e);
        }

        private void ModifyStripButton_Click(object sender, EventArgs e)
        {
            ModifyContextMenuItem_Click(sender, e);
        }

        private void DeleteStripButton_Click(object sender, EventArgs e)
        {
            DeleteContextMenuItem_Click(sender, e);
        }

        private void AddContextMenuItem_Click(object sender, EventArgs e)
        {
            AddModifyForm addModifyForm = new AddModifyForm(null);
            if(addModifyForm.ShowDialog() == DialogResult.OK)
            {
                Song newSong = new Song(addModifyForm.SongTitle, addModifyForm.SongAuthor, addModifyForm.SongDate, addModifyForm.SongCategory);

                Data.AddSong(newSong);
            }
        }

        private void ModifyContextMenuItem_Click(object sender, EventArgs e)
        {
            if(SongsList.SelectedItems.Count == 1)
            {
                Song song = (Song)SongsList.SelectedItems[0].Tag;
                AddModifyForm addModifyForm = new AddModifyForm(song);
                if(addModifyForm.ShowDialog() == DialogResult.OK)
                {
                    song.Title = addModifyForm.SongTitle;
                    song.Author = addModifyForm.SongAuthor;
                    song.ReleaseDate = addModifyForm.SongDate;
                    song.Category = addModifyForm.SongCategory;

                    Data.UpdateSong(SongsList.SelectedItems[0]);
                }
            }
        }

        private void DeleteContextMenuItem_Click(object sender, EventArgs e)
        {
            if (SongsList.SelectedItems.Count == 1)
            {
                ListViewItem item = SongsList.SelectedItems[0];
                Song song = (Song)SongsList.SelectedItems[0].Tag;
                Data.DeleteSong(song, item);
            }
        }

        private void MusicForm_Load(object sender, EventArgs e)
        {
            UpdateItems();
            Data.AddSongEvent += Data_AddSongEvent;
            Data.UpdateSongEvent += Data_UpdateSongEvent;
            Data.DeleteSongEvent += Data_DeleteSongEvent;
        }

        private void Data_AddSongEvent(Song song)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = song;
            UpdateItem(item);
            switch (FiltrComboBox.Text)
            {
                case "(Brak)":
                    SongsList.Items.Add(item);
                    NoData++;
                    break;
                case "Data >= 2000 rok":
                    if (song.ReleaseDate >= filterDate)
                    {
                        SongsList.Items.Add(item);
                        NoData++;
                    }
                    break;
                case "Data < 2000 rok":
                    if (song.ReleaseDate < filterDate)
                    {
                        SongsList.Items.Add(item);
                        NoData++;
                    }
                    break;
            }
            NoLabel.Text = NoData.ToString();
        }

        private void Data_UpdateSongEvent(ListViewItem item)
        {
            foreach(ListViewItem listItem in SongsList.Items)
                if(item.Tag == listItem.Tag)
                {
                    UpdateItem(listItem);
                    switch (FiltrComboBox.Text)
                    {
                        case "Data >= 2000 rok":
                            if (((Song)listItem.Tag).ReleaseDate < filterDate)
                            {
                                SongsList.Items.Remove(listItem);
                                NoData--;
                            }
                            break;
                        case "Data < 2000 rok":
                            if (((Song)listItem.Tag).ReleaseDate >= filterDate)
                            {
                                SongsList.Items.Remove(listItem);
                                NoData--;
                            }
                            break;
                    }
                    NoLabel.Text = NoData.ToString();
                    return;
                }
            Song song = (Song)item.Tag;
            ListViewItem newItem = new ListViewItem();
            newItem.Tag = song;
            UpdateItem(newItem);
            switch(FiltrComboBox.Text)
            {
                case "Data >= 2000 rok":
                    if (song.ReleaseDate >= filterDate)
                    {
                        SongsList.Items.Add(newItem);
                        NoData++;
                    }
                    break;
                case "Data < 2000 rok":
                    if (song.ReleaseDate < filterDate)
                    {
                        SongsList.Items.Add(newItem);
                        NoData++;
                    }
                    break;
            }
            NoLabel.Text = NoData.ToString();
        }

        private void Data_DeleteSongEvent(ListViewItem item)
        {
            foreach (ListViewItem listItem in SongsList.Items)
                if (item.Tag == listItem.Tag)
                {
                    SongsList.Items.Remove(listItem);
                    break;
                }

            NoData--;
            NoLabel.Text = NoData.ToString();
        }

        private void UpdateItem(ListViewItem item)
        {
            Song song = (Song)item.Tag;
            while(item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = song.Title;
            item.SubItems[1].Text = song.Author;
            item.SubItems[2].Text = song.ReleaseDate.ToShortDateString();
            item.SubItems[3].Text = Enum.GetName(typeof(Category), song.Category);
        }

        private void UpdateItems()
        {
            SongsList.Items.Clear();
            foreach(Song song in Data.songs)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = song;
                UpdateItem(item);
                SongsList.Items.Add(item);
            }
        }

        private void MusicForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(StatusStrip, ((MainForm)this.MdiParent).MainWindowStatus);
        }

        private void MusicForm_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)this.MdiParent).MainWindowStatus, StatusStrip);
        }

        private void MusicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if (((MainForm)this.MdiParent).NoViews <= 1)
                    e.Cancel = true;
                else
                    ((MainForm)this.MdiParent).NoViews--;
            }
        }

        private void FiltrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongsList.Items.Clear();
            NoData = 0;
            foreach (Song song in Data.songs)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = song;
                UpdateItem(item);
                switch (FiltrComboBox.Text)
                {
                    case "(Brak)":
                        SongsList.Items.Add(item);
                        NoData++;
                        break;
                    case "Data >= 2000 rok":
                        if (song.ReleaseDate >= filterDate)
                        {
                            SongsList.Items.Add(item);
                            NoData++;
                        }
                        break;
                    case "Data < 2000 rok":
                        if (song.ReleaseDate < filterDate)
                        {
                            SongsList.Items.Add(item);
                            NoData++;
                        }
                        break;
                }
            }
            NoLabel.Text = NoData.ToString();
        }
    }
}
