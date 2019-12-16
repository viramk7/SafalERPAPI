using AutoMapper;
using SafalERP.Data.Repositories;
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
    public class StudentService : GenericService<Student>, IStudentService
    {
        private readonly IStudentRepository _studRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository,
            IMapper mapper) : base(studentRepository, mapper)
        {
            _studRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentOutputDto> AddStudent(AddStudentInputDto addRoleInputDto)
        {
            var addstudent = _mapper.Map<Student>(addRoleInputDto);
            var role = await _studRepository.AddStudent(addstudent);
            return _mapper.Map<StudentOutputDto>(role);

        }
    }

}
