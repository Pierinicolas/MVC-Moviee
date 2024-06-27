using Microsoft.EntityFrameworkCore;
using Mvc_Movie.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Agrega DbSet para cada entidad que quieras incluir en tu base de datos
    public DbSet<Pelicula> Peliculas { get; set; }
}
