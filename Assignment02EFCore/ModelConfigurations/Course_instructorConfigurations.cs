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
    internal class Course_instructorConfigurations : IEntityTypeConfiguration<Course_Instructor>
    {
        public void Configure(EntityTypeBuilder<Course_Instructor> builder)
        {
            builder.ToTable("Courses_Instructors");
            builder.HasKey(CI => new { CI.Course_Id, CI.Inst_Id });

        

        }
    }
}
