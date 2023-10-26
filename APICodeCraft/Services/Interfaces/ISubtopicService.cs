using APICodeCraft.Models;

namespace APICodeCraft.Services.Interfaces
{
    public interface ISubtopicService
    {
        Task<IEnumerable<Subtopic>> GetAllSubtopicAsync();
        Task<Subtopic> GetSubtopicById(int id);
        Task<IEnumerable<Subtopic>> GetSubtopicByCourseId(int CourseId);
    }
}
