using APICodeCraft.Models;
using APICodeCraft.Services;
using APICodeCraft.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICodeCraft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quiz>>> GetAllQuiz()
        {
            try
            {
                var quizs = await _quizService.GetAllQuizAsync();
                return Ok(quizs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Quiz>> GetQuizId(int id)
        {
            try
            {
                var quiz = await _quizService.GetQuizByIdAsync(id);
                if (quiz == null) return NotFound("Error quiz not found!");

                return Ok(quiz);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Subtopic/{id}")]
        public async Task<ActionResult<IEnumerable<Quiz>>> GetQuizBySubtopicId(int id)
        {
            try
            {
                var quizzes = await _quizService.GetQuizBySubtopicId(id);
                if (quizzes == null) return NotFound("Subtopic id not found!");

                return Ok(quizzes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
