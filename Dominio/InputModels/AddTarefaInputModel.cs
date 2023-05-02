using Entidade.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InputModels
{
    public class AddTarefaInputModel : BaseEntity
    {
        public AddTarefaInputModel(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            IdList = 0;
        }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int IdList { get; private set; }
    }
}
