using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Student_Admin_Portal_API.DomainModels;
using Student_Admin_Portal_API.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Admin_Portal_API.Controllers
{
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public GendersController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllGenders()
        {
            var genderList = await studentRepository.GetGendersAsync();
            if(genderList == null || !genderList.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<GenderDto>>(genderList));
        }
    }
}
