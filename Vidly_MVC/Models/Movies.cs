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
        public DateTime DateAdded { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int NumberInStock { get; set; }

    }
}