using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MyProject.Models
{
    public class MovieContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}