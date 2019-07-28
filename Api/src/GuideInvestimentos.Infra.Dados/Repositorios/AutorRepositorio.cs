using System.Collections.Generic;
using System.Linq;
using GuideInvestimentos.Dominio.Entidades;
using GuideInvestimentos.Dominio.Interfaces.Repositorios;
using GuideInvestimentos.Infra_Dados.Contextos;

namespace GuideInvestimentos.Infra_Dados.Repositorios
{
    public sealed class AutorRepositorio : IAutorRepositorio
    {
        private readonly GuideDbContext _dbContext;

        public AutorRepositorio(GuideDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList<Autor> SelecionarAutoresPorQuantidade(int quantidade)
        {
            if (quantidade == 0)
                return _dbContext.Autores.ToList();

            return _dbContext.Autores.Take(quantidade).ToList();
        }
    }
}
