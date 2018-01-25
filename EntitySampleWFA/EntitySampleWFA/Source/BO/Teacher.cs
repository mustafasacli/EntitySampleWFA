using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntitySampleWFA.Source.BO
{
    [Table("Teachers", Schema = "SchoolSchem")]
    internal class Teacher
    {
        public Teacher()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        [Column("TeacherId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("TeacherName")]
        [StringLength(100, MinimumLength = 10)]

        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    class TeacherN
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}