using Microsoft.EntityFrameworkCore;

namespace DrivingSchool.Model.DatabaseModels.SpResultModels
{
    [Keyless]
    public class SpStudyStream
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CategoryName { get; set; }
    }
}
