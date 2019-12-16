using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SafalERP.Entities.Dtos.InputDtos
{
    public class AddStudentInputDto
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string MobileNo { get; set; }
    }
}
