using APICodeCraft.Data;
using APICodeCraft.Models;
using APICodeCraft.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APICodeCraft.Services
{
    public class SubtopicService: ISubtopicService
    {
        private readonly DataContext _context;

        public SubtopicService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Subtopic>> GetAllSubtopicAsync()
        {
            return await _context.Subtopics.Include(s => s.Course).ToListAsync();
        }
    }
}
