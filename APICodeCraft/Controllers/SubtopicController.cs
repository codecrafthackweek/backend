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
            try
            {
                var subtopic = await _subtopicService.GetSubtopicById(id);
                return Ok(subtopic);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
