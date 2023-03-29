using Entidade.Base;

namespace Entidade
{
    public class Tarefa //: BaseEntity
    {
        public Tarefa(int id, string titulo, string descricao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }



        public void Atualizar(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

    }
}