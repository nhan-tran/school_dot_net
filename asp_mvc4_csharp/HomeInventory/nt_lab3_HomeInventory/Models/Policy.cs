using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace nt_lab3_HomeInventory.Models
{
    public class Policy
    {
        [Key]
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyNumber { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }

    public class HomeInsDBContext : DbContext
    {
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        //public DbSet<Picture> Pictures { get; set; }

    }
}