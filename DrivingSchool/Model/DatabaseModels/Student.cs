
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingSchool.Model.DatabaseModels
{
    [Table("Students")]
    public class Student : Person
    {
        public int StudyStreamId { get; set; }
        public StudyStream? StudyStream { get; set; }
        public IQueryable<Lesson>? Lessons { get; set; }
        public IQueryable<PaidService> PaidServices { get; set; }
    }
}
