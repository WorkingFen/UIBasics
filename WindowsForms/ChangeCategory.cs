using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ChangeCategory : UserControl
    {
        private Category category;

        [Editor(typeof(CategoryEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Category")]
        [Browsable(true)]
        public Category Category 
        { 
            get { return category; } 
            set { category = value; LoadValues(); Invalidate(); } 
        }
        public ChangeCategory()
        {
            InitializeComponent();
            Category = Category.Rock;
        }
        public ChangeCategory(Category category)
        {
            InitializeComponent();
            Category = category;
        }

        private void LoadValues()
        {
            switch (category)
            {
                case Category.Rock:
                    CategoryText.Text = "Rock";
                    CategoryPicture.Image = global::WindowsForms.Properties.Resources.Rock;
                    break;
                case Category.Rap:
                    CategoryText.Text = "Rap";
                    CategoryPicture.Image = global::WindowsForms.Properties.Resources.Rap;
                    break;
                case Category.Pop:
                    CategoryText.Text = "Pop";
                    CategoryPicture.Image = global::WindowsForms.Properties.Resources.Pop;
                    break;
                default:
                    break;
            }
        }

        private void CategoryPicture_Click(object sender, EventArgs e)
        {
            switch(category)
            {
                case Category.Pop:
                    Category = Category.Rock;
                    break;
                case Category.Rock:
                    Category = Category.Rap;
                    break;
                case Category.Rap:
                    Category = Category.Pop;
                    break;
                default:
                    break;
            }
        }
    }
}
