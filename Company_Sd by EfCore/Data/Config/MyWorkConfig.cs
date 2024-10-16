using ConsoleApp4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp4.Data.confg
{
    public class MyWorkConfig : IEntityTypeConfiguration<MyWork>
    {
        public void Configure(EntityTypeBuilder<MyWork> builder)
        {

            builder.HasKey(x => new { x.Ssn, x.PNum });

            builder.Property(x => x.Hours)
                .HasMaxLength(50);


            builder.ToTable("MyWork");

        }

    }
}
