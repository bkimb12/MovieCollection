using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    //AddMovie Class w/each datatype 
    public class AddMovie
    {   
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Please enter a movie title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the year the movie was released.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please enter the director of the movie.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please enter the movie rating.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        //Foreign Key for category
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
