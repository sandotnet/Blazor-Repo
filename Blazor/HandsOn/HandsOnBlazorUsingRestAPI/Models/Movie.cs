using System.ComponentModel.DataAnnotations;

namespace HandsOnBlazorUsingRestAPI.Models
{
    public class Movie
    {

        
        public int movieId { get; set; }
        [Required(ErrorMessage ="Title is Required")]
        public string title { get; set; }
        [Required(ErrorMessage = "Lang is Required")]
        public string language { get; set; }
        [Required(ErrorMessage = "Year is Required")]
     
        public int releaseYear { get; set; }
        [Required(ErrorMessage = "Actor is Required")]
        public string actor { get; set; }
        [Required(ErrorMessage = "Director is Required")]
        public string director { get; set; }
    }
}
