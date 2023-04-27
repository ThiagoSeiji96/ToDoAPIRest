using Entidade.Base;
using Entidade.Enums;

namespace Entidade
{
    public class Tarefa //: BaseEntity
    {
        public Tarefa(int id, string titulo, string descricao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Status = TarefaStatus.Iniciado;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public TarefaStatus Status { get; private set; }



        public void Atualizar(int id, string titulo, string descricao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
        }

        public void Finalizado()
        {
            Status = TarefaStatus.Finalizado;
        }

    }
}