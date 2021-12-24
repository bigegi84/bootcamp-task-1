using System;
using System.ComponentModel.DataAnnotations;

namespace SampleRESTAPI.Dtos
{
    public class AuthorDto
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MainCategory { get; set; }
    }
}
