using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using GuideInvestimentos.Dominio.ObjetosDeValor;

namespace GuideInvestimentos.Dominio.Extensions
{
    public static class NomeExtensions
    {
        public static string ABNTReferenciaAutor(this Nome nome)
        {
            var listaPalavras = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.Texto.ToLower())
                .Split(' ').ToList();

            if (listaPalavras.Count == 1) return nome.Texto.ToUpper();

            RemoverPosicoesVazias(listaPalavras);

            var sobrenome = FormatarSobrenome(listaPalavras);

            FormatarPrimeiraParteNome(listaPalavras);
            
            return listaPalavras.Aggregate(sobrenome.ToUpper(), (current, palavra) => current + $"{palavra.Trim()} ").Trim();
        }

        private static void RemoverPosicoesVazias(List<string> listaPalavras)
        {
            listaPalavras.RemoveAll(e => e == string.Empty);
        }

        private static string FormatarSobrenome(List<string> listaPalavras)
        {
            var execoes = new[] { "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA", "JUNIOR" };
            string sobrenome;

            if (execoes.Contains(listaPalavras.Last().Trim().ToUpper()) && listaPalavras.Count > 2)
            {
                sobrenome = $"{listaPalavras[listaPalavras.Count - 2]} {listaPalavras.Last()}, ";
                listaPalavras.RemoveRange(listaPalavras.Count - 2, 2);
            }
            else
            {
                sobrenome = $"{listaPalavras.Last().ToUpper()}, ";
                listaPalavras.Remove(listaPalavras.Last());
            }

            return sobrenome;
        }

        private static void FormatarPrimeiraParteNome(List<string> listaPalavras)
        {
            var execoes2 = new[] { "de", "da", "das", "dos" };

            if (!execoes2.Contains(listaPalavras.Last().ToLower())) return;

            var texto = listaPalavras.Last().ToLower();
            listaPalavras.Remove(listaPalavras.Last());
            listaPalavras.Add(texto);
        }
    }
}
