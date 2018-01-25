using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntitySampleWFA.Source.BO
{
    [Table("Students", Schema = "SchoolSchem")]
    internal class Student
    {
        public Student()
        {
        }
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Name")]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public decimal Height { get; set; }

        public float Weight { get; set; }

        public byte[] Photo { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        [ForeignKey("Standard")]
        public int StandardId { get; set; }
        public Standard Standard { get; set; }

    }

    class StudentN
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public decimal Height { get; set; }

        public float Weight { get; set; }

        public byte[] Photo { get; set; }

        public int TeacherId { get; set; }

        public int StandardId { get; set; }
    }
}