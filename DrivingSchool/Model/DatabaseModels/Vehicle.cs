
using System.ComponentModel.DataAnnotations;

namespace DrivingSchool.Model.DatabaseModels
{
    public class Vehicle
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public IQueryable<DrivingLesson>? DrivingLessons { get; set; }
    }
}
