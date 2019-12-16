using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafalERP.Entities.Dtos.InputDtos;
using SafalERP.Entities.Dtos.OutputDtos;
using SafalERP.Entities.Entities;
using SafalERP.Services;
using SafalERP.Services.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafalERP.API.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly ITestService _testService;

        public StudentController( ILogger<StudentController> logger, ITestService testService)
        {
            _logger = logger;
            _testService = testService;
        }

        [HttpGet]
        public async Task<IActionResult> Test(int id, string name)
        {
            var testData = await _testService.GetData<GetTest, List<TestOutputDto>>(id, name);
            return Ok(testData);
        }


        //[HttpPost]
        //public async Task<ActionResult> Add(AddStudentInputDto model)
        //{
        //    try
        //    {
        //        var student = await _studentService.AddStudent(model);
        //        return Ok(student);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.StackTrace);
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Something went wrong!!!");
        //    }

        //}
    }
}
