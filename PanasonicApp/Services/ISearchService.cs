using System;
using System.Threading.Tasks;
using PanasonicApp.Models;

namespace PanasonicApp.Services
{
    public interface ISearchService
    {
        MovieList GetMovieList(string searchText);
    }
}
