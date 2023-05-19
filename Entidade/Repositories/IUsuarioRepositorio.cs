namespace Entidade.Repositories
{
    public interface IUsuarioRepositorio
    {
        Usuario GetById(int id);
        int Post(Usuario usuario);
        Usuario GetUserByEmailAndPassword(string email, string passwordHash);

    }
}
