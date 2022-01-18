using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGameStoreLib.Configurations
{
    public class PersonConfig:IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(70);
            builder.Property(p => p.Email)
                .HasColumnName("EmailAddress")
                .HasMaxLength(100);

            builder.HasIndex(u => u.Email).IsUnique();
        }

        
    }
}
