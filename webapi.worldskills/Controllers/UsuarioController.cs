using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.worldskills.Domains;
using webapi.worldskills.Interfaces;
using webapi.worldskills.Repositories;

namespace webapi.worldskills.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return StatusCode(201, usuario);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

    }
}
