using ConsoleApp4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Data.confg
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
              builder.HasKey(x=>x.Ssn);
              builder.Property(x=>x.Ssn).ValueGeneratedNever();

            builder.Property(x => x.Gender)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(50)
                    .IsRequired();

            builder.Property(x => x.FirstName)
                 .HasColumnType("VARCHAR")
                 .HasMaxLength(50)
                 .IsRequired();


            builder.Property(x => x.LastName)
                 .HasColumnType("VARCHAR")
                 .HasMaxLength(50)
                 .IsRequired();

            builder.HasOne(x => x.Supervise)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.SuperId);



            builder.HasOne(x => x.Departments)
              .WithMany(x => x.Employees)
              .HasForeignKey(x => x.Dnum);
               


            builder.ToTable("Employees");


        }

       
    }
}
