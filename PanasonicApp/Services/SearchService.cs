using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PanasonicApp.Models;

namespace PanasonicApp.Services
{
    public class SearchService : ISearchService
    {
        public MovieList GetMovieList(string searchText)
        {
            var WebAPIUrl = "https://api.themoviedb.org/3/search/movie?api_key=baf8f0bf1a4a3b135598e7802d3a9bb7&query=" + searchText;
            //var WebAPIUrl = "https://api.themoviedb.org/3/movie/550?api_key=baf8f0bf1a4a3b135598e7802d3a9bb7"; // Set your REST API URL here.
            var uri = new Uri(WebAPIUrl);
            HttpClient client = new HttpClient();
            try
            {
                var response = client.GetAsync(uri).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var movies = JsonConvert.DeserializeObject<MovieList>(content);
                    return movies;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
