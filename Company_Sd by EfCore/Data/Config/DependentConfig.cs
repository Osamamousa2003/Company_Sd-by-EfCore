using ConsoleApp4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp4.Data.confg
{
    public class DependentConfig : IEntityTypeConfiguration<Dependent>
    {
        public void Configure(EntityTypeBuilder<Dependent> builder)
        {

            builder.HasKey(x => new { x.Ssn, x.DeptName });

            builder.Property(x => x.DeptName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Gender)
               .HasColumnType("VARCHAR")
               .HasMaxLength(50)
               .IsRequired();


            builder.HasOne(x => x.Employees)
              .WithMany(x => x.Dependents)
              .HasForeignKey(x => x.Ssn).IsRequired();

            builder.ToTable("Dependents");

        }


    }
}
