using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [DataType(DataType.Duration)]
        public int Duration { get; set; }
        
        public int Topic_Id { get; set; }

    }
}
