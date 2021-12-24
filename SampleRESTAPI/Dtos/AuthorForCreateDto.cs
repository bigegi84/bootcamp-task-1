using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SampleRESTAPI.Dtos
{
    public class AuthorForCreateDto : IValidatableObject
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string MainCategory { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if( FirstName.Length >= 50) {
                yield return new ValidationResult("FirstName harus lebih kecil dari 50 karakter.",
                    new[] { "FirstName" });
            }

            //if (Credits >= 10)
            //{
            //    yield return new ValidationResult("harus lebih kecil dari 10 karakter",
            //        new[] { "Credits" });
            //}
        }
    }
}
