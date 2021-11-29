using CalculaJuros.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculaJuros.Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : Controller
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosController(ICalculaJurosService calculaJurosService)
        {
            _calculaJurosService = calculaJurosService;
        }

        [HttpGet]
        public async Task<decimal> Get(decimal valorInicial, int meses)
        {
            return await _calculaJurosService.CalculateInterest(valorInicial, meses);
        }
    }
}
