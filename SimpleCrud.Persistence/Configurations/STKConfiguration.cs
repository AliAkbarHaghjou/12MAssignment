using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCrud.Domain.Entities;

namespace SimpleCrud.Persistence.Configurations
{
    public class STKConfiguration : IEntityTypeConfiguration<STK>
    {
        public void Configure(EntityTypeBuilder<STK> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(m => m.MalAdi).IsRequired().HasMaxLength(100);
            builder.Property(m => m.MalKodu).IsRequired().HasMaxLength(100);
            builder.ToTable("STK", "dbo");
        }
    }
}