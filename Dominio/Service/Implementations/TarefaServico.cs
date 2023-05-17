using Dominio.InputModels;
using Dominio.Service.Interface;
using Dominio.ViewModels;
using Entidade;
using Entidade.Repositories;
using Repositorio;

namespace Dominio.Service.Implementations
{
    public class TarefaServico : ITarefaServico
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefaServico(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }


        public List<TarefaViewModel> BuscarTodos()
        {
            var tarefas = _tarefaRepositorio.GetAll();

            var tarefasViewModel = tarefas.Select(t => new TarefaViewModel(t.Id, t.Titulo, t.Descricao)).ToList();

            return tarefasViewModel;
        }
        public TarefaViewModel BuscarPorId(int id)
        {
            var tarefa = _tarefaRepositorio.GetById(id);

            var tarefaViewModel = new TarefaViewModel(tarefa.Id, tarefa.Titulo, tarefa.Descricao);

            if (tarefaViewModel == null) return null;

            return tarefaViewModel;
        }

        public int AddTarefa(AddTarefaInputModel model)
        {
            var tarefa = new Tarefa(model.Titulo, model.Descricao);

            _tarefaRepositorio.Post(tarefa);

            return tarefa.Id;
        }

        public void Deletar(int id)
        {
            var tarefa = _tarefaRepositorio.GetById(id);

            _tarefaRepositorio.Delete(tarefa.Id);
        }

        public int EditTarefa(UpdateTarefaInputModel model)
        {

            var tarefa = _tarefaRepositorio.GetById(model.Id);
            if (tarefa != null)
            {
                tarefa.Titulo = model.Titulo;
                tarefa.Descricao = model.Descricao;
            }

            return model.Id;
        }

    }
}
