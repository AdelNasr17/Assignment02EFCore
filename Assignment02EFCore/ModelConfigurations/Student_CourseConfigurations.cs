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
    internal class Student_CourseConfigurations : IEntityTypeConfiguration<Student_Course>
    {
        public void Configure(EntityTypeBuilder<Student_Course> builder)
        {
            builder.ToTable("Students_Courses");
            builder.HasKey(Sc => new { Sc.Course_Id, Sc.Stud_Id });


          
        }
    }
}
