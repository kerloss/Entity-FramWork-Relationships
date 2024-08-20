using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_26.Entitys
{
    internal class Course_Inst
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public double Evaluation { get; set; }
    }
}
