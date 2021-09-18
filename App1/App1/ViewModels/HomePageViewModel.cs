using App1.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App1.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        int i = 0;

        string _Result = "Click Me";
        public string Result
        {
            get => _Result;
            set=>SetProperty(ref _Result, value);
        }

        public ICommand IncreaseCount { get; }
        public HomePageViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }


        private void OnIncrease()
        {
            i++;
            Result = $"You Clicked Me {i} times";
        }
    }
}
