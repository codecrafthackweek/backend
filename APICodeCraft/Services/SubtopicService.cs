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

        public async Task<IEnumerable<Subtopic>> GetSubtopicByCourseId(int CourseId)
        {
            var subtopics = await _context.Subtopics.Include(s => s.Course).Where(s => s.CourseId == CourseId).ToListAsync();

            return subtopics;
        }

        public async Task<Subtopic> GetSubtopicById(int id)
        {
            var subtopic = await _context.Subtopics
                .Include(s => s.Course)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (subtopic == null) { throw new Exception("Subtopic Not Found"); }

            return subtopic;
        }
    }
}
