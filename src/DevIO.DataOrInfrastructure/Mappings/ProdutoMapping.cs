﻿using DevIO.BusinessOrDomain.EntitiesOrModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.DataOrInfrastructure.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.ToTable("Produtos");
        }
    }
}
