using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Student_Admin_Portal_API.Datamodels;
using Student_Admin_Portal_API.DomainModels;
using Student_Admin_Portal_API.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student_Admin_Portal_API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await studentRepository.GetStudentsAsync();
            return Ok(mapper.Map<List<StudentDto>>(students));
        }
        [HttpGet]
        [Route("[controller]/{studentId:guid}")]
        public async Task<IActionResult> GetStudentAsync([FromRoute] Guid studentId)
        {
            var student = await studentRepository.GetStudentAsync(studentId);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<StudentDto>(student));
        }
        [HttpPut]
        [Route("[controller]/{studentId:guid}")]
        public async Task<IActionResult> UpdateStudentAsync([FromRoute] Guid studentId, [FromBody] UpdateStudentRequestDto request)
        {
            if (await studentRepository.Exists(studentId))
            {
                var updatedStudent = await studentRepository.UpdateStudent(studentId, mapper.Map<Student>(request));
                if (updatedStudent != null)
                {
                    return Ok(mapper.Map<StudentDto>(updatedStudent));
                }
            }

            return NotFound();

        }
    }
}
