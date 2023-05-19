using Dominio.InputModels;
using Dominio.Service.Implementations;
using Dominio.Service.Interface;
using Dominio.ViewModels;
using Entidade;
using Entidade.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ToDoAPI.Controllers
{
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;
        private readonly IAuthService _authService;
        public UsuarioController(IUsuarioServico usuarioServico, IAuthService authService)
        {
            _usuarioServico = usuarioServico;
            _authService = authService;
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
        public IActionResult Login([FromBody] LoginInputModel inputModel)
        {
            var login = new LoginInputModel(inputModel.Email, inputModel.Password);

            if (login == null) return BadRequest();

            var getToken = _usuarioServico.Login(login);
            var token = getToken.Token;

            return Ok(token);
            
        }
    }
}
