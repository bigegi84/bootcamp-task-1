using System;
using System.ComponentModel.DataAnnotations;

namespace SampleRESTAPI.Models
{
    public class Author
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(50)]
        public string MainCategory { get; set; }
    }
}
