using Assignment02EFCore.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.ModelConfigurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(D=> D.Id);
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);


            builder.Property(D => D.Name)
                  .IsRequired(true)
                  .HasColumnName("Name")
                  .HasColumnType("nvarchar(100)");

            builder.Property(D => D.HiringDate)
                   .HasColumnType("Date")
                   .IsRequired(true);

            builder.Property(D => D.Course_Id)
                   .HasColumnType("int")
                   .IsRequired(true);

        }
    }
}
