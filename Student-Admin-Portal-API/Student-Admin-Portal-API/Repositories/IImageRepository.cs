using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;

namespace Student_Admin_Portal_API.Repositories
{
    public interface IImageRepository
    {
        Task<string> Upload(IFormFile file, string fileName);
    }
}
