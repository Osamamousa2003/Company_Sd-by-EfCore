using ConsoleApp4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp4.Data.confg
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {

            builder.HasKey(x => new { x.Dnum, x.loc });

            builder.Property(x => x.loc)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);

            builder.HasOne(x => x.Departments)
              .WithMany(x => x.Locations)
              .HasForeignKey(x => x.Dnum);

            builder.ToTable("Locations");

        }

    }
}
