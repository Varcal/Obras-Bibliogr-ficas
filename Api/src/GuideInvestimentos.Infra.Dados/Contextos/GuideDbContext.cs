using GuideInvestimentos.Dominio.Entidades;
using GuideInvestimentos.Infra_Dados.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GuideInvestimentos.Infra_Dados.Contextos
{
    public sealed class GuideDbContext: DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Autor> Autores { get; set; }

        public GuideDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("GuideConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMap());
        }
    }
}
