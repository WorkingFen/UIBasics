﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsPresentationFoundation.MVVM {
    public class WindowService : IWindowService {
        public void Show(IViewModel viewModel) {
            Window window = new Window();
            window.Height = 450;
            window.Width = 800;
            window.Content = viewModel;
            viewModel.Close = window.Close;
            window.Show();
        }

        public void ShowDialog(IViewModel viewModel) {
            Window window = new Window();
            window.SizeToContent = SizeToContent.WidthAndHeight;
            window.Content = viewModel;
            viewModel.Close = window.Close;
            window.ResizeMode = ResizeMode.NoResize;
            window.ShowDialog();
        }
    }
}
