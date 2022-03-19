using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_MVC.Models
{
    public class Movies
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        public string Name { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        [Display(Name="Genre")]
        public byte GenreId { get; set; }

    }
}