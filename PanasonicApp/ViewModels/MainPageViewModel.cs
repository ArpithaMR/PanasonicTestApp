using System;
using System.Threading.Tasks;
using System.Windows.Input;
using PanasonicApp.Views;
using Xamarin.Forms;

namespace PanasonicApp.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand SearchClickedCommand
        {
            get;
            set;
        }
        public MainPageViewModel()
        {
            SearchClickedCommand = new Command(async () => await StartSearch()); 
        }

        public async Task StartSearch()
        {
            Application.Current.MainPage = new NavigationPage(new ItemsPage())
            {
                BarBackgroundColor = Color.Black,
            };
            
        }
    }
}
