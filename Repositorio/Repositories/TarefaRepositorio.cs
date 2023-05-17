using Entidade;
using Entidade.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositories
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly ToDoDbContext _dbContext;
        public TarefaRepositorio(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Tarefa GetById(int id)
        {
            return _dbContext.Tarefas.SingleOrDefault(x => x.Id == id);
        }

        public List<Tarefa> GetAll()
        {
            return _dbContext.Tarefas.ToList();
        }

        public int Post(Tarefa tarefa)
        {
            _dbContext.Tarefas.Add(tarefa);
            _dbContext.SaveChanges();

            return tarefa.Id;
            
        }

        public int Edit(Tarefa tarefa)
        {
            _dbContext.Tarefas.FirstOrDefault(t => t.Id== tarefa.Id);
            _dbContext.Tarefas.Update(tarefa);
            _dbContext.SaveChanges();

            return tarefa.Id;
        }

        public void Delete(int id)
        {
            _dbContext.Tarefas.FirstOrDefault(t => t.Id == id);
            _dbContext.Remove(id);
            
        }
    }
}
