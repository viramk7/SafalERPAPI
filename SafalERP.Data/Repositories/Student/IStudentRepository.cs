using SafalERP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SafalERP.Data.Repositories
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<Student> AddStudent(Student model);
    }
}
