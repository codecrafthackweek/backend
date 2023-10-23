using APICodeCraft.Models;

namespace APICodeCraft.Services.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCourseAsync();   
        
    }
}
