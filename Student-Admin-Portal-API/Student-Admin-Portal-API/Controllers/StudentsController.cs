﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Student_Admin_Portal_API.DomainModels;
using Student_Admin_Portal_API.Repositories;
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
    }
}