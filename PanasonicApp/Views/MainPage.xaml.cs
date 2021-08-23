using System;
using System.ComponentModel;
using PanasonicApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PanasonicApp.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MainPageViewModel();
        }
    }
}
