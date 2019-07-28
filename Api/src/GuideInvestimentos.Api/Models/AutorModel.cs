using GuideInvestimentos.Dominio.Entidades;
using GuideInvestimentos.Dominio.Extensions;

namespace GuideInvestimentos.Api.Models
{
    public sealed class AutorListModel
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public AutorListModel(Autor autor)
        {
            Id = autor.Id;
            Nome = autor.Nome.ABNTReferenciaAutor();
        }
    }
}
