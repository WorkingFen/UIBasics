using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WindowsPresentationFoundation.Model;
using WindowsPresentationFoundation.MVVM;

namespace WindowsPresentationFoundation.Control {
    /// <summary>
    /// Interaction logic for ChangeCategory.xaml
    /// </summary>
    public partial class ChangeCategory : UserControl {
        private Category category;
        public Category Category {
            get { return (Category)GetValue(CategoryProperty); }
            set { SetValue(CategoryProperty, value); category = value; LoadValues(); }
        }
        public static readonly DependencyProperty CategoryProperty =
            DependencyProperty.Register(
                "Category",
                typeof(Category),
                typeof(ChangeCategory),
                new PropertyMetadata(default(Category), OnCategoryChanged));

        private static void OnCategoryChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            ChangeCategory source = d as ChangeCategory;
            source.Category = (Category)e.NewValue;
        }

        public ChangeCategory() {
            InitializeComponent();
            Category = Category.Rock;
        }
        public ChangeCategory(Category category) {
            InitializeComponent();
            Category = category;
        }

        private void LoadValues() {
            switch(category) {
                case Category.Rock:
                    CategoryText.Text = "Rock";
                    CategoryPicture.Source = (ImageSource)new BitmapToImageSourceConverter().Convert(Properties.Resources.Rock, null, null, null);
                    break;
                case Category.Rap:
                    CategoryText.Text = "Rap";
                    CategoryPicture.Source = (ImageSource)new BitmapToImageSourceConverter().Convert(Properties.Resources.Rap, null, null, null);
                    break;
                case Category.Pop:
                    CategoryText.Text = "Pop";
                    CategoryPicture.Source = (ImageSource)new BitmapToImageSourceConverter().Convert(Properties.Resources.Pop, null, null, null);
                    break;
                default:
                    break;
            }
        }

        private void Switch(object sender, MouseButtonEventArgs e) {
            switch(category) {
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
