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
    public partial class MainForm : Form
    {
        public int NoViews = 1;
        public bool ToBeClosed = false;
        Data Data = new Data();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MusicForm musicForm = new MusicForm(Data);
            musicForm.MdiParent = this;
            musicForm.Show();
        }

        private void NewViewMenuItem_Click(object sender, EventArgs e)
        {
            MusicForm musicForm = new MusicForm(Data);
            musicForm.MdiParent = this;
            musicForm.Show();
            NoViews++;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult message = MessageBox.Show("Czy zakończyć działanie programu?", "Zamykanie", MessageBoxButtons.YesNo);
            ToBeClosed = (message == DialogResult.Yes);
            e.Cancel = !ToBeClosed;
        }
    }
}
