using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_26.Entitys
{
    [Table("Courses")]
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //(1,1)
        public int Id { get; set; }
        public DateTime Duration { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        //Navigation property  => [one]
        public Topic Topic { get; set; }
    }
}
