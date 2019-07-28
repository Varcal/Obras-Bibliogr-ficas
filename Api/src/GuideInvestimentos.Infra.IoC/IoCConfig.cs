using GuideInvestimentos.Dominio.Interfaces.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using GuideInvestimentos.Dominio.Interfaces.Servicos;
using GuideInvestimentos.Dominio.Interfaces.Transacao;
using GuideInvestimentos.Dominio.Servicos;
using GuideInvestimentos.Infra_Dados.Contextos;
using GuideInvestimentos.Infra_Dados.Repositorios;
using GuideInvestimentos.Infra_Dados.Transacaco;

namespace GuideInvestimentos.Infra.IoC
{
    public class IoCConfig
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddDbContext<GuideDbContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAutorRepositorio, AutorRepositorio>();
            services.AddScoped<IAutorServico, AutorServico>();
        }
    }
}
