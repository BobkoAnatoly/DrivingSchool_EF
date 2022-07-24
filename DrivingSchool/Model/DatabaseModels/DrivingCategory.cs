using System.ComponentModel.DataAnnotations;

namespace DrivingSchool.Model.DatabaseModels
{
    public class DrivingCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<StudyStream>? StudyStreams { get; set; }
    }
}
