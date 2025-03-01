using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.ModelConfigurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);


            builder.Property(I => I.Name)
                  .IsRequired(true)
                  .HasColumnName("Name")
                  .HasColumnType("nvarchar(50)");


            builder.Property(I => I.Bouns)
                   .HasColumnType("decimal(10,4)");
                   

            builder.Property(I => I.Salary)
                  .HasColumnType("decimal(10,4)");
                  

            builder.Property(I => I.Bouns)
                 .HasColumnType("decimal(10,4)");

           

           


        }
    }
}
