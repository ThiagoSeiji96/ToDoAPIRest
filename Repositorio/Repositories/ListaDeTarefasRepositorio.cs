using Entidade;
using Entidade.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositories
{
    public class ListaDeTarefasRepositorio : IListaDeTarefasRepositorio
    {
        private readonly ToDoDbContext _dbContext;
        public ListaDeTarefasRepositorio(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ListaDeTarefa GetListaById(int id)
        {
            return _dbContext.ListasDeTarefas.SingleOrDefault(x => x.Id == id);
        }
    }
}
