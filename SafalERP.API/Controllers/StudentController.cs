using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafalERP.Entities.Dtos.InputDtos;
using SafalERP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafalERP.API.Controllers
{
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogger<StudentController> _logger;
        public StudentController(IStudentService roleService, ILogger<StudentController> logger)
        {
            _studentService = roleService;
            _logger = logger;
        }
        [HttpPost]
        public async Task<ActionResult> Add(AddStudentInputDto model)
        {
            try
            {
                var student = await _studentService.AddStudent(model);
                return Ok(student);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Something went wrong!!!");
            }

        }
    }
}
