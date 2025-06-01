using CapaDatosFasecolda;
using LogicaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapaPresentacionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FasecoldaController : ControllerBase
    {
        private Logica logica = new Logica(new ConexionBD());
        [HttpGet]
        [Route("{placa:string}")]
        public int Get(string placa)
        {
            return logica.ObtenerCantidadAccidentesPorPlaca(placa);
        }
    }

}
