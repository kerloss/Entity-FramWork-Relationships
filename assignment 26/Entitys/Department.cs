using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_26.Entitys
{
    [Table("Departments")]
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        ////Navigation prop [one]
        //public Instructor instructor { get; set; }
        //navigation prop [many]
        [InverseProperty("department")]
        public ICollection<Student> students { get; set; } = new HashSet<Student>();
        public DateTime HiringDate { get; set; }
    }
}
