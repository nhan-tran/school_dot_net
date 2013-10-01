using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace nt_lab3_HomeInventory.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Shortname { get; set; }
        public string Description { get; set; }

    }
}