using Entidade;
using Entidade.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositories
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ToDoDbContext _dbContext;
        public UsuarioRepositorio(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Post(Usuario usuario)
        {
            _dbContext.Usuarios.Add(usuario);
            _dbContext.SaveChanges();

            return usuario.Id;
        }

        public Usuario GetById(int id)
        {
            return _dbContext.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public Usuario GetUserByEmailAndPassword(string email, string passwordHash)
        {

            return _dbContext.Usuarios.FirstOrDefault(u => u.Email == email && u.Password == passwordHash);
        }
    }
}
