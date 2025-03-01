using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02EFCore.Models
{
    internal class Course_Instructor
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public double Evaluate { get; set; }
    }
}
