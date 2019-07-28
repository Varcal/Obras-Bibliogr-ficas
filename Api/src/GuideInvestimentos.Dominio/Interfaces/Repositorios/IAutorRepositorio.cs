using System.Collections.Generic;
using GuideInvestimentos.Dominio.Entidades;

namespace GuideInvestimentos.Dominio.Interfaces.Repositorios
{
    public interface IAutorRepositorio
    {
        IReadOnlyList<Autor> SelecionarAutoresPorQuantidade(int quantidade);
    }
}
