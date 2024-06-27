using System;
using System.Collections.Generic;

namespace Mvc_Movie.Models;

public partial class Pelicula
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public DateOnly Lanzamiento { get; set; }

    public string? Genero { get; set; }

    public decimal Precio { get; set; }
}
