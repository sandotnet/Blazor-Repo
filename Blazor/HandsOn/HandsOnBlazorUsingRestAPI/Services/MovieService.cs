using HandsOnBlazorUsingRestAPI.Models;
using System.Text;
using System.Text.Json;

namespace HandsOnBlazorUsingRestAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _client;
        public MovieService(HttpClient httpClient)
        {
            _client = httpClient;
        }
        public async Task<List<Movie>> GetAll()
        {
            var response = await _client.GetAsync("/api/Movie/GetAllMovies");
            var content = await response.Content.ReadAsStringAsync();
            var movies = JsonSerializer.Deserialize<List<Movie>>(content);
            return movies;
        }
        public async Task<Movie> Get(int id)
        {
            // _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "token");
            var response = await _client.GetAsync("/api/Movie/GetMovieById/" + id);
            var content = await response.Content.ReadAsStringAsync();
            var movie = JsonSerializer.Deserialize<Movie>(content);
            return movie;
        }
        public async void Add(Movie movie)
        {
            var content = JsonSerializer.Serialize(movie);
            var requestContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/api/Movie/AddMovie", requestContent);
        }
    }
}
