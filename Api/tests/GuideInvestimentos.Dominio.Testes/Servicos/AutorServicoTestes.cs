using System.Collections.Generic;
using FluentAssertions;
using GuideInvestimentos.Dominio.Entidades;
using GuideInvestimentos.Dominio.Interfaces.Repositorios;
using GuideInvestimentos.Dominio.Servicos;
using Moq;
using Xunit;

namespace GuideInvestimentos.Dominio.Testes.Servicos
{
    public class AutorServicoTestes
    {
        [Fact(DisplayName = "Selecionar autores por quantidade")]
        [Trait("Serviços Dominio ", "AutorServico")]
        public void Selecionar_autor_por_quantidade()
        {
            var quantidade = 3;

            var autorRepositoryMoq = new Mock<IAutorRepositorio>();
            autorRepositoryMoq.Setup(x => x.SelecionarAutoresPorQuantidade(quantidade)).Returns(new List<Autor>()
            {
                new Autor("Carlos Drummon de Andrade"),
                new Autor("José da Silva"),
                new Autor("José Junior")
            });

            var autorServico = new AutorServico(autorRepositoryMoq.Object);

            var autores = autorServico.SelecionarPorQuantidade(quantidade);

            autores.Count.Should().Be(quantidade);
        }
    }
}
