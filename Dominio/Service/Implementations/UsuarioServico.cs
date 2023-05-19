using Dominio.InputModels;
using Dominio.Service.Interface;
using Dominio.ViewModels;
using Entidade;
using Entidade.Repositories;
using Entidade.Services;

namespace Dominio.Service.Implementations
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IAuthService _authService;
        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio, IAuthService authService)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _authService = authService;
        }

        public Usuario GetById(int id)
        {
            return _usuarioRepositorio.GetById(id);
        }

        public Usuario GetUserByEmailAndPassword(string email, string password)
        {
            return _usuarioRepositorio.GetUserByEmailAndPassword(email, password);
        }

        public Usuario Post(Usuario usuario)
        {

            var passwordHash = _authService.ComputeSha256Hash(usuario.Password);

            var newUsuario = new Usuario(usuario.Email, passwordHash, usuario.Nome, usuario.DtNascimento);
            _usuarioRepositorio.Post(newUsuario);

            return newUsuario;
            
        }

        public LoginViewModel Login(LoginInputModel usuario)
        {
            var passwordHash = _authService.ComputeSha256Hash(usuario.Password);

            var user = _usuarioRepositorio.GetUserByEmailAndPassword(usuario.Email, passwordHash);

            if (user == null) return null;

            var token = _authService.GenerateJwtToken(user.Email, user.Password);
            return new LoginViewModel(user.Email, token);

        }
    }
}
