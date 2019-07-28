using System.Collections.Generic;
using GuideInvestimentos.Dominio.Entidades;

namespace GuideInvestimentos.Dominio.Interfaces.Servicos
{
    public interface IAutorServico
    {
        IReadOnlyList<Autor> SelecionarPorQuantidade(int quantidade);
    }
}
