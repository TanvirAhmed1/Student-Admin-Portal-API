using Student_Admin_Portal_API.Datamodels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student_Admin_Portal_API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
