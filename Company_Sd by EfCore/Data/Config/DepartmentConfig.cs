using ConsoleApp4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp4.Data.confg
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Dum);
            builder.Property(x => x.Dum).ValueGeneratedNever();


            builder.Property(x => x.DName)
                 .HasColumnType("VARCHAR")
                 .HasMaxLength(50)
                 .IsRequired();

            builder.HasOne(x => x.Employees2)
             .WithOne(e => e.Departments2)
             .HasForeignKey<Department>(e => e.MgrSsn);
              



            builder.ToTable("Departments");
        }
    }
}
