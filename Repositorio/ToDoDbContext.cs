using Entidade;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repositorio
{
    public class ToDoDbContext : DbContext
    {
        //public ToDoDbContext()
        //{
        //    Tarefas = new List<Tarefa>
        //    {
        //        new Tarefa(1, "Tarefa 1", "Descrição 1"),
        //        new Tarefa(2, "Tarefa 2", "Descrição 2"),
        //    };
        //}


        //CONSTRUTOR PARA CONEXÃO COM BANCO DE DADOS
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<ListaDeTarefa> ListasDeTarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}