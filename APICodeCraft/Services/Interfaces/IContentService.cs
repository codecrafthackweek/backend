using APICodeCraft.Models;

namespace APICodeCraft.Services.Interfaces
{
    public interface IContentService
    {
        Task<IEnumerable<Content>> GetAllContentAsync();

    }
}
