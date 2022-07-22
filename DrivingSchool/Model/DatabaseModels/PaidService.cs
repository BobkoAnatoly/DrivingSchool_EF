
namespace DrivingSchool.Model.DatabaseModels
{
    public class PaidService:Service
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
