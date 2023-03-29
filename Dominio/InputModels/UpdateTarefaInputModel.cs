using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.InputModels
{
    public class UpdateTarefaInputModel
    {
        public UpdateTarefaInputModel(int id,string descricao)
        {
            Descricao = descricao;
            Id = id;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
