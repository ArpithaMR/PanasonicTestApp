using System;

using PanasonicApp.Models;

namespace PanasonicApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Movie Item { get; set; }
        public ItemDetailViewModel(Movie item = null)
        {
            Item = item;
        }
    }
}
