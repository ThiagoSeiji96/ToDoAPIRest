namespace Dominio.ViewModels
{
    public class ListaDeTarefasViewModel
    {
        public ListaDeTarefasViewModel(int idLista, int idUsuario)
        {
            IdLista = idLista;
            IdUsuario = idUsuario;
        }

        public int IdLista { get; private set; }
        public int IdUsuario { get; private set; }
    }
}
