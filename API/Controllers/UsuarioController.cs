using Dominio.InputModels;
using Dominio.Service.Interface;
using Entidade;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToDoAPI.Controllers
{
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;
        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pesquisa = _usuarioServico.GetById(id);

            return Ok(pesquisa);
            
        }


        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel createUser)
        {
            if (createUser != null)
            {
                var user = new Usuario(createUser.Email, createUser.Password, createUser.Nome, createUser.DtNascimento);
                _usuarioServico.Post(user);

                return Ok();
            }

            return BadRequest();
            
        }

        [HttpPut("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginInputModel login)
        {
            throw new NotImplementedException();
        }
    }
}
