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
        Task<List<Gender>> GetGendersAsync();
        Task<bool> Exists(Guid studentId);
        Task<Student> UpdateStudent(Guid studentId, Student request);
        Task<Student> DeleteStudent(Guid studentId);
        Task<Student> AddStudent(Student student);
    }
}
