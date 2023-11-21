using HandsOnBlazorUsingRestAPI.Services;
using Microsoft.AspNetCore.Components;

namespace HandsOnBlazorUsingRestAPI.Models
{
    public class MovieBase:ComponentBase
    {
       
        public List<Movie> Movies { get; set; }
        [Inject]
        public  IMovieService movieService { get; set; } //created object using DI
        public Movie movie = new Movie();
        [Parameter]
        public int MovieId { get; set; }
        protected async override Task OnInitializedAsync() //invokes when component is loaded
        {
           Movies= await movieService.GetAll();
         
        }
        protected async Task Add()
        {
            movie.releaseYear = 2000;
            movieService.Add(movie);
        }
        protected async Task<List<Movie>> GetMovies()
        {
            return await movieService.GetAll();
        }
        protected async Task GetMovie()
        {
            movie = await movieService.Get(MovieId);
        }
    }
}
