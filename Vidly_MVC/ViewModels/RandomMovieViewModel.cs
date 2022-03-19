﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC.Models;

namespace Vidly_MVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movie { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Genre> Genres { get; set; }


    }
}