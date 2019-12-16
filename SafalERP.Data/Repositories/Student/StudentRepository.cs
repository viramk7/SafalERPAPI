using Microsoft.EntityFrameworkCore;
using SafalERP.Entities.DbContexts;
using SafalERP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SafalERP.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly SafalERPDBContext _context;
        public StudentRepository(SafalERPDBContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Student> AddStudent(Student model)
        {
            await _context.Students.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
