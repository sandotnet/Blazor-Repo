using HandsOnBlazorUsingRestAPI.Models;

namespace HandsOnBlazorUsingRestAPI.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAll();
        Task<Movie> Get(int id);
        void Add(Movie movie);
    }
}
