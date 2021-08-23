using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using PanasonicApp.Models;
using PanasonicApp.Views;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace PanasonicApp.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Movie> MovieList { get; set; }
        public Command LoadItemsCommand { get; set; }
        public Command SearchCommand
        {
            get
            {
                return new Command(() =>
                {
                    SearchUserText(_searchText);
                    NotifyPropertyChanged();
                });
            }
        }
        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged();
            }
        }

        public ItemsViewModel()
        {
            Title = "Movies";
            MovieList = new ObservableCollection<Movie>();
        }

        public async void SearchUserText(string text)
        {
            MovieList.Clear();
            var items = SearchService.GetMovieList(text);
            foreach (var item in items.results)
            {
                if (item.PosterPath != null)
                {
                    item.PosterPath = "https://image.tmdb.org/t/p/w500/" + item.PosterPath;
                }
                else
                {
                    item.PosterPath = "PlaceHolder.jpeg";
                }
                MovieList.Add(item);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}