using DevIO.BusinessOrDomain.EntitiesOrModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.DataOrInfrastructure.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(e => e.Endereco)
                .WithOne(f => f.Fornecedor);

            // 1 : N => Fornecedor : Produtos
            builder.HasMany(p => p.Produtos)
                .WithOne(f => f.Fornecedor)
                .HasForeignKey(f => f.FornecedorId);

            builder.ToTable("Fornecedores");
        }
    }
}
