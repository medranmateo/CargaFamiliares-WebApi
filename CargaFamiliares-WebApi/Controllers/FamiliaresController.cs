using Azure.Core;
using CargaFamiliares_WebApi.Application.Interfaces.IServices;
using CargaFamiliares_WebApi.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargaFamiliares_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliaresController : ControllerBase
    {
        private readonly IFamiliaresServices _familiaresServices;
        public FamiliaresController(IFamiliaresServices familiaresServices)
        {
            _familiaresServices = familiaresServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API Carga Familiares funcionando correctamente.");
        }

        [HttpGet("buscar/{tipoDoc}/{nroDoc}")]
        public async Task<IActionResult> BuscarFamiliares(string tipoDoc, string nroDoc)
        {
            var familiares = await _familiaresServices.BuscarFamiliares(tipoDoc, nroDoc);

            return Ok(familiares);
        }

        [HttpPut("actualizarPersona")]
        public async Task<IActionResult> ActualizarPersona([FromBody] ActualizarPersona request)
        {
            if (request == null)
            {
                return BadRequest("Datos no validos");
            }

            try
            {
                await _familiaresServices.ActualizarPersona(request);
                return Ok(new { mensaje = "Persona actualizada correctamente" });
            }
            catch (Exception ex) 
            {
                return StatusCode(500, $"Ocurrio un error en el servidor {ex.Message}");
            }
        }


        [HttpPost("nuevoFamiliar")]
        public async Task<IActionResult> NuevoFamiliar([FromBody] NuevoFamiliarRequest request)
        {
            if(request.Familiar == null || request.Persona == null)
            {
                return BadRequest("Datos no validos");
            }

            try
            {
                await _familiaresServices.CrearPersona(request.Persona);
                await _familiaresServices.CrearFamiliar(request.Familiar);
                return Ok(new { mensaje = "Persona agregada correctamente" });
            }
            catch (InvalidOperationException ex)
            {
                return StatusCode(409, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocurrio un error en el servidor {ex.Message}");
            }
        }
    }
}
