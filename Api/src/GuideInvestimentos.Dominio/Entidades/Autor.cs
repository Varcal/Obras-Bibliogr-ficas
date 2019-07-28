using GuideInvestimentos.Dominio.ObjetosDeValor;

namespace GuideInvestimentos.Dominio.Entidades
{
    public sealed class Autor
    {
        public int Id { get; private set; }
        public Nome Nome { get; private set; }

        private Autor() { }

        public Autor(string nome)
        {
            Nome = new Nome(nome);
        }
    }
}
