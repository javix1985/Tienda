using Microsoft.EntityFrameworkCore;
using Tienda.Modelos;

namespace Tienda.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Modelo_Abm_Marca> Marcas { get; set; }
        public DbSet<Modelo_Abm_TipoProd> TipoProds { get; set; }
        public DbSet<Modelo_ModelodeProductos> ModelodeProductos { get; set; }
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<ModeloVenta_Articulos> Venta_Articulos { get; set; }

    }

}

