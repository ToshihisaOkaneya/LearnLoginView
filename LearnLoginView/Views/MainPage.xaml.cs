using System;

using LearnLoginView.ViewModels;

using Windows.UI.Xaml.Controls;

namespace LearnLoginView.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
