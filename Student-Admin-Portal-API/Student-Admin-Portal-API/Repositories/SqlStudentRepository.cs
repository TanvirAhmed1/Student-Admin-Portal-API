using Microsoft.EntityFrameworkCore;
using Student_Admin_Portal_API.Datamodels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Admin_Portal_API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;

        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
