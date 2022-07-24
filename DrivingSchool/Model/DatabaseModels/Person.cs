using System.ComponentModel.DataAnnotations;

namespace DrivingSchool.Model.DatabaseModels
{
    
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
