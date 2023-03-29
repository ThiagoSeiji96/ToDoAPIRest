using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InputModels
{
    public class AddTarefaInputModel
    {
        public AddTarefaInputModel(int id, string titulo, string descricao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            IdList = 0;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int IdList { get; private set; }
    }
}
