namespace MvcMovieCST238.Migrations
{
    using MvcMovieCST238.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovieCST238.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovieCST238.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Terminator",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R",
                    DirectorID = 1
                },

                 new Movie
                 {
                     Title = "Skyfall",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Price = 8.99M,
                     Rating = "PG-13",
                     DirectorID = 1
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Price = 9.99M,
                     Rating = "G",
                     DirectorID = 1
                 },

               new Movie
               {
                   Title = "Men In Black",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Price = 3.99M,
                   Rating = "PG",
                   DirectorID = 1
               }
           );
        }
    }
}
