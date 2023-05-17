using Dominio.Service.Interface;
using Dominio.ViewModels;
using Entidade;
using Entidade.Repositories;

namespace Dominio.Service.Implementations
{
    public class ListaDeTarefasServico : IListaDeTarefasServico
    {
        private readonly IListaDeTarefasRepositorio _listaDeTarefaRepositorio;
        public ListaDeTarefasServico(IListaDeTarefasRepositorio listaDeTarefasRepositorio)
        {
            _listaDeTarefaRepositorio = listaDeTarefasRepositorio;
        }
        public ListaDeTarefasViewModel GetLista(int id)
        {
            var tarefa = _listaDeTarefaRepositorio.GetListaById(id);

            var listaViewModel = new ListaDeTarefasViewModel(tarefa.IdLista, tarefa.IdUsuario);

            return listaViewModel;
        }
    }
}
