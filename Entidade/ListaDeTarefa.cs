using Entidade.Base;

namespace Entidade
{
    public class ListaDeTarefa : BaseEntity
    {
        public ListaDeTarefa(int idLista, int idUsuario)
        {
            IdLista = idLista;
            IdUsuario = idUsuario;
        }

        public int IdLista { get; private set; }
        public int IdUsuario { get; private set; }
        public Tarefa Tarefa { get; private set; }
    }
}