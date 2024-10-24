using Microsoft.EntityFrameworkCore;
using proyecto.Domain; // Asegúrate de importar el espacio de nombres correcto

public class RRHHContext : DbContext
{
    public RRHHContext(DbContextOptions<RRHHContext> options) : base(options) { }

    public DbSet<Empleado> Empleados { get; set; }

    // Otros DbSet para otras entidades que agregues en el futuro
}
