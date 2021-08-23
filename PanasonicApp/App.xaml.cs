using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PanasonicApp.Services;
using PanasonicApp.Views;

namespace PanasonicApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<SearchService>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
