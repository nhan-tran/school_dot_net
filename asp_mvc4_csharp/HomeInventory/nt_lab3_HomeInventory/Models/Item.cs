using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nt_lab3_HomeInventory.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Manufacturer")]
        public int ManufacturerId { get; set; }

        public string Model { get; set; }
        public string Identifier { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasePrice { get; set; }
        public byte[] Picture { get; set; }

        public virtual Category Category { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

    }
}