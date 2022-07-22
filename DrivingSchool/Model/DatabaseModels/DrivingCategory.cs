using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchool.Model.DatabaseModels
{
    public class DrivingCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public IQueryable<StudyStream>? StudyStreams { get; set; }
    }
}
