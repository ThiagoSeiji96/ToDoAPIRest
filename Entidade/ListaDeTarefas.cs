namespace Entidade
{
    public class ListaDeTarefas
    {
        public ListaDeTarefas(int idUsuario, int idLista)
        {
            IdUsuario = idUsuario;
            IdLista = idLista;
        }

        public int IdUsuario { get; private set; }
        public int IdLista { get; private set; }
        public int IdTarefa { get; private set; }
    }
}