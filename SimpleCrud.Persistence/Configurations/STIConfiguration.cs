using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCrud.Domain.Entities;

namespace SimpleCrud.Persistence.Configurations
{
    public class STIConfiguration : IEntityTypeConfiguration<STI>
    {
        public void Configure(EntityTypeBuilder<STI> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(m => m.IslemTur).IsRequired();
            builder.Property(m => m.EvrakNo).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Tarih).IsRequired();
            builder.Property(m => m.MalKodu).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Miktar).IsRequired();
            builder.Property(m => m.Fiyat).IsRequired();
            builder.Property(m => m.Tutar).IsRequired();
            builder.Property(m => m.Birim).IsRequired().HasMaxLength(100);
            builder.ToTable("STI", "dbo");
        }
    }
}