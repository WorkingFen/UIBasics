using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WindowsPresentationFoundation.Model;
using WindowsPresentationFoundation.ViewModel;
using WindowsPresentationFoundation.MVVM;

namespace WindowsPresentationFoundation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        public IWindowService WindowService { get; } = new WindowService();
        private SongsModel SongsModel { get; } = new SongsModel();

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            SongsViewModel songsViewModel = new SongsViewModel(SongsModel);
            WindowService.Show(songsViewModel);
        }
    }
}
