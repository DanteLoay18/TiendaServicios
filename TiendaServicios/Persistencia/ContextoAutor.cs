using Microsoft.EntityFrameworkCore;
using TiendaServicios.Modelo;

namespace TiendaServicios.Persistencia
{
    public class ContextoAutor : DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options) : base(options) { }

        public DbSet<AutorLibro> AutorLibro { get; set; }

        public DbSet<GradoAcademico> GradoAcademico { get; set; }

    }
}
