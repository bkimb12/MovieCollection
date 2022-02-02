using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class MovieDatabaseContext : DbContext
    {
        //Constructor
        public MovieDatabaseContext(DbContextOptions<MovieDatabaseContext> options) : base (options)
        { 
            //blank
        }

        public DbSet<AddMovie> Responses { get; set; }
        public DbSet<Category> Categorys { get; set; }

        //seed database w/3 movies
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName="Action/Adventure"},
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Sports" },
                new Category { CategoryID = 8, CategoryName = "Television" },
                new Category { CategoryID = 9, CategoryName = "VHS" }
            );

            mb.Entity<AddMovie>().HasData(

                new AddMovie
                { 
                    MovieID = 1,
                    CategoryID = 7,
                    Title = "Hoosiers",
                    Year = 1986, 
                    Director = "David Anspaugh",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "", 
                    Notes = ""
                },
                new AddMovie
                {
                    MovieID = 2,
                    CategoryID = 4,
                    Title = "Encanto",
                    Year = 2021,
                    Director = "Byron Howard, Jared Bush",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new AddMovie
                {
                    MovieID = 3,
                    CategoryID = 1,
                    Title = "Midway",
                    Year = 2019,
                    Director = "Roland Emmerich",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
