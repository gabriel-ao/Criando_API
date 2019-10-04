using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Dados.Infra.Persistence.Map
{
    class MapUsuario : EntityTypeConfiguration<DadosPessoais.Dados>
    {

        public MapUsuario()
        {
            ToTable("Usuario");

            Property(p => p.Email).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_USUARIO_EMAIL") { IsUnique = true })).HasColumnName("Email");
            Property(p => p.Senha).IsRequired();
            Property(p => p.Nome).HasMaxLength(50).IsRequired();
            Property(p => p.Genero).IsRequired();
            Property(p => p.Idade).IsRequired();


        }
    }
}
