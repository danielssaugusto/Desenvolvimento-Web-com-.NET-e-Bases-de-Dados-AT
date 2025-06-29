using Microsoft.EntityFrameworkCore;
using AgenciaTurismo.Models;

namespace AgenciaTurismo.Data
{
    public class AgenciaTurismoContext : DbContext
    {
        public AgenciaTurismoContext(DbContextOptions<AgenciaTurismoContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<PaisDestino> PaisesDestino { get; set; } = null!;
        public DbSet<CidadeDestino> CidadesDestino { get; set; } = null!;
        public DbSet<PacoteTuristico> PacotesTuristicos { get; set; } = null!;
        public DbSet<Reserva> Reservas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica filtro global para não retornar clientes excluídos
            modelBuilder.Entity<Cliente>().HasQueryFilter(c => !c.IsDeleted);
        }
    }
}
