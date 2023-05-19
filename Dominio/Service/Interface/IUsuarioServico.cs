using Dominio.InputModels;
using Dominio.ViewModels;
using Entidade;

namespace Dominio.Service.Interface
{
    public interface IUsuarioServico
    {
        Usuario GetById(int id);
        Usuario Post(Usuario usuario);
        Usuario GetUserByEmailAndPassword(string email, string password);
        LoginViewModel Login(LoginInputModel usuario);

    }
}