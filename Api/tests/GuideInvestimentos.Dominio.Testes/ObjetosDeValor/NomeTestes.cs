using System;
using FluentAssertions;
using GuideInvestimentos.Dominio.Extensions;
using GuideInvestimentos.Dominio.ObjetosDeValor;
using Xunit;

namespace GuideInvestimentos.Dominio.Testes.ObjetosDeValor
{
    public class NomeTestes
    {
        [Theory(DisplayName = "Formatar nome do autor")]
        [Trait("ObjetosDeValor", "Nome")]
        [InlineData("Varçal", "VARÇAL")]
        [InlineData("carlos     drummond de andrade", "ANDRADE, Carlos Drummond de")]
        [InlineData("João da Silva", "SILVA, João da")]
        [InlineData("Maria das Neves", "NEVES, Maria das")]
        [InlineData("CLEBER VArçAl", "VARÇAL, Cleber")]
        [InlineData("José Silva Neto", "SILVA NETO, José")]
        [InlineData("André Luis DA Silva Neto", "SILVA NETO, André Luis da")]
        [InlineData("uLIsses EzeQuiel Junior", "EZEQUIEL JUNIOR, Ulisses")]
        [InlineData("João NETO", "NETO, João")]
        [InlineData("Neto", "NETO")]

        public void Formatar_nome_de_autor(string nomeAutor, string nomeEsperado)
        {
            var nome = new Nome(nomeAutor);

            nome.ABNTReferenciaAutor().Should().Be(nomeEsperado);
        }

        [Fact(DisplayName = "Quando criar um nome")]
        [Trait("ObjetosDeValor", "Nome")]
        public void Quando_criar_um_nome()
        {
            var texto = "Varçal";

            var nome = new Nome(texto);

            nome.Texto.Should().Be(texto);
        }

        [Fact(DisplayName = "Quando criar um nome texto não deve ser nulo ou vazio")]
        [Trait("ObjetosDeValor", "Nome")]
        public void Quando_criar_um_nome_texto_não_deve_ser_vazio_ou_nulo()
        {
            var texto = string.Empty;

            Action action = () => new Nome(texto);

            action.Should().Throw<ApplicationException>();
        }
    }
}
