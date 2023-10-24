using APICodeCraft.Data;
using APICodeCraft.Models;
using APICodeCraft.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APICodeCraft.Services
{
    public class ContentService : IContentService
    {
        private readonly DataContext _context;

        public ContentService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Content>> GetAllContentAsync()
        {
            return await _context.Contents.Include(c => c.Subtopic).ThenInclude(s => s.Course).ToListAsync();
        }

        public async Task<Content> GetContentByIdAsync(int id)
        {
            var content = await _context.Contents
                .Include(c => c.Subtopic)
                .ThenInclude(s => s.Course)
                .FirstOrDefaultAsync(c => c.Id == id);

            return content;
        }
    }
}
