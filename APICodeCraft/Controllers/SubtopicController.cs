using APICodeCraft.Models;
using APICodeCraft.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICodeCraft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubtopicController : ControllerBase
    {
        private readonly ISubtopicService _subtopicService;

        public SubtopicController(ISubtopicService subtopicService)
        {
            _subtopicService = subtopicService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subtopic>>> GetAllSubtopic()
        { 
            var subtopics = await _subtopicService.GetAllSubtopicAsync();
            return Ok(subtopics);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubtopicoById(int id)
        {
           
           var subtopic = await _subtopicService.GetSubtopicById(id);
            if (subtopic == null) return NotFound("Subtopic id not found!");

            return Ok(subtopic);
            
        }

        [HttpGet("Course/{id}")]
        public async Task<ActionResult<IEnumerable<Subtopic>>> GetSubtopicByCourseId(int id)
        {
            var subtopics = await _subtopicService.GetSubtopicByCourseId(id);
            if (subtopics == null) return NotFound("Course id not found!");
            return Ok(subtopics);

        }
    }
}
