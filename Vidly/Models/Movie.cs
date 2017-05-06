using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required][StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Must choose a genre for movie")]
        public byte GenreId { get; set; }

        [Display(Name = "Genre")]
        public Genre Genre { get; set; }
        
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Range(1,25)]
        [Display(Name = "Number In Stock")]
        public byte? NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}