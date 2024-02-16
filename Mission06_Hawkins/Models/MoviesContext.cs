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
    }
}
