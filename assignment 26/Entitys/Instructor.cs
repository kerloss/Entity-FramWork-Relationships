using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_26.Entitys
{
    [Table("Instructors")]
    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Bounce { get; set; }
        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        [Required]
        public string Address { get; set; }
        public double Hour_Rate { get; set; }
        //Navigation prop [one]
        public Department department { get; set; }
    }
}
