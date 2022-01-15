using Business.Models.Produtos;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.Mappings
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            ToTable("Produtos");

            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000);

            Property(p => p.Imagem)
                .IsRequired();

            HasRequired(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.FornecedorId);
        }
    }
}
