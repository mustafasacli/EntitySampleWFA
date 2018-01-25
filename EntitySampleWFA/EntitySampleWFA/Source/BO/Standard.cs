using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntitySampleWFA.Source.BO
{
    [Table("Standards", Schema = "SchoolSchem")]
    internal class Standard
    {
        public Standard()
        {
            Students = new HashSet<Student>();
        }

        [Key]
        [Column("StandardId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("StandartName")]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    internal class StandardN
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}