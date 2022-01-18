using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGameStore.DAL.Configurations
{
    public class StoreConfig:IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(35);
            builder.Property(p => p.Street)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(p => p.Number)
                .IsRequired()
                .HasMaxLength(5);
            builder.Property(p => p.Addition)
                .HasMaxLength(2);

            builder.Property(p => p.ZipCode)
                .IsRequired()
                .HasMaxLength(6);

            builder.Property(p => p.City)
                .HasColumnName("Place")
                .HasMaxLength(60);
            builder.HasIndex(u => u.Name).IsUnique();
        }
    }
}
