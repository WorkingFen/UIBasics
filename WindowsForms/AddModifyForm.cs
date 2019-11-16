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
    public partial class AddModifyForm : Form
    {
        private Song song;
        public string SongTitle { get { return TitleText.Text; } }
        public string SongAuthor { get { return AuthorText.Text; } }
        public DateTime SongDate { get { return DatePicker.Value; } }
        public Category SongCategory { get { return ChangeCategory.Category; } }
        public AddModifyForm(Song song)
        {
            InitializeComponent();
            this.song = song;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            TitleText.CausesValidation = true;
            AuthorText.CausesValidation = true;
            if(ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void AddModifyForm_Load(object sender, EventArgs e)
        {
            if(song != null)
            {
                TitleText.Text = song.Title;
                AuthorText.Text = song.Author;
                DatePicker.Value = song.ReleaseDate;
                ChangeCategory.Category = song.Category;
            }
        }

        private void TitleText_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TitleText.CausesValidation = false;
                string title = TitleText.Text;
                if(title == "")
                    throw new Exception("Title can't be empty");
            }
            catch(Exception exception)
            {
                e.Cancel = true;
                TitleErrorProvider.SetError(TitleText, exception.Message);
            }
        }

        private void TitleText_Validated(object sender, EventArgs e)
        {
            TitleErrorProvider.SetError(TitleText, "");
        }

        private void AuthorText_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                AuthorText.CausesValidation = false;
                string author = AuthorText.Text;
                if(author == "")
                    throw new Exception("Author can't be empty");
            }
            catch (Exception exception)
            {
                e.Cancel = true;
                AuthorErrorProvider.SetError(AuthorText, exception.Message);
            }
        }

        private void AuthorText_Validated(object sender, EventArgs e)
        {
            AuthorErrorProvider.SetError(AuthorText, "");
        }
    }
}
