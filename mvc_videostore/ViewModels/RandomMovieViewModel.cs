using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_videostore.Models;

namespace mvc_videostore.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}