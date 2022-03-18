using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_MVC.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        public string Name { get; set; }

    }
}