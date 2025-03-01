using Assignment02EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.ModelConfigurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(S => S.Id);
            builder.Property(S => S.Id).UseIdentityColumn(1, 1);


            builder.Property(S => S.FName)
                  .IsRequired(false)
                  .HasColumnName("FName")
                  .HasColumnType("nvarchar(50)");


            builder.Property(S => S.LName)
                  .HasColumnName("LName")
                  .HasColumnType("nvarchar(50)");

        }
    }
}
