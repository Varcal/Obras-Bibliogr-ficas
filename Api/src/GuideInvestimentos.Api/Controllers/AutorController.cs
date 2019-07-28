using System.Linq;
using System.Net;
using GuideInvestimentos.Api.Models;
using GuideInvestimentos.Dominio.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace GuideInvestimentos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorServico _autorServico;

        public AutorController(IAutorServico autorServico)
        {
            _autorServico = autorServico;
        }

        

        [Route("SelecionarPorQuantidade/{quantidade}")]
        [HttpGet]
        public IActionResult SelecionarPorQuantidade(int quantidade)
        {
            var autores = _autorServico.SelecionarPorQuantidade(quantidade);

            if(!autores.Any()) return NoContent();
            

            return Ok(autores.Select(x=> new AutorListModel(x)));
        }
    }
}