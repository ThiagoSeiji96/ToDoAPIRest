using Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasKey(x=> x.Id);

            builder
                .HasMany(x => x.ListaDeTarefasDoUsuario)
                .WithOne()
                .HasForeignKey(x=>x.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
