using FilmeMania.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FilmeMania.Data
{
    public class OMDbRest
    {
        private static string APIURL = "https://www.omdbapi.com/?apikey=610a1996";
        private HttpClient client = new HttpClient();

        public async Task<Movie> GetMovieAsync(string title)
        {
            Uri url = new Uri(APIURL + "&t=" + title);

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Movie movie = JsonConvert.DeserializeObject<Movie>(content);
                return movie;
            }
            else
            {
                return null;
            }
        }
    }
}
