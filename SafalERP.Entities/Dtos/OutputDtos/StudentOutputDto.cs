using System;
using System.Collections.Generic;
using System.Text;

namespace SafalERP.Entities.Dtos.OutputDtos
{
    public class StudentOutputDto
    {
        public int id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string MobileNo { get; set; }
    }
}
