namespace Entidade.Repositories
{
    public interface ITarefaRepositorio
    {
        Tarefa GetById(int id);
        List<Tarefa> GetAll();
        int Post(Tarefa tarefa);
        int Edit(Tarefa tarefa);
        void Delete(int id);


    }
}
