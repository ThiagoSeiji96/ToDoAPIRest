using Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Configurations
{
    public class ListaDeTarefaConfiguration : IEntityTypeConfiguration<ListaDeTarefa>
    {
        public void Configure(EntityTypeBuilder<ListaDeTarefa> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
