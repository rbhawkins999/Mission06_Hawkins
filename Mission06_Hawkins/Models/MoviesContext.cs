using Microsoft.EntityFrameworkCore;

namespace Mission06_Hawkins.Models
{
    //setting up things for the database
    public class MoviesContext: DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base (options) 
        {
        }

        public DbSet<NewMovie> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Categories>().HasData(

        //        new Categories { CategoryID = 1, Category ="Miscellaneous"},
        //        new Categories { CategoryID = 2, Category = "Drama" },
        //        new Categories { CategoryID = 3, Category = "Television" },
        //        new Categories { CategoryID = 4, Category = "Horror/Suspense" },
        //        new Categories { CategoryID = 5, Category = "Comedy" },
        //        new Categories { CategoryID = 6, Category = "Family" },
        //        new Categories { CategoryID = 7, Category = "Action/Adventure" },
        //        new Categories { CategoryID = 8, Category = "VHS" }

        //    );

        //}
    }
}
