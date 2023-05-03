using Dominio.InputModels;
using Dominio.Service.Interface;
using Dominio.ViewModels;
using Entidade;
using Repositorio;

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

            var tarefasViewModel = tarefas.Select(t => new TarefaViewModel(t.Id, t.Titulo, t.Descricao)).ToList();

            return tarefasViewModel;
        }
        public TarefaViewModel BuscarPorId(int id)
        {
            var tarefa = _dbContext.Tarefas.SingleOrDefault(tarefas => tarefas.Id == id);

            var tarefaViewModel = new TarefaViewModel(tarefa.Id, tarefa.Titulo, tarefa.Descricao);

            if (tarefaViewModel == null) return null;

            return tarefaViewModel;
        }

        public int AddTarefa(AddTarefaInputModel model)
        {
            var tarefa = new Tarefa(model.Titulo, model.Descricao);

            _dbContext.Tarefas.Add(tarefa);

            return tarefa.Id;
        }

        public void Deletar(int id)
        {
            var tarefa = _dbContext.Tarefas.SingleOrDefault(tarefa => tarefa.Id == id);

            _dbContext.Tarefas.Remove(tarefa);
        }

        public int EditTarefa(AddTarefaInputModel model)
        {
            throw new NotImplementedException();
            // Verificar se a lógica se mantem para a consulta no BD

            //_dbContext.Tarefas.Find(t => t.Id == model.).Atualizar(model.Id, model.Titulo, model.Descricao);

            //return model.Id;
        }

    }
}
