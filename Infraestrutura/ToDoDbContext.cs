using Entidade;
using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class ToDoDbContext// : DbContext
    {
        public ToDoDbContext()
        {
            Tarefas = new List<Tarefa>
            {
                new Tarefa(1, "Tarefa 1", "Descrição 1"),
                new Tarefa(2, "Tarefa 2", "Descrição 2"),
            };
        }
        // CONSTRUTOR PARA CONEXÃO COM BANCO DE DADOS
        //public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        //{

        //}
        public List<Tarefa> Tarefas { get; set; }
    }
}