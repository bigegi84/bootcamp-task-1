using System;
using System.ComponentModel.DataAnnotations;

namespace SampleRESTAPI.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        [Required(ErrorMessage = "FirstName harus di isi.")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName harus di isi.")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "DateOfBirth harus di isi.")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "MainCategory harus di isi.")]
        [MaxLength(50)]
        public string MainCategory { get; set; }
    }
}
