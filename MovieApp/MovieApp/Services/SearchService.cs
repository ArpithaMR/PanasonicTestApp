using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;

namespace MovieApp.Services
{
    public class SearchService : ISearchService
    {
        public void GetMovieList()
        {
            var WebAPIUrl = "https://api.themoviedb.org/3/movie/550?api_key=baf8f0bf1a4a3b135598e7802d3a9bb7"; // Set your REST API URL here.
            var uri = new Uri(WebAPIUrl);
            HttpClient client = new HttpClient();
            try
            {
                var response =  client.GetAsync(uri).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var Items = JsonConvert.DeserializeObject<string>(content);
                    //return Items;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
