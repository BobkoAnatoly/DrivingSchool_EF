
using System.ComponentModel.DataAnnotations;

namespace DrivingSchool.Model.DatabaseModels
{
    public class Lesson
    {
        public int Id { get; set; }
        [Required]
        public DateTime LessonDate { get; set; }
        public TimeSpan Duration { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public IQueryable<Student>? Students { get; set; }
    }
}
