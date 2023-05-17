using Dominio.Service.Interface;
using Entidade;
using Entidade.Repositories;

namespace Dominio.Service.Implementations
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
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
            var newUsuario = new Usuario(usuario.Email, usuario.Password, usuario.Nome, usuario.DtNascimento);
            _usuarioRepositorio.Post(newUsuario);

            return newUsuario;
            
        }
    }
}
