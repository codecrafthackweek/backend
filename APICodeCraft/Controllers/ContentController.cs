using APICodeCraft.Models;
using APICodeCraft.Services;
using APICodeCraft.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICodeCraft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;

        public ContentController(IContentService contentService)
        {
            this._contentService = contentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Content>>> GetAllContent()
        {
            var contents = await _contentService.GetAllContentAsync();
            return Ok(contents);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContentById(int id)
        {
            var content = await _contentService.GetContentByIdAsync(id);
            if (content == null)
            {
                return NotFound("Content not found!");
            }
            else
            {
                return Ok(content);            
            }

        }

        [HttpGet("Subtopic/{id}")]
        public async Task<ActionResult<IEnumerable<Content>>> GetContentBySubtopicIdAsync(int id)
        {
            var contents = await _contentService.GetContentBySubtopicIdAsync(id);
            if (contents == null) return NotFound("Subtopic id not found!");
            return Ok(contents);

        }
    }
}
