using BusquedaPalabra.Models;
using BusquedaPalabra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusquedaPalabra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContieneNombreController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] BusquedaRequest request)
        {
            bool resultado = BuscarPalabra.ContieneNombre(request.Info, request.Nombre);
            return Ok(new { resultado });
        }
    }
}
