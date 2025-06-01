using CapaDatosFasecolda;
using LogicaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static LogicaNegocio.Logica;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AseguradoraController : ControllerBase
    {
        private Logica logica = new Logica(new ConexionBD());
        [HttpGet]
        [Route("{placa}")]
        public ConteoAccidenteDTO Get(string placa)
        {
            return logica.ObtenerCantidadAccidentesPorPlaca(placa);
        }
    }
}
