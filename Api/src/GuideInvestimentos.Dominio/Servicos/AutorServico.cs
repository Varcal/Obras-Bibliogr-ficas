using System.Collections.Generic;
using GuideInvestimentos.Dominio.Entidades;
using GuideInvestimentos.Dominio.Interfaces.Repositorios;
using GuideInvestimentos.Dominio.Interfaces.Servicos;

namespace GuideInvestimentos.Dominio.Servicos
{
    public sealed class AutorServico: IAutorServico
    {
        private IAutorRepositorio _autorRepositorio;
        public AutorServico(IAutorRepositorio autorRepositorio)
        {
            _autorRepositorio = autorRepositorio;
        }

        public IReadOnlyList<Autor> SelecionarPorQuantidade(int quantidade)
        {
            return _autorRepositorio.SelecionarAutoresPorQuantidade(quantidade);
        }
    }
}
