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
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(C => C.Id);
            builder.Property(C => C.Id).UseIdentityColumn(10, 10);


            builder.Property(C => C.Name)
                  .IsRequired(true)
                  .HasColumnName("Name")
                  .HasColumnType("nvarchar(50)");

            builder.Property(C => C.Duration)
                  .IsRequired(true)
                  .HasColumnName("Duration")
                  .HasColumnType("int");

            builder.Property(C => C.Topic_Id)
                  .IsRequired(true)
                  .HasColumnName("Topic_Id")
                  .HasColumnType("int");
        }
    }
}
