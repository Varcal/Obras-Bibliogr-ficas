using System.Net;
using System.Runtime.InteropServices;

namespace GuideInvestimentos.Api.Models
{
    public sealed class ResultadoModel
    {
        public HttpStatusCode StatusCode { get; set; }
        public object Dados { get; set; }
        public string Mensagem { get; set; }

        public ResultadoModel(HttpStatusCode statusCode, object dados, [Optional]string mensagem)
        {
            StatusCode = statusCode;
            Dados = dados;
            Mensagem = mensagem;
        }
    }
}
