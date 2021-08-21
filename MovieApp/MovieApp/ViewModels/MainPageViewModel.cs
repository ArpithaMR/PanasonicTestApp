using MovieApp.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MovieApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand GetBatteryStatusCommand { get; set; }
        ISearchService _searchService;
        public bool AllFieldsAreValid { get; set; } = true;
        public MainPageViewModel(INavigationService navigationService, ISearchService searchService)
            : base(navigationService)
        {
            Title = "";
            //GetBatteryStatusCommand = new DelegateCommand(GetMovieList).ObservesCanExecute(() => AllFieldsAreValid);
            //_searchService = searchService;
        }
        
        //async void GetMovieList()
        //{

        //    _searchService.GetMovieList();
        //    //await _pageDialogService.DisplayAlertAsync("Battery Status", batteryStatus, "Ok");

        //}
    }
}

