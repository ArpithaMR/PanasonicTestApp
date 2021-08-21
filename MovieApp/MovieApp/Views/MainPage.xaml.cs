
using Prism.Navigation;
using System;
using Xamarin.Forms;

namespace MovieApp.Views
{
    public partial class MainPage:ContentPage
    {
         INavigationService _navigationService;
                                                                                                                                                                                                                                                                       
        public MainPage(INavigationService navigationService)
        
        {
            InitializeComponent();
            _navigationService = navigationService;
            //NavigationPage.SetHasNavigationBar(this, false);
        }

        async void OnSearch(object sender, EventArgs args)
        {
            await _navigationService.NavigateAsync("SearchPage");
        }
    }
}
