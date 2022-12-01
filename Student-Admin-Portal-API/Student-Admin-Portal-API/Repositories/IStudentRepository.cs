using Student_Admin_Portal_API.Datamodels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student_Admin_Portal_API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);
    }
}
