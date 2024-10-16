using ConsoleApp4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp4.Data.confg
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder.HasKey(x => x.Pnum);
            builder.Property(x => x.Pnum).ValueGeneratedNever();

            builder.Property(x => x.PName)
               .HasColumnType("VARCHAR")
               .HasMaxLength(50);

            builder.Property(x => x.City)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

            builder.Property(x => x.Loc)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

            builder.HasOne(x => x.Departments)
              .WithMany(x => x.Projects)
              .HasForeignKey(x => x.Dnum);


          builder.HasMany(c => c.Employees)
         .WithMany(x => x.Projects)
         .UsingEntity<MyWork>(); 

            builder.ToTable("Projects");
        }

    }


}
