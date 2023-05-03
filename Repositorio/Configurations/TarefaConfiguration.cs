using Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Configurations
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.ListaDeTarefa)
                .WithMany()
                .HasForeignKey(x => x.IdLista)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
