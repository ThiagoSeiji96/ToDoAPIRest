using Dominio.ViewModels;
using Entidade;

namespace Dominio.Service.Interface
{
    public interface IListaDeTarefasServico
    {
        ListaDeTarefasViewModel GetLista(int id);
    }
}