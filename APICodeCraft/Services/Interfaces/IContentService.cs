using APICodeCraft.Models;

namespace APICodeCraft.Services.Interfaces
{
    public interface IContentService
    {
        Task<IEnumerable<Content>> GetAllContentAsync();
        Task<Content> GetContentByIdAsync(int id);
        Task<IEnumerable<Content>> GetContentBySubtopicIdAsync(int SubtopicId);

    }
}
