using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateOnly HiringDate { get; set; }
       
        public int Course_Id { get; set; }
    }
}
