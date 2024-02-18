using Microsoft.EntityFrameworkCore;
using Tienda.Data;
using Tienda.Modelos;

namespace Tienda.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _entities;

        public Repositorio(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> ObtenerTodosAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> ObtenerPorIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task AgregarAsync(T entidad)
        {
            await _entities.AddAsync(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(T entidad)
        {
            _entities.Update(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var entidad = await ObtenerPorIdAsync(id);
            if (entidad != null)
            {
                _entities.Remove(entidad);
                await _context.SaveChangesAsync();
            }
        }
    }

    //No olvidar que luego de Crear una Clase se la debe agregar en el program.cs y en el DBContext

    public class RepositorioMarca : Repositorio<Modelo_Abm_Marca>
    {
        public RepositorioMarca(ApplicationDbContext context) : base(context)
        {
        }

        // Aquí se puede agregar operaciones específicas para Modelo_Abm_Marca
    }

    public class RepositorioTipoProd : Repositorio<Modelo_Abm_TipoProd>
    {
        public RepositorioTipoProd(ApplicationDbContext context) : base(context)
        {
        }

        // Aquí se puede agregar operaciones específicas para Modelo_Abm_TipoProd
    }

    public class RepositorioModelo : Repositorio<Modelo_ModelodeProductos>
    {
        public RepositorioModelo(ApplicationDbContext context) : base(context)
        {
        }

        // Aquí se puede agregar operaciones específicas para Modelo_ModelodeProductos
    }

    public class RepositorioArticulos : Repositorio<Articulos>
    {
        public RepositorioArticulos(ApplicationDbContext context) : base(context)
        {
        }

        // Aquí se puede agregar operaciones específicas para Articulos
    }

    public class RepositorioVenta_Articulos : Repositorio<ModeloVenta_Articulos>
    {
        public RepositorioVenta_Articulos(ApplicationDbContext context) : base(context)
        {
        }

        // Aquí se puede agregar operaciones específicas para ModeloVenta_Articulos
    }
}
