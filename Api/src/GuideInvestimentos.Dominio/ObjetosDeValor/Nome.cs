using System;

namespace GuideInvestimentos.Dominio.ObjetosDeValor
{
    public sealed class Nome
    {
        public string Texto { get; private set; }

        public Nome(string texto)
        {
            if(string.IsNullOrWhiteSpace(texto))
                throw new ApplicationException("Nome não pode ser nulo ou vazio.");

            Texto = texto;
        }

        public override string ToString()
        {
            return Texto;
        }
    }
}
