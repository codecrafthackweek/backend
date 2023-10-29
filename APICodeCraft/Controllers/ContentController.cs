using APICodeCraft.Models;
using APICodeCraft.Services;
using APICodeCraft.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

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
            try
            {
                var contents = await _contentService.GetAllContentAsync();

                return Ok(contents);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContentById(int id)
        {
            try
            {
                var content = await _contentService.GetContentByIdAsync(id);
                if (content == null) return NotFound("Content not found!");

                return Ok(content);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Subtopic/{id}")]
        public async Task<ActionResult<IEnumerable<Content>>> GetContentBySubtopicIdAsync(int id)
        {
            try
            {
                var contents = await _contentService.GetContentBySubtopicIdAsync(id);
                if (contents == null) return NotFound("Subtopic id not found!");

                return Ok(contents);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
