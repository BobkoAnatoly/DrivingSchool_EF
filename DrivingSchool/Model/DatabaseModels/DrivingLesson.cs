
namespace DrivingSchool.Model.DatabaseModels
{
    public class DrivingLesson : Lesson
    {
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
