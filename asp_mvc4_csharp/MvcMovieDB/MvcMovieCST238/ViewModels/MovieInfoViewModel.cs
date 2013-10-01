using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMovieCST238.Models;

namespace MvcMovieCST238.ViewModels
{
    public class MovieInfoViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Director> Directors { get; set; }

    }
}