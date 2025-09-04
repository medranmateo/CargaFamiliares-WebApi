using CargaFamiliares_WebApi.Application.Interfaces.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargaFamiliares_WebApi.Controllers
{
    [Route("api/TipoDescripciones")]
    [ApiController]
    public class TiposDescripcionesController : ControllerBase
    {
        private readonly ITiposDescripcionService _tiposDescripcionesServices;
        public TiposDescripcionesController(ITiposDescripcionService tiposDescripcionesServices)
        {
            _tiposDescripcionesServices = tiposDescripcionesServices;
        }

        [HttpGet("agrupados")]
        public async Task<IActionResult> GetTiposAgrupados()
        {
            var tiposAgrupados = await _tiposDescripcionesServices.ObtenerTiposAgrupados(); 
            return Ok(tiposAgrupados);
        }
    }
}
