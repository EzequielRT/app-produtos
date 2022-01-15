using Business.Models.Fornecedores;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.Mappings
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            ToTable("Enderecos");

            HasKey(e => e.Id);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(20);

            Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(e => e.Complemento)
                .HasMaxLength(200);

            Property(e => e.Bairro)
                .IsRequired();

            Property(e => e.Cidade)
                .IsRequired();

            Property(e => e.Estado)
                .IsRequired();
        }
    }
}
