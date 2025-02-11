
using Microsoft.EntityFrameworkCore;
using MvcMovie.Domain.Models;

namespace MvcMovie.Infra.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(i => i.Price).HasPrecision(18,2);
        }
    }
}
