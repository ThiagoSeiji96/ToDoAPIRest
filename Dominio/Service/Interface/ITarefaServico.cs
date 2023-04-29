using Dominio.InputModels;
using Dominio.ViewModels;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Service.Interface
{
    public interface ITarefaServico
    {
        List<TarefaViewModel> BuscarTodos();
        TarefaViewModel BuscarPorId(int id);
        int AddTarefa(AddTarefaInputModel tarefa);
        void Deletar(int id);
        int EditTarefa(AddTarefaInputModel tarefa);
    }
}
