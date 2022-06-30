using Dogs.Core.Entities;
using Dogs.Core.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dogs.Infrastructure.Dal.Configuration
{
    public class DogConfiguration : IEntityTypeConfiguration<Dog>
    {
        public void Configure(EntityTypeBuilder<Dog> builder)
        {
            builder.HasKey(x => x.DogId);
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Name)
                .HasConversion(x => x.Value, x => new Name(x))
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Color)
                .HasConversion(x => x.Value, x => new Color(x))
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.TailLenght)
                .HasConversion(x => x.Value, x => new TailLenght(x))
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(x => x.Weight)
                .HasConversion(x => x.Value, x => new Weight(x))
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
