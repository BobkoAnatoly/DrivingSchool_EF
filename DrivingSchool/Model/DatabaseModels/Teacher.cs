using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingSchool.Model.DatabaseModels
{
    [Table("Teachers")]
    public class Teacher : Person
    {
        [Required]
        public decimal Salary { get; set; }
        public IQueryable<Lesson>? Lessons { get; set; }
    }
}
