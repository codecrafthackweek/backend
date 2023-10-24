using APICodeCraft.Data;
using APICodeCraft.Models;
using APICodeCraft.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APICodeCraft.Services
{
    public class QuizService: IQuizService
    {
        private readonly DataContext _context;

        public QuizService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Quiz>> GetAllQuizAsync()
        {
            return await _context.Quizs.Include(q => q.Subtopic).ThenInclude(s => s.Course).ToListAsync();
        }

        public async Task<Quiz> GetQuizByIdAsync(int id)
        {
            return await _context.Quizs.Include(q => q.Subtopic).ThenInclude(s => s.Course).FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
