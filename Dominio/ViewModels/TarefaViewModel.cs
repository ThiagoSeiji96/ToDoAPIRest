using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ViewModels
{
    public class TarefaViewModel
    {
        public TarefaViewModel(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
        }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
    }
}
