using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsuariosApp.Api.DTOs.Request;
using UsuariosApp.Api.DTOs.Response;
using UsuariosApp.API.DTOs;

namespace UsuariosApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpPost]
        [Route("autenticar")]
        [ProducesResponseType(typeof(AutenticarUsuarioResponseDTO), 200)]
        public IActionResult Autenticar(AutenticarUsuarioRequestDTO dto)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Criar")]
        [ProducesResponseType(typeof(CriarUsuarioResponseDTO), 201)]
        public IActionResult Criar(CriarUsuarioRequestDTO dto)
        {
            return Ok();
        }
    }
}
