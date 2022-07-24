
namespace DrivingSchool.Model.DatabaseModels
{
    public class StudyStream
    {
        public int Id { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public IQueryable<Student> Students { get; set; }
        public int DrivingCategoryId { get; set; }
        public DrivingCategory DrivingCategory { get; set; }
    }
}
