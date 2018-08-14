using System;
using LearnLoginView.Models;
using Prism.Windows.Mvvm;

namespace LearnLoginView.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public User User { get; } = new User();

        public MainViewModel()
        {
        }
    }
}
