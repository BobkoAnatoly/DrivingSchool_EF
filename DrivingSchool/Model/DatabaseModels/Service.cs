
using System.ComponentModel.DataAnnotations;

namespace DrivingSchool.Model.DatabaseModels
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
