using SafalERP.Entities.Dtos.InputDtos;
using SafalERP.Entities.Dtos.OutputDtos;
using SafalERP.Entities.Entities;
using SafalERP.Services.Generic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SafalERP.Services
{
    public interface IStudentService : IGenericService<Student>
    {
        Task<StudentOutputDto> AddStudent(AddStudentInputDto dto);
    }
}
