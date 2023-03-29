using Dominio.InputModels;
using Dominio.Service.Interface;
using Dominio.ViewModels;
using Entidade;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Service.Implementations
{
    public class TarefaServico : ITarefaServico
    {
        private readonly ToDoDbContext _dbContext;
        public TarefaServico(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<TarefaViewModel> BuscarTodos()
        {
            //var tarefas = _repositorio.BuscarTodos();
            var tarefas = _dbContext.Tarefas;

            var tarefasViewModel = tarefas.Select(t => new TarefaViewModel(t.Titulo, t.Descricao)).ToList();

            return tarefasViewModel;
        }
        public TarefaViewModel BuscarPorId(int id)
        {
            var tarefa = _dbContext.Tarefas.SingleOrDefault(tarefas => tarefas.Id == id);

            var tarefaViewModel = new TarefaViewModel(tarefa.Titulo, tarefa.Descricao);

            if (tarefaViewModel == null) return null;

            return tarefaViewModel;
        }

        public int AddTarefa(AddTarefaInputModel model)
        {
            var tarefa = new Tarefa(model.Id, model.Titulo, model.Descricao);

            _dbContext.Tarefas.Add(tarefa);

            return tarefa.Id;
        }

        public void Deletar(int id)
        {
            var tarefa = _dbContext.Tarefas.SingleOrDefault(tarefa => tarefa.Id == id);

            _dbContext.Tarefas.Remove(tarefa);
        }

        public void AtualizarTarefa(UpdateTarefaInputModel inputModel)
        {
            var tarefa = _dbContext.Tarefas.SingleOrDefault(tarefa => tarefa.Id == inputModel.Id);

            tarefa.Atualizar(inputModel.Id, inputModel.Descricao);
        }
    }
}
