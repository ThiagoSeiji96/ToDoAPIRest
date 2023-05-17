using Entidade.Base;

namespace Entidade
{
    public class Tarefa : BaseEntity
    {
        public Tarefa(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
        }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public ListaDeTarefa ListaDeTarefa { get; private set; }
        public int IdLista { get; private set; }
        public int IdUsuario {  get; private set; }


        //public void Atualizar(int id, string titulo, string descricao)
        //{
        //    Id = id;
        //    Titulo = titulo;
        //    Descricao = descricao;
        //}

    }
}