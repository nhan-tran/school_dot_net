using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMovieCST238.Models
{
    public class Director
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}