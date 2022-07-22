using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Model.DatabaseModels
{
    public class StudyStream
    {
        public int Id { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public IQueryable<Student> Students { get; set; }
        public IQueryable<Lesson> Lessons { get; set; }
        public int DrivingCategoryId { get; set; }
        public DrivingCategory DrivingCategory { get; set; }
    }
}
