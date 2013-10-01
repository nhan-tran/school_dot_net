using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMovieCST238.Models;

namespace MvcMovieCST238.ViewModels
{
    public class FullMovieInfoViewModel
    {
        public Movie Movie { get; set; }
        public Director Director { get; set; }

    }
}