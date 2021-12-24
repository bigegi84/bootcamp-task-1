using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleRESTAPI.Models
{
    //[Table("Course")]
    public class Course
    {
        public int CourseID { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1500)]
        public string Description { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
