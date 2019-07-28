using System.ComponentModel.DataAnnotations;
using FluentAssertions;
using GuideInvestimentos.Dominio.Entidades;
using Xunit;

namespace GuideInvestimentos.Dominio.Testes.Entidades
{
    public class AutorTestes
    {
        [Fact(DisplayName = "Quanto criar um autor")]
        [Trait("Entidades", "Autor")]
        public void Quando_criar_um_autor()
        {
            var nome = "Carlos Drummond de Andrade";

            var autor = new Autor(nome);

            autor.Should().NotBeNull();
            autor.Nome.ToString().Should().Be(nome);
        }
    }
}
