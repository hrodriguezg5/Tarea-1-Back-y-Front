using Microsoft.EntityFrameworkCore;

namespace ApiTiposSangre.Models;

public class Conexiones : DbContext
{
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options)
    {
    }

    public DbSet<tipo_sangre> tipo_sangre { get; set; } = null!;
}