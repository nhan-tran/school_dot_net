using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace nt_lab3_HomeInventory.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
    }
}