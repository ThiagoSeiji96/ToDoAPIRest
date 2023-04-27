using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ViewModels
{
    public class TarefaViewModel
    {
        public TarefaViewModel(int id, string titulo, string descricao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
        }
        public int Id { get; set; }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
    }
}
